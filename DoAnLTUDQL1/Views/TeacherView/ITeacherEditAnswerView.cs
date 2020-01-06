using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface ITeacherEditAnswerView
    {
        int QuestionId { get; set; }
        IList<Answer> Answers { get; set; }

        Answer Answer { get; set; }

        string EditAnswerMessage { set; }

        int DeleteAnswerId { get; set; }
        string DeleteAnswerMessage { set; }

        string AddAnswerMessage { set; }

        event EventHandler ReloadListAnswer;
        event EventHandler SaveEditAnswer;
        event EventHandler DeleteAnswer;
        event EventHandler AddAnswer;
    }
}
