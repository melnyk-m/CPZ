using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ5.Model
{
    static class Storage
    {
        public static  List<Student> Students { get; set; }
        public static List<Group> Groups { get; set; }
        static Storage()
        {
            Students = new List<Student>();
            Groups = new List<Group>();
            for (int i = 1; i < 5; i++)
                Groups.Add(new Group("KIUKI" + '-' + 19 + '-' + i));
        }
        static public void Generate()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Students.Add(new Student(random));
            }
        }
 
        public static void Add(string groupName)
        {
            if (Groups.Where(group => group.GroupNumber == groupName).Count() == 0)
                Groups.Add(new Group(groupName));
        }
        static public List<Student> SortByName(List<Student> students)
        {
            return students.OrderBy(student => student.FirstName).ToList();
        }
        static public List<Group> SortByNumberOfStudents()
        {
            return Groups.OrderByDescending(item => item.NumberOfStudents).ToList();
        }
       static public List<Student> OutputList(string groupName)
        {
            return Students.Where(student => student.Group.GroupNumber == groupName).ToList();
        }
        static public void RemoveGroup(string groupName)
        {
            Groups.Remove(Groups.Single(group => group.GroupNumber == groupName));
            Students.RemoveAll(student => student.Group.GroupNumber == groupName);
        }
        static public void RenameGroup(string groupName, string newGroupName)
        {
            if (!Groups.Any(group => group.GroupNumber == newGroupName))
            { 
                int i = Groups.IndexOf(Groups.Single(group => group.GroupNumber == groupName));
                Groups[i].GroupNumber = newGroupName;
            }
        }

    }
}
