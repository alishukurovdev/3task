using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabirTeacherTask
{
    internal class Employee : Person
    {
        decimal _salary;
        double _experience;

        public Employee(string name, string surname, int age) : base(name, surname, age)
        {
        }

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 350) _salary = value;
            }
        }
        public double Experience
        {
            get { return _experience; }
            set { if (value >= 0) _experience = value; }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name}");
        }
        public override int Age
        {
            get { return Age; }
            set
            {
                    Age = value;
            }

        }
        
    }
}
