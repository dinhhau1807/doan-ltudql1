using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.Exam
{
	public interface IExamView
	{
		dynamic StudentInfo { get; set; }
		ExamDetail ExamDetail { get; set; }
		ExamCode ExamCode { get; set; }

		//show current question
		Question Question { get; set; }
		//show answers of the current question
		List<Answer> AnswerList { get; set; }

		List<Question> QuestionList { get; set; }		

		event Func<bool> createExamAttendance;
		event Func<bool, List<ExamCode>> getExamCodeList;
		event EventHandler setExamCode;
		event EventHandler prevQuestion;
		event EventHandler nextQuestion;
		event EventHandler changeQuestion;
		event EventHandler showKeyQuestion;
		event EventHandler turnInTheExam; //nop bai
	}
}
