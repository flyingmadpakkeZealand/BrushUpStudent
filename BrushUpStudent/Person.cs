using System;

namespace BrushUpStudent
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Person
    {
        private string _name;
        private string _address;
        private Gender _gender;

        public string Name
        {
            get { return _name; }
            set {
                if (value == null || value.Length < 2)
                {
                    throw new ArgumentException("Name cannot be null and must be at least two characters");
                }

                _name = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                _address = value;
            }
        }

        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
