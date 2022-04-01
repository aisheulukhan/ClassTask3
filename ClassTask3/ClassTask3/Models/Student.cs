using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask3.Models
{
    class Student
    {
        private static int _id;
        private string _fullName;
        private double _point;
        public string FullName { get; set; }
        public int Point { get; set; }
        public int Id
        {
            get;
        }
        static Student()
        {
            _id = 0;
        }
        public Student(string fullname, double point)
        {
            _id++;
            Id = _id;
        }
        
        public Student(string fullname, int point) :this()
        {
            FullName = fullname;
            Point = point;
        }

        public Student()
        {
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id} FullName: {FullName}  Point: {Point}");
        }
    }
}
