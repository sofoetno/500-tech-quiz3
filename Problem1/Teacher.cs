// b. Მასწავლებლის კლასი უნდა შეიცავდეს მასწავლების სახელს და გვარს და იმ საგნების სიას რომელსაც ასწავლის.
// Ერთ მასწავლებელს არ უნდა შეეძლოს 3 ზე მეტი საგნის სწავლება. Კლასს განუსაზღვრეთ საგნის დამატების და შეცვლის მეთოდები.

using System;
using System.Data.SqlClient;
using System.Linq;

namespace Problem1
{
    public class Teacher
    {
        private string _firstName;
        private string _lastName;
        private Subject[] _subjects = new Subject[3];
        private int _subjectIndex = 0;

        public Teacher()
        {
        }

        public Teacher(string firstName, string lastName, Subject[] subjects)
        {
            _firstName = firstName;
            _lastName = lastName;
            _subjects = subjects;
        }

        public void AddSubject(Subject subject)
        {
            if (_subjectIndex == _subjects.Length)
            {
                throw new IndexOutOfRangeException("You can't add more than three subjects.");
            }
            
            int theSameSubjectIndex = FindSubjectIndex(subject);
            if (theSameSubjectIndex != -1)
            {
                throw new ArgumentException("There is the same subject already.");
            }
            
            _subjects[_subjectIndex] = subject;
            _subjectIndex++;
        }

        public void ChangeSubject(Subject oldSubject, Subject newSubject)
        {
            int oldSubjectIndex = FindSubjectIndex(oldSubject);
            if (oldSubjectIndex == -1)
            {
                throw new ArgumentException("There is no such a subject.");
            }
            
            int theSameSubjectIndex = FindSubjectIndex(newSubject);
            if (theSameSubjectIndex != -1)
            {
                throw new ArgumentException("There is the same subject already.");
            }
            
            _subjects[oldSubjectIndex] = newSubject;
        }

        private int FindSubjectIndex(Subject subject)
        {
            for (int i = 0; i < _subjects.Length; ++i)
            {
                if (_subjects[i] == subject)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}