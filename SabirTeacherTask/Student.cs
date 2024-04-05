using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabirTeacherTask
{
    internal class Student:Person
    {
        string _uniName;
        int _course;
        bool _isGraduated;

        public Student(string name, string surname, int age) : base(name, surname, age)
        {
        }

        public string UniName
        {
            get { return _uniName; }
            set { _uniName = value; }
        }
        public int Course
        {
            get { return _course; }
            set
            {
                if(value>0 && value < 5)
                {
                    _course = value;
                    if (_course == 4)
                    {
                        _isGraduated = true;
                    }
                } 
            }
        }
        public bool IsGraduated
        {
            get=> _isGraduated; 
        }
         public override void GetInfo()
        {
            Console.WriteLine($"{Name} {UniName}");
        }
    }
}
