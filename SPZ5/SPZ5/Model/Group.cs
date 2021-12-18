using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ5.Model
{
    [Serializable]
    public class Group
    {
        public string GroupNumber { get; set; }
        public int NumberOfStudents { get; set; } = 0;
        public Group(string groupNumber)
        {
            GroupNumber = groupNumber;
        }
        public Group()
        { }
        public void AddStudent()
        {
            NumberOfStudents++;
        }

        public override string ToString()
        {
            return GroupNumber;
        }
    }
}
