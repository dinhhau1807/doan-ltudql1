using DoAnLTUDQL1.ViewModels;
using DoAnLTUDQL1.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class TeacherStudentPresenter
    {
        ITeacherStudentView view;

        public TeacherStudentPresenter(ITeacherStudentView teacherStudetView)
        {
            view = teacherStudetView;
            Initializer();
        }

        private void Initializer()
        {
            // TODO: First load

            // Events
            // -- Register events here
            view.ViewResult += View_ViewResult;
            view.ViewResultE += View_ViewResultE;
            view.ViewResultQ += View_ViewResultQ;
        }

        private void View_ViewResultQ(object sender, EventArgs e)
        {
            using (var qlttn = new QLThiTracNghiemDataContext())
            {
                var lo = new DataLoadOptions();
                lo.LoadWith<Question>(p => p.QuestionId);
                qlttn.LoadOptions = lo;

                int qd = view.QuestionId;
                var getQuestionRP = from q in qlttn.Questions
                                    where q.QuestionId == qd
                                    select new QuestionStatisticViewModel
                                    {
                                        QuestionId = q.QuestionId,
                                        NumOfCorrect = Int32.Parse(q.NumberOfCorrectAnswers.ToString()),
                                        NumOfWrong = Int32.Parse(q.NumberOfWrongAnswers.ToString())
                                    };
                view.QuestionIdRP = qd;
                view.DataSourceQ = getQuestionRP.ToList();
            }
        }

        private void View_ViewResultE(object sender, EventArgs e)
        {
            using (var qlttn = new QLThiTracNghiemDataContext())
            {
                var lo = new DataLoadOptions();
                lo.LoadWith<ExamResult>(p => p.StudentId);
                qlttn.LoadOptions = lo;

                string eD = view.ExamDetailId;
                var getExamRP = from es in qlttn.ExamResults
                          join a in qlttn.Students on es.StudentId equals a.StudentId
                          join u in qlttn.Users on a.Username equals u.Username
                          join dt in qlttn.ExamDetails on es.ExamDetailId equals dt.ExamDetailId
                          join ex in qlttn.Exams on dt.ExamId equals ex.ExamId
                          where es.ExamDetailId ==  eD
                          select new ExamStatisticViewModel
                          {
                              StudentId = es.StudentId,
                              ExamDetailId = es.ExamDetailId,
                              ExamName = ex.ExamName,
                              StudentName = u.LastName,
                              NumOfQuestionRight = Int32.Parse(es.NumberOfCorrectAnswers.ToString()),
                              Mark = Double.Parse(es.Mark.ToString())
                          };
                view.ExamDetailIdRP = eD;
                view.DataSourceE = getExamRP.ToList();

            }
        }

        private void View_ViewResult(object sender, EventArgs e)
        {
            using (var qlttn = new QLThiTracNghiemDataContext())
            {
                var lo = new DataLoadOptions();
                lo.LoadWith<ExamResult>(p => p.ExamDetailId);
                qlttn.LoadOptions = lo;

                string sI = view.StudentId;
                var getStudentRP = from es in qlttn.ExamResults
                          join a in qlttn.Students on es.StudentId equals a.StudentId
                          join u in qlttn.Users on a.Username equals u.Username
                          join dt in qlttn.ExamDetails on es.ExamDetailId equals dt.ExamDetailId
                          join ex in qlttn.Exams on dt.ExamId equals ex.ExamId
                          where es.StudentId == sI
                          select new StudentStatisticViewModel
                          { 
                              StudentId = es.StudentId,
                              ExamDetailId = es.ExamDetailId, 
                              ExamName = ex.ExamName, 
                              StudentName = u.LastName, 
                              Mark = Double.Parse(es.Mark.ToString())
                          };
                view.StudentIdRP = sI;
                view.DataSource = getStudentRP.ToList();

            }
        }
    }
}
