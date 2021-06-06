using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingGenerics
{
    public class Student: IComparable<Student>
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public int CompareTo(Student other)
        {
            if (other is null) return 1;

            if (other.LastName == this.LastName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            return this.LastName.CompareTo(other.LastName);
        }
    }
}
