using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.ViewModels
{
    public class QuestionListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        int _questionId;
        string _content;
        string _subjectId;
        int _gradeId;
        string _subjectName;
        int? _difficultLevel;
        bool? _isDistributed;

        public int QuestionId
        {
            get { return _questionId; }
            set
            {
                _questionId = value;
                OnPropertyChanged();
            }
        }

        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
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

        public int? DifficultLevel
        {
            get { return _difficultLevel; }
            set
            {
                _difficultLevel = value;
                OnPropertyChanged();
            }
        }

        public bool? IsDistributed
        {
            get { return _isDistributed; }
            set
            {
                _isDistributed = value;
                OnPropertyChanged();
            }
        }
    }
}
