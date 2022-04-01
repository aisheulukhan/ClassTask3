using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask3.Models
{
    class Group
    {
        private string _groupno;
        private int _studentlimit;
        public string GroupNo
        {
            get
            {
                return _groupno;
            }
            set
            {
                if (!String.IsNullOrEmpty(_groupno) && !String.IsNullOrWhiteSpace(_groupno))
                {
                    _groupno = value;
                }
            }
        }
        public int StudentLimit
        {
            get
            {
                return _studentlimit;
            }
            set
            {
                if (value >= 5 || value <= 18)
                {
                    _studentlimit = value;
                }
            }
        }
        //public bool CheckStudentLimit(int studentLimit)
        //{
        //    if (studentLimit >= 5 && studentLimit <= 18)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        private  Student[] _students = new Student[0];
        public Student this[int index]
        {
            get { return _students[index]; }
            set { _students[index] = value; }
        }
        //public static void AddStudent(Student student)
        //{
        //    Array.Resize(ref _students, _students.Length + 1);
        //    _students[_students.Length - 1] = student;
        //}
        public void AddStudent(Student student)
        {
            if (_students.Length < StudentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("limit kecildi");
            }
        }
        public  bool CheckGroupNo(string groupNo)
        {
            bool isupper1 = false;
            bool isupper2 = false;
            bool isdigit3 = false;
            bool isdigit4 = false;
            bool isdigit5 = false;
            if (!String.IsNullOrEmpty(groupNo) && !String.IsNullOrWhiteSpace(groupNo) && groupNo.Length >= 5)
            {

                if (char.IsUpper(groupNo[0])) isupper1 = true;
                if (char.IsUpper(groupNo[1])) isupper2 = true;
                if (char.IsDigit(groupNo[2])) isdigit3 = true;
                if (char.IsDigit(groupNo[3])) isdigit4 = true;
                if (char.IsDigit(groupNo[4])) isdigit5 = true;

                if (isupper1 && isupper2 && isdigit3 && isdigit4 && isdigit5) return true;
            }
            return false;

        }
        public void GetStudent(int? StudId)
        {
            if (StudId != null)
            {
                foreach (Student student in _students)
                {
                    if (student.Id == StudId)
                    {
                        Console.WriteLine(student);
                    }
                }
            }
        }
        public void GetAllStudents()
        {
            foreach (var item in _students)
            {
                Console.WriteLine(item);
            }
        }
        public Group(string groupno, int studentlimit)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }
    }
}
