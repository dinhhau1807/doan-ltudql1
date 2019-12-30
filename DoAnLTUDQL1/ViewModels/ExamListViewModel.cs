using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.ViewModels
{
    public class ExamListViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        string _examId;
        string _examName;
        string _examDetailId;
        DateTime? _startTime;
        int? _duration;
        string _subjectId;
        int _gradeId;
        string _subjectName;

        public string ExamId
        {
            get { return _examId; }
            set
            {
                _examId = value;
                OnPropertyChanged();
            }
        }
        public string ExamName
        {
            get { return _examName; }
            set
            {
                _examName = value;
                OnPropertyChanged();
            }
        }
    
        public string ExamDetailId
        {
            get { return _examDetailId; }
            set
            {
                _examDetailId = value;
                OnPropertyChanged();
            }
        }
        public DateTime? StartTime
        {
            get { return _startTime; }
            set
            {
                _startTime = value;
                OnPropertyChanged();
            }
        }
        public int? Duration
        {
            get { return _duration; }
            set
            {
                _duration = value;
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
    }
}
