using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class TeacherPresenter
    {
        User CurrentUser;


        public TeacherPresenter(User currentUser)
        {
            this.CurrentUser = currentUser;
        }

        public List<usp_LoadListExamCodeResult> LoadListExamCode(int ExamType = -1)
        {
            using (QLThiTracNghiemDataContext context = new QLThiTracNghiemDataContext())
            {
                return context.usp_LoadListExamCode(ExamType).ToList();
            }
        }

        public List<ExamCode_Question> LoadQuestionByExamCode(string ExamCodeID)
        {
            using (QLThiTracNghiemDataContext context = new QLThiTracNghiemDataContext())
            {
                context.DeferredLoadingEnabled = false;
                return context.ExamCode_Questions.Where(i => i.ExamCodeId.Contains(ExamCodeID)).ToList();
            }
        }
        public List<Question> GetListQuestion(string SubjectID, int GradeID)
        {
            using (QLThiTracNghiemDataContext context = new QLThiTracNghiemDataContext())
            {
                context.DeferredLoadingEnabled = false;
                var result = context.Questions.Where(i => i.SubjectId == SubjectID && i.GradeId.Value == GradeID);
                
                return result.ToList();
            }
        }
        public List<ExamCode_Question> GetListExamQuestionByExamCode(string ExamCodeID)
        {
            using (QLThiTracNghiemDataContext context = new QLThiTracNghiemDataContext())
            {
                context.DeferredLoadingEnabled = false;
                var result = context.ExamCode_Questions.Where(i => i.ExamCodeId == ExamCodeID);

                return result.ToList();
            }
        }

        public bool InsertExamQuestion(List<int> listQuestionID, string ExamCodeID)
        {
            try
            {
                using (QLThiTracNghiemDataContext context = new QLThiTracNghiemDataContext())
                {
                    List<ExamCode_Question> list = new List<ExamCode_Question>();
                    //Clear old mapping
                    List<ExamCode_Question> listDel = context.ExamCode_Questions.Where(i => i.ExamCodeId == ExamCodeID).ToList();
                   
                    context.DeferredLoadingEnabled = false;
                    foreach(int item in listQuestionID)
                    {
                        ExamCode_Question eq = new ExamCode_Question();
                        eq.ExamCodeId = ExamCodeID;
                        eq.QuestionId = item;
                        list.Add(eq);
                    }
                    if (listDel.Count > 0) context.ExamCode_Questions.DeleteAllOnSubmit(listDel);
                    context.ExamCode_Questions.InsertAllOnSubmit(list);
                    context.SubmitChanges();
                    return true;

                }
                
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

    }
}
