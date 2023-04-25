// a. Სტუდენტის კლასში უნდა არსეობდეს ინფორმაცია სტუდენტის სახელი გვარი პირადი ნომერი (პირადი ნომერი არ უნდა აღემატებოდეს 11 ციფრს),
// საგნების ჩამონათვალს და სემესტრების შესახებ ინფორმაციას.(ეს ცალკე კლასად შეგიძლიათ აღწეროთ).
// Შექმენით property რომელიც გამოტანს სახელს და გვარს ერთად. Სტუდენტს არ უნდა შეეძოს 35 GPA ზე მეტის აღება.
// Შექმენით მეთოდები რომელიც გამოიტანს სემესტრის ან სემესტრების საგნების ჩამონათვალს და ლექტორების შესახებ ინფორმაციას.
// Სტუდენტ კლასს ასევე უნდა ჰქონდეს მეთოდები რომელიც დაამატებს სემესტრს და ამ სემესტრის საგნებს. Ან კონკრეტულ სემესტრში დაამატებს საგანს.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem1
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        private string _personalNumber;
        private List<Semester> _semesters;

        public Student()
        {
        }

        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string PersonalNumber
        {
            get { return _personalNumber; }
            set
            {
                Regex regex = new Regex(@"^[0-9]{11}$");
                if (!regex.IsMatch(value))
                {
                    throw new ArgumentException("Invalid personal number.");
                }
                _personalNumber = value;
            }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public void AddSemesterAndSubjects(int semesterNumber, Subject[] subjects)
        {
            Semester semester = new Semester(semesterNumber, subjects);
            _semesters.Add(semester);
        }

        public void AddSubjectToSemester(Subject subject, int semesterNumber)
        {
            Semester semester = _semesters.Find(x => x.SemesterNumber == semesterNumber);
            if (semester == null)
            {
                throw new ArgumentException("There is no such a semester.");
            }
            semester.AddSubject(subject);
        }

        public void DisplayInformationOfSubjects(int[] semesterNumbers)
        {
            
        }
    }
}