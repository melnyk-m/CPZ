using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ3.Model
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Program> AvailablePrograms { get; set; }

        public User()
        {
            AvailablePrograms = new List<Program>();
        }
        public bool Authentication(string password) => Password == password;
        public static bool operator ==(User user1, User user2) => user1.AvailablePrograms.Count().Equals(user2.AvailablePrograms.Count());
        public static bool operator !=(User user1, User user2) => !user1.AvailablePrograms.Count().Equals(user2.AvailablePrograms.Count());
        public bool AddToAvailablePrograms(Program program)
        {
            if (!AvailablePrograms.Contains(program))
            {
                AvailablePrograms.Add(program);
                return true;
            }
            else return false;
        }
         public bool DeleteProgram(Program program)
        {
            if (AvailablePrograms.Contains(program))
            {
                AvailablePrograms.Remove(program);
                return true;
            }
            else return false;
        }
    }
}
