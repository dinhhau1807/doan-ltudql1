using DoAnLTUDQL1.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnLTUDQL1.ViewModels;

namespace DoAnLTUDQL1.Presenters
{
    public class TeacherExamReportPresenter
    {
        ITeacherExamReportView view;

        public TeacherExamReportPresenter(ITeacherExamReportView teacherExamReportView)
        {
            view = teacherExamReportView;
            Initializer();
        }

        private void Initializer()
        {
            view.ViewResult += ViewResult;
        }
        private void ViewResult(object sender, EventArgs e)
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
                                where es.ExamDetailId == eD
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
                view.DataSource = getExamRP.ToList();

            }
        }

    }
}
