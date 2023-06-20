using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterfaces_IEnumerable
{
    internal class Student
    {
        public string FirstName { get; }

        public Student(string firstName)
        {
            FirstName = firstName;
        }

        public override string ToString()
        {
            return $"Student Name: {FirstName}";
        }
    }
}
