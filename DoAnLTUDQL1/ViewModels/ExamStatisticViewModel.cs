using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.ViewModels
{
    public class ExamStatisticViewModel
    {
        public string ExamDetailId { get; set; }
        public string ExamName { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public int NumOfQuestionRight { get; set; }
        public double Mark { get; set; }
    }
}
