using DoAnLTUDQL1.ViewModels;
using DoAnLTUDQL1.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace DoAnLTUDQL1.Presenters
{
    public class TeacherQuestionPresenter
    {
        ITeacherQuestionView view;

        public TeacherQuestionPresenter(ITeacherQuestionView questionView)
        {
            view = questionView;
            Initializer();
        }

        private void Initializer()
        {
            // Get question list
            ReloadListQuestion(view, null);

            // Get list subjects
            GetListSubject();

            // Register events
            // --- List question
            view.ReloadListQuestion += ReloadListQuestion;
            // --- Edit question
            view.SaveEditQuestion += SaveEditQuestion;
            // --- Detail question
            view.LoadDetailQuestionExamCode += LoadDetailQuestionExamCode;
            // --- Approve question
            view.LoadApproveQuestion += LoadApproveQuestion;
            view.ApproveQuestion += ApproveQuestion;
            // --- Add question
            view.AddQuestion += AddQuestion;
            // --- Import/Export question
            view.ImportQuestion += ImportQuestion;
            view.ExportQuestion += ExportQuestion;
        }

        private void ImportQuestion(object sender, EventArgs e)
        {
            var path = (string)sender;
            if (File.Exists(path))
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    IList<Question> questionsImport = new List<Question>();

                    //Create COM Objects. Create a COM object for everything that is referenced
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbooks xlWorkbooks = xlApp.Workbooks;
                    Excel.Workbook xlWorkbook = xlWorkbooks.Open(path);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;

                    string message = "Succeed";
                    try
                    {
                        int rowCount = xlRange.Rows.Count;
                        int colCount = xlRange.Columns.Count;

                        //iterate over the rows and columns and print to the console as it appears in the file
                        //excel is not zero based!!
                        for (int i = 2; i <= rowCount; i++)
                        {
                            string questionContent = xlRange.Cells[i, 1].Value2.ToString();

                            if (context.Questions.Any(q => q.Content == questionContent))
                            {
                                continue;
                            }

                            var subjectId = xlRange.Cells[i, 2].Value2.ToString();
                            var gradeId = (int)xlRange.Cells[i, 3].Value2;
                            if (!view.Subjects.Any(s => s.SubjectId == subjectId && s.GradeId == gradeId))
                            {
                                continue;
                            }

                            var question = new Question
                            {
                                // Id Identity
                                Content = xlRange.Cells[i, 1].Value2.ToString(),
                                SubjectId = subjectId,
                                GradeId = gradeId,
                                DifficultLevel = (int)xlRange.Cells[i, 4].Value2,
                                IsDistributed = false,
                            };

                            context.Questions.InsertOnSubmit(question);
                            context.SubmitChanges();

                            IList<Answer> answers = new List<Answer>();
                            var currentAnswerId = context.Answers.Select(a => a.AnswerId).Max();
                            var nextAnswerId = currentAnswerId + 1;
                            for (int j = 0; j < (colCount - 4) / 2; j++)
                            {
                                var col = 5 + j * 2;

                                if (xlRange.Cells[i, col].Value2 == null)
                                {
                                    break;
                                }

                                var answer = new Answer
                                {
                                    AnswerId = nextAnswerId++,
                                    QuestionId = question.QuestionId,
                                    Content = xlRange.Cells[i, col++].Value2.ToString(),
                                    IsCorrect = (bool)xlRange.Cells[i, col++].Value2
                                };

                                answers.Add(answer);
                            }

                            context.Answers.InsertAllOnSubmit(answers);
                            context.SubmitChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.ToString());
                        message = "Failed";
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

                        view.ImportQuestionMessage = message;
                    }
                }
            }
            else
            {
                view.ImportQuestionMessage = "File not exists";
            }
        }

        private void ExportQuestion(object sender, EventArgs e)
        {
            var path = (string)sender;
            try
            {
                IList<Question> exportQuestions = new List<Question>();
                IList<Answer> exportAnswers = new List<Answer>();

                using (var context = new QLThiTracNghiemDataContext())
                {
                    exportQuestions = context.Questions.ToList();
                    exportAnswers = context.Answers.ToList();
                }

                //Create COM Objects. Create a COM object for everything that is referenced
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbooks xlWorkbooks = xlApp.Workbooks;
                Excel.Workbook xlWorkbook = xlWorkbooks.Add("");
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                string message = "Succeed";
                try
                {
                    // Write header
                    xlRange.Cells[1, 1].Value2 = "Mã câu hỏi";
                    xlRange.Cells[1, 2].Value2 = "Nội dung";
                    xlRange.Cells[1, 3].Value2 = "Mã môn học";
                    xlRange.Cells[1, 4].Value2 = "Khối lớp";
                    xlRange.Cells[1, 5].Value2 = "Độ khó";
                    xlRange.Cells[1, 6].Value2 = "Câu hỏi được đóng góp";
                    xlRange.Cells[1, 7].Value2 = "Câu trả lời";

                    int rowCount = exportQuestions.Count + 1;

                    //iterate over the rows and columns
                    //excel is not zero based!!
                    for (int i = 2; i <= rowCount; i++)
                    {
                        xlRange.Cells[i, 1].Value2 = exportQuestions[i - 2].QuestionId;
                        xlRange.Cells[i, 2].Value2 = exportQuestions[i - 2].Content;
                        xlRange.Cells[i, 3].Value2 = exportQuestions[i - 2].SubjectId;
                        xlRange.Cells[i, 4].Value2 = exportQuestions[i - 2].GradeId;
                        xlRange.Cells[i, 5].Value2 = exportQuestions[i - 2].DifficultLevel;
                        xlRange.Cells[i, 6].Value2 = exportQuestions[i - 2].IsDistributed;

                        // Write answer
                        var answers = exportAnswers.Where(a => a.QuestionId == exportQuestions[i - 2].QuestionId);
                        int j = 7;
                        foreach (var answer in answers)
                        {
                            xlRange.Cells[i, j++].Value2 = answer.AnswerId;
                            xlRange.Cells[i, j++].Value2 = answer.Content;
                            xlRange.Cells[i, j++].Value2 = answer.IsCorrect;
                        }
                    }

                    xlWorkbook.SaveAs(path + (path.EndsWith(@"\") ? "" : @"\") + "export_question_" + DateTime.Now.ToString("dd.MM.yyyy") + ".xlsx",
                                      Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false,
                                      Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    message = "Failed";
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

                    view.ExportQuestionMessage = message;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.ExportQuestionMessage = "Failed";
            }
        }

        private void AddQuestion(object sender, EventArgs e)
        {
            try
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    // Id Indentity
                    context.Questions.InsertOnSubmit(view.Question);
                    context.SubmitChanges();
                }

                view.AddQuestionMessage = "Succeed";
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                view.AddQuestionMessage = "Failed";
            }
        }

        private void GetListSubject()
        {
            try
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    context.DeferredLoadingEnabled = false;
                    view.Subjects = (from s in context.Subjects
                                     join t in context.Teaches on new { s.SubjectId, s.GradeId } equals new { t.SubjectId, t.GradeId }
                                     where t.TeacherId == view.CurrentUser.TeacherId
                                     select s).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }

        private void LoadApproveQuestion(object sender, EventArgs e)
        {
            try
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    context.DeferredLoadingEnabled = false;
                    view.ListQuestionDistributed = (from qd in context.QuestionDistributes
                                                    join s in context.Subjects on new { qd.SubjectId, qd.GradeId } equals new { s.SubjectId, s.GradeId }
                                                    join t in context.Teaches on new { s.SubjectId, s.GradeId } equals new { t.SubjectId, t.GradeId }
                                                    where t.TeacherId == view.CurrentUser.TeacherId && qd.IsApproved == false
                                                    select qd).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }

        private void ApproveQuestion(object sender, EventArgs e)
        {
            try
            {
                Question question;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var questionDistributed = context.QuestionDistributes.First(q => q.QuestionDistributeId == view.ApproveQuestionId);
                    questionDistributed.IsApproved = true;

                    question = new Question
                    {
                        Content = questionDistributed.Content,
                        Hint = questionDistributed.Hint,
                        SubjectId = questionDistributed.SubjectId,
                        GradeId = questionDistributed.GradeId,
                        DifficultLevel = questionDistributed.DifficultLevel,
                        IsDistributed = true
                    };

                    context.Questions.InsertOnSubmit(question);
                    context.SubmitChanges();
                }

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var answerDistributed = context.AnswerDistributes.Where(a => a.QuestionDistributeId == view.ApproveQuestionId).ToList();

                    List<Answer> answers = new List<Answer>();
                    foreach (var a in answerDistributed)
                    {
                        var answer = new Answer
                        {
                            AnswerId = a.AnswerDistributeId,
                            QuestionId = question.QuestionId,
                            Content = a.Content,
                            IsCorrect = a.IsCorrect
                        };
                        answers.Add(answer);
                    }

                    context.Answers.InsertAllOnSubmit(answers);
                    context.SubmitChanges();
                }

                view.ApproveQuestionMessage = "Succeed";
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                view.ApproveQuestionMessage = "Failed";
            }
        }

        private void LoadDetailQuestionExamCode(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                view.ListDetailQuestionExamCode = (from ec in context.ExamCodes
                                                   join exq in context.ExamCode_Questions on ec.ExamCodeId equals exq.ExamCodeId
                                                   join q in context.Questions on exq.QuestionId equals q.QuestionId
                                                   join s in context.Subjects on new { ec.SubjectId, ec.GradeId } equals new { s.SubjectId, s.GradeId }
                                                   where q.QuestionId == view.EditQuestionId
                                                   select new DetailQuestionExamCodeViewModel
                                                   {
                                                       ExamCodeId = ec.ExamCodeId,
                                                       NumberOfQuestions = ec.NumberOfQuestions,
                                                       SubjectId = ec.SubjectId,
                                                       GradeId = ec.GradeId,
                                                       SubjectName = s.SubjectName,
                                                       IsPracticeExam = ec.IsPracticeExam
                                                   }).ToList();
            }
        }

        private void SaveEditQuestion(object sender, EventArgs e)
        {
            try
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    var question = view.ListQuestion.First(q => q.QuestionId == view.EditQuestionId);
                    var questionDb = context.Questions.First(q => q.QuestionId == view.EditQuestionId);
                    questionDb.Content = question.Content;
                    questionDb.DifficultLevel = question.DifficultLevel;

                    context.SubmitChanges();
                    view.EditQuestionMessage = "Succeed";
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                view.EditQuestionMessage = "Failed";
            }

        }

        private void ReloadListQuestion(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                view.ListQuestion = (from q in context.Questions
                                     join s in context.Subjects on new { q.SubjectId, q.GradeId } equals new { s.SubjectId, s.GradeId }
                                     join t in context.Teaches on new { s.SubjectId, s.GradeId } equals new { t.SubjectId, t.GradeId }
                                     where t.TeacherId == view.CurrentUser.TeacherId
                                     select new QuestionListViewModel
                                     {
                                         QuestionId = q.QuestionId,
                                         Content = q.Content,
                                         SubjectId = q.SubjectId,
                                         GradeId = q.GradeId,
                                         SubjectName = s.SubjectName,
                                         DifficultLevel = q.DifficultLevel,
                                         IsDistributed = q.IsDistributed
                                     }).ToList();
            }
        }
    }
}
