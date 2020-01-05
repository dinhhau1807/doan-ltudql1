using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.ViewModels
{
    public class QuestionStatisticViewModel
    {
        public int QuestionId { get; set; }
        public int NumOfCorrect { get; set; }
        public int NumOfWrong { get; set; }
        
    }
}
