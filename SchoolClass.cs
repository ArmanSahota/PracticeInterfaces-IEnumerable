using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterfaces_IEnumerable
{
    internal class SchoolClass : IEnumerable<Student>
    {
        public string Name { get; }
        private List<Student> roster;

        public SchoolClass(string name)
        {
            Name = name;
            roster = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            roster.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return roster.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
