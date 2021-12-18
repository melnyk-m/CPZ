using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ5.Model
{
    [Serializable]
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Group Group { get; set; }
        
        private static string[] lastNamesArray = new string[] { "Smith", "Johnson", "Williams", "Brown", 
            "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez"};
        private static string[] firstNamesArray = new string[] { "Liam", "Olivia", "Noah", "Emma", "Oliver", "Ava",
            "Elijah", "Charlotte", "William", "Sophia", "James", "Amelia", "Benjamin", "Isabella", "Lucas",
            "Mia", "Henry", "Evelyn"};
        public Student(Random random)
        {
            LastName = lastNamesArray[random.Next(0, lastNamesArray.Length)];
            FirstName = firstNamesArray[random.Next(0, firstNamesArray.Length)];
            int number = random.Next(0, Storage.Groups.Count);
            Group = Storage.Groups[number];
            Group.AddStudent();
        }
        public Student()
        { }
    }
}
