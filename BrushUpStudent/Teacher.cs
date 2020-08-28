using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUpStudent
{
    public class Teacher : Person
    {
        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _salary = value;
            }
        }

        public Teacher(string name, string address) : base(name, address)
        {

        }

    }
}
