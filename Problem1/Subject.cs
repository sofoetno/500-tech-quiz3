// c. Საგნის კლასი უნდა შეიცავდეს საგნის დასახელებას, წინაპირობებეს (იმ საგნებს რომელიც არის წინაპირობა ახალი საგნის ასარჩევად),
// კრედიტის რაოდენობას და საგანზე მაქსიმალური სტუდენტების რაოდენობას.
namespace Problem1
{
    public class Subject
    {
        private string _name;
        private Subject[] _preRequisites;
        private int _credits;
        private int _maxStudents;

        public Subject()
        {
            _credits = 3;
            _maxStudents = 35;
        }

        public Subject(string name, int credits, int maxStudents, Subject[] preRequisites)
        {
            _name = name;
            _credits = credits;
            _maxStudents = maxStudents;
            _preRequisites = preRequisites;
        }

        public int Credits
        {
            get { return _credits; }
        }
        
    }
}