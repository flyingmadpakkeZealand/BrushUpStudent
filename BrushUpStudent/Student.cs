using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUpStudent
{
    public class Student : Person
    {
        private int _semester;

        public int Semester
        {
            get { return _semester; }
            set {
                if (value < 1 || value > 8)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _semester = value;
            }
        }

        public Student(string name, string address) : base(name, address)
        {
            Semester = 1;
        }

    }
}
