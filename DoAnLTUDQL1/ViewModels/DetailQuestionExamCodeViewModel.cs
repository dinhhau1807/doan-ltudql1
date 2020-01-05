using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.ViewModels
{
    public class DetailQuestionExamCodeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        string _examCodeId;
        int? _numberOfQuestions;
        string _subjectId;
        int _gradeId;
        string _subjectName;
        bool? _isPracticeExam;

        public string ExamCodeId
        {
            get { return _examCodeId; }
            set
            {
                _examCodeId = value;
                OnPropertyChanged();
            }
        }
        public int? NumberOfQuestions
        {
            get { return _numberOfQuestions; }
            set
            {
                _numberOfQuestions = value;
                OnPropertyChanged();
            }
        }
        public string SubjectId
        {
            get { return _subjectId; }
            set
            {
                _subjectId = value;
                OnPropertyChanged();
            }
        }
        public int GradeId
        {
            get { return _gradeId; }
            set
            {
                _gradeId = value;
                OnPropertyChanged();
            }
        }
        public string SubjectName
        {
            get { return _subjectName; }
            set
            {
                _subjectName = value;
                OnPropertyChanged();
            }
        }
        public bool? IsPracticeExam
        {
            get { return _isPracticeExam; }
            set
            {
                _isPracticeExam = value;
                OnPropertyChanged();
            }
        }
    }
}
