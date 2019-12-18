using DoAnLTUDQL1.ViewModels;
using DoAnLTUDQL1.Views.Admin;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace DoAnLTUDQL1.Presenters
{
    public class AdminPresenter
    {
        private IAdminView view;

        public AdminPresenter(IAdminView adminView)
        {
            view = adminView;
            Initializer();
        }

        public void Initializer()
        {
            IEnumerable<RoleType> roleTypes;
            using (var context = new QLThiTracNghiemDataContext())
            {
                roleTypes = context.RoleTypes.Where(r => r.RoleName != "Admin").ToList();
            }
            view.RoleTypes = roleTypes;

            view.ConnectionString = SqlHelper.GetConnectionString;

            LoadData();
            view.Reload += Reload;
            view.SaveEdit += SaveEdit;
            view.AddUser += AddUser;
            view.ImportUser += ImportUser;
            view.ExportUser += ExportUser;
            view.SaveConfig += SaveConfig;
            view.CheckConnection += CheckConnection;
            view.RestoreData += RestoreData;
            view.BackupData += BackupData;
        }

        private void Reload(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                view.Users = context.Users.Select(u => new AdminViewModel
                {
                    Username = u.Username,
                    Password = u.Password,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Dob = u.Dob,
                    Phone = u.Phone,
                    CreatedDate = u.CreatedDate,
                    Status = u.Status,
                    LastLoginDate = u.LastLoginDate,
                    RoleTypeId = u.RoleTypeId,
                    RoleName = u.RoleType.RoleName
                }).ToList();
            }
        }

        private void SaveEdit(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                foreach (var user in context.Users)
                {
                    var checkExist = view.Users.FirstOrDefault(_ => view.UserEdit.Username == user.Username);
                    if (checkExist != null)
                    {
                        user.Username = view.UserEdit.Username;

                        if (!string.IsNullOrWhiteSpace(view.UserEdit.Password))
                        {
                            user.Password = Common.HashPassword(view.UserEdit.Password);
                        }

                        user.FirstName = view.UserEdit.FirstName;
                        user.LastName = view.UserEdit.LastName;
                        user.Dob = view.UserEdit.Dob;
                        user.Phone = view.UserEdit.Phone;
                        user.Status = view.UserEdit.Status;
                    }
                }

                context.SubmitChanges();
            }
        }

        private void AddUser(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                var checkExist = view.Users.FirstOrDefault(u => u.Username == view.UserAdd.Username);
                if (checkExist != null)
                {
                    view.AddMessage = "User existed";
                    return;
                }

                view.UserAdd.Password = Common.HashPassword(view.UserAdd.Password);
                view.UserAdd.CreatedDate = DateTime.Now;

                AddUserToClassifiedTable(view.UserAdd, context);

                context.Users.InsertOnSubmit(view.UserAdd);
                context.SubmitChanges();
            }

            view.AddMessage = "Success add user";
        }

        private void ImportUser(object sender, EventArgs e)
        {
            if (File.Exists(view.Path))
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    IList<User> userImports = new List<User>();

                    //Create COM Objects. Create a COM object for everything that is referenced
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbooks xlWorkbooks = xlApp.Workbooks;
                    Excel.Workbook xlWorkbook = xlWorkbooks.Open(view.Path);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;

                    try
                    {
                        int rowCount = xlRange.Rows.Count;

                        //iterate over the rows and columns and print to the console as it appears in the file
                        //excel is not zero based!!
                        for (int i = 2; i <= rowCount; i++)
                        {
                            string username = xlRange.Cells[i, 1].Value2.ToString();

                            var userDb = context.Users.FirstOrDefault(u => u.Username == username);
                            if (userDb != null)
                            {
                                continue;
                            }

                            var user = new User
                            {
                                Username = xlRange.Cells[i, 1].Value2.ToString(),
                                Password = Common.HashPassword(xlRange.Cells[i, 2].Value2.ToString()),
                                FirstName = xlRange.Cells[i, 3].Value2.ToString(),
                                LastName = xlRange.Cells[i, 4].Value2.ToString(),
                                Dob = FromExcelSerialDate((double)xlRange.Cells[i, 5].Value2),
                                Phone = xlRange.Cells[i, 6].Value2.ToString(),
                                CreatedDate = DateTime.Now,
                                Status = (bool)xlRange.Cells[i, 7].Value2,
                                RoleTypeId = (int)xlRange.Cells[i, 8].Value2
                            };

                            userImports.Add(user);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.ToString());
                    }
                    finally
                    {
                        //cleanup
                        GC.Collect();
                        GC.WaitForPendingFinalizers();

                        //release com objects to fully kill excel process from running in the background
                        Marshal.ReleaseComObject(xlRange);
                        Marshal.ReleaseComObject(xlWorksheet);

                        //close and release
                        xlWorkbook.Close(0);
                        Marshal.ReleaseComObject(xlWorkbook);
                        Marshal.ReleaseComObject(xlWorkbooks);

                        //quit and release
                        xlApp.Quit();
                        Marshal.ReleaseComObject(xlApp);
                    }

                    foreach (var user in userImports)
                    {
                        AddUserToClassifiedTable(user, context);
                    }

                    context.Users.InsertAllOnSubmit(userImports);
                    context.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                }

                view.Path = "";
                view.ImportMessage = "Success";
            }
            else
            {
                view.ImportMessage = "File not exists";
            }
        }

        private void ExportUser(object sender, EventArgs e)
        {
            try
            {
                IList<User> exportUsers = new List<User>();

                using (var context = new QLThiTracNghiemDataContext())
                {
                    exportUsers = context.Users.Where(u => u.RoleTypeId != 0).ToList();
                }

                //Create COM Objects. Create a COM object for everything that is referenced
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbooks xlWorkbooks = xlApp.Workbooks;
                Excel.Workbook xlWorkbook = xlWorkbooks.Add("");
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                try
                {
                    Excel.Range range;

                    // Write header
                    xlRange.Cells[1, 1].Value2 = "Tên người dùng";
                    xlRange.Cells[1, 2].Value2 = "Tên";
                    xlRange.Cells[1, 3].Value2 = "Họ";
                    xlRange.Cells[1, 4].Value2 = "Ngày sinh";
                    range = (Excel.Range)xlWorksheet.Cells[1, 4];
                    range.EntireColumn.NumberFormat = "DD/MM/YYYY";
                    xlRange.Cells[1, 5].Value2 = "Số điện thoại";
                    xlRange.Cells[1, 6].Value2 = "Ngày tạo tài khoản";
                    range = (Excel.Range)xlWorksheet.Cells[1, 6];
                    range.EntireColumn.NumberFormat = "DD/MM/YYYY";
                    xlRange.Cells[1, 7].Value2 = "Trạng thái";
                    xlRange.Cells[1, 8].Value2 = "Lần đăng nhập cuối";
                    range = (Excel.Range)xlWorksheet.Cells[1, 8];
                    range.EntireColumn.NumberFormat = "DD/MM/YYYY";
                    xlRange.Cells[1, 9].Value2 = "Mã vai trò";

                    int rowCount = exportUsers.Count + 1;

                    //iterate over the rows and columns
                    //excel is not zero based!!
                    for (int i = 2; i <= rowCount; i++)
                    {
                        xlRange.Cells[i, 1].Value2 = exportUsers[i - 2].Username;
                        xlRange.Cells[i, 2].Value2 = exportUsers[i - 2].FirstName;
                        xlRange.Cells[i, 3].Value2 = exportUsers[i - 2].LastName;
                        xlRange.Cells[i, 4].Value2 = exportUsers[i - 2].Dob.GetValueOrDefault(DateTime.Parse("01/01/0001"));
                        xlRange.Cells[i, 5].Value2 = exportUsers[i - 2].Phone;
                        xlRange.Cells[i, 6].Value2 = exportUsers[i - 2].CreatedDate.GetValueOrDefault(DateTime.Parse("01/01/0001"));
                        xlRange.Cells[i, 7].Value2 = exportUsers[i - 2].Status;
                        xlRange.Cells[i, 8].Value2 = exportUsers[i - 2].LastLoginDate.GetValueOrDefault(DateTime.Parse("01/01/0001"));
                        xlRange.Cells[i, 9].Value2 = exportUsers[i - 2].RoleTypeId;
                    }

                    xlWorkbook.SaveAs(view.Path + @"\export_" + DateTime.Now.ToString("dd.MM.yyyy") + ".xlsx",
                                      Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false,
                                      Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
                finally
                {
                    //cleanup
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    //release com objects to fully kill excel process from running in the background
                    Marshal.ReleaseComObject(xlRange);
                    Marshal.ReleaseComObject(xlWorksheet);

                    //close and release
                    xlWorkbook.Close(0);
                    Marshal.ReleaseComObject(xlWorkbook);
                    Marshal.ReleaseComObject(xlWorkbooks);

                    //quit and release
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }

                view.Path = "";
                view.ExportMessage = "Success";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.ExportMessage = "Failed";
            }
        }

        private DateTime FromExcelSerialDate(double SerialDate)
        {
            if (SerialDate > 59) SerialDate -= 1; //Excel/Lotus 2/29/1900 bug
            return new DateTime(1899, 12, 31).AddDays(SerialDate);
        }

        private void AddUserToClassifiedTable(User user, QLThiTracNghiemDataContext context)
        {
            // Add user to student table
            if (user.RoleTypeId == 1)
            {
                long studentId;
                if (context.Students.Count() == 0)
                {
                    studentId = 0;
                }
                else
                {
                    var studentIds = context.Students.Select(s => s.StudentId).ToList();
                    studentId = studentIds.Select(id => long.Parse(id.Substring(2))).Max();
                }
                studentId++;

                var student = new Student
                {
                    StudentId = $"HS{studentId:D7}",
                    Username = user.Username,
                    ClassroomId = null
                };

                context.Students.InsertOnSubmit(student);
            }

            // Add user to teacher table
            if (user.RoleTypeId == 2)
            {
                long teacherId;
                if (context.Teachers.Count() == 0)
                {
                    teacherId = 0;
                }
                else
                {
                    var teacherIds = context.Teachers.Select(s => s.TeacherId).ToList();
                    teacherId = teacherIds.Select(id => long.Parse(id.Substring(2))).Max();
                }
                teacherId++;

                var teacher = new Teacher
                {
                    TeacherId = $"GV{teacherId:D7}",
                    Username = user.Username,
                };

                context.Teachers.InsertOnSubmit(teacher);
            }
        }

        private void SaveConfig(object sender, EventArgs e)
        {
            try
            {
                SqlHelper sqlHelper = new SqlHelper(view.ConnectionString);
                if (sqlHelper.IsConnection)
                {
                    var MyConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    MyConfig.ConnectionStrings.ConnectionStrings[SqlHelper.ContextName].ConnectionString = view.ConnectionString;
                    MyConfig.ConnectionStrings.ConnectionStrings[SqlHelper.ContextName].ProviderName = SqlHelper.ProviderName;
                    MyConfig.Save(ConfigurationSaveMode.Modified);

                    view.SaveConfigMessage = "Succeed";
                }
                else
                {
                    view.CheckConnectionMessage = "Failed";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.CheckConnectionMessage = "Failed";
            }
        }

        private void CheckConnection(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper(view.ConnectionString);
            try
            {
                if (sqlHelper.IsConnection)
                {
                    view.CheckConnectionMessage = "Succeed";
                }
                else
                {
                    view.CheckConnectionMessage = "Failed";
                }
            }
            catch (Exception)
            {
                view.CheckConnectionMessage = "Failed";
            }
        }

        private void RestoreData(object sender, EventArgs e)
        {
            try
            {
                var connectionString = SqlHelper.GetConnectionString;
                SqlHelper sqlHelper = new SqlHelper(connectionString);

                ServerConnection serverConnection = sqlHelper.Username != null ? new ServerConnection(sqlHelper.ServerName, sqlHelper.Username, sqlHelper.Password) : new ServerConnection(sqlHelper.ServerName);
                Server dbServer = new Server(serverConnection);
                Restore dbRestore = new Restore
                {
                    Action = RestoreActionType.Database,
                    Database = sqlHelper.DatabaseName,
                    ReplaceDatabase = true,
                    NoRecovery = false
                };
                BackupDeviceItem destination = new BackupDeviceItem(view.Path, DeviceType.File);
                dbRestore.Devices.Add(destination);
                dbRestore.SqlRestore(dbServer);
                serverConnection.Disconnect();

                view.Path = "";
                view.RestoreMessage = "Succeed";
            }
            catch (Exception)
            {
                view.RestoreMessage = "Failed";
            }
        }

        private void BackupData(object sender, EventArgs e)
        {
            try
            {
                var connectionString = SqlHelper.GetConnectionString;
                SqlHelper sqlHelper = new SqlHelper(connectionString);

                ServerConnection serverConnection = sqlHelper.Username != null ? new ServerConnection(sqlHelper.ServerName, sqlHelper.Username, sqlHelper.Password) : new ServerConnection(sqlHelper.ServerName);
                Server dbServer = new Server(serverConnection);
                Backup dbBackup = new Backup
                {
                    Action = BackupActionType.Database,
                    Database = sqlHelper.DatabaseName
                };
                BackupDeviceItem destination = new BackupDeviceItem(view.Path + @"\backup_" + DateTime.Now.ToString("dd.MM.yyyy") + ".bak", DeviceType.File);
                dbBackup.Devices.Add(destination);
                dbBackup.SqlBackup(dbServer);
                serverConnection.Disconnect();

                view.Path = "";
                view.BackupMessage = "Succeed";
            }
            catch (Exception)
            {
                view.BackupMessage = "Failed";
            }
        }
    }
}