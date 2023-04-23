using System.Collections.Generic;

namespace Problem1
{
    public class Semester
    {
        private List<Subject> _subjects;
        private int _no;

        public Semester()
        {
        }

        public Semester(int no)
        {
            _no = no;
        }

        public Semester(int no, List<Subject> subjects)
        {
            _subjects = subjects;
            _no = no;
        }
        
        public Semester(int no, Subject[] subjects)
        {
            _subjects.AddRange(subjects);
            _no = no;
        }
        
        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }

        public int SemesterNumber
        {
            get { return _no; }
        }
        
    }
}