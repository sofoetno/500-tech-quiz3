using System;
using System.Collections.Generic;

namespace Problem1
{
    public class Semester
    {
        private List<Subject> _subjects;
        private int _no;
        private int _maxCredits;

        public Semester()
        {
        }

        public Semester(int no, int maxCredits)
        {
            _no = no;
            _maxCredits = maxCredits;
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
            if (CalculateTotalCredits() + subject.Credits > _maxCredits)
            {
                throw new ArgumentException("Total credits exceeds 35.");
            }
            
            _subjects.Add(subject);
        }

        public int SemesterNumber
        {
            get { return _no; }
        }
        
        private int CalculateTotalCredits()
        {
            int sumCredits = 0;
            
            foreach (Subject subject in _subjects)
            {
                sumCredits = subject.Credits + sumCredits;
            }

            return sumCredits;
        }
        
    }
}