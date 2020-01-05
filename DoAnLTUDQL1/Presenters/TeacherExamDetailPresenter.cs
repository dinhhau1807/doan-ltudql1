using DoAnLTUDQL1.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class TeacherExamDetailPresenter
    {
        ITeacherExamDetailView view;

        public TeacherExamDetailPresenter(ITeacherExamDetailView examDetailView)
        {
            view = examDetailView;
            Initializer();
        }

        private void Initializer()
        {
            // Regiser events
            view.DeleteExamDetail += DeleteExamDetail;
            view.EditExamDetail += EditExamDetail;
            view.AddExamDetail += AddExamDetail;
        }

        private void AddExamDetail(object sender, EventArgs e)
        {
            var examDetail = sender as ExamDetail;
            if (examDetail!=null)
            {
                view.ExamDetails.Add(examDetail);
                view.AddExamDetailMessage = "Succeed";
            }
            else
            {
                view.AddExamDetailMessage = "Failed";
            }
        }

        private void EditExamDetail(object sender, EventArgs e)
        {
            var examDetail = sender as ExamDetail;
            if (examDetail != null)
            {
                bool check = true;
                using (var context = new QLThiTracNghiemDataContext())
                {
                    if (context.ExamTakes.Any(et => et.ExamDetailId == examDetail.ExamDetailId))
                    {
                        check = false;
                    }
                }

                if (check)
                {
                    examDetail.StartTime -= new TimeSpan(0, 0, 0, examDetail.StartTime.Value.Second, examDetail.StartTime.Value.Millisecond);

                    view.ExamDetailEdited.ExamDetailId = examDetail.ExamDetailId;
                    view.ExamDetailEdited.ExamId = examDetail.ExamId;
                    view.ExamDetailEdited.StartTime = examDetail.StartTime;
                    view.ExamDetailEdited.Duration = examDetail.Duration;
                    view.ExamDetailEdited.SubjectId = examDetail.SubjectId;
                    view.ExamDetailEdited.GradeId = examDetail.GradeId;

                    view.EditExamDetailMessage = "Succeed";
                }
                else
                {
                    view.EditExamDetailMessage = "Used";
                }
            }
            else
            {
                view.EditExamDetailMessage = "Failed";
            }
        }

        private void DeleteExamDetail(object sender, EventArgs e)
        {
            var examDetail = sender as ExamDetail;
            if (examDetail != null)
            {
                bool check = true;
                using (var context = new QLThiTracNghiemDataContext())
                {
                    if (context.ExamTakes.Any(et => et.ExamDetailId == examDetail.ExamDetailId))
                    {
                        check = false;
                    }
                }

                if (check)
                {
                    view.ExamDetails.Remove(examDetail);
                    view.DeleteExamDetailMessage = "Succeed";
                }
                else
                {
                    view.DeleteExamDetailMessage = "Used";
                }
            }
            else
            {
                view.DeleteExamDetailMessage = "Failed";
            }
        }
    }
}
