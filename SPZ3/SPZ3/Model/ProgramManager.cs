using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ3.Model
{
   public class ProgramManager
    {
        public List<Program> ListOfInstalledPrograms { get; set; }
        public Dictionary<string, User> UserDictionary { get; set; }
        public Specification specification;
        public int NumberOfInstalledPrograms { get; set; }
        public int NumberOfUsers { get; set; }
        public ProgramManager(string OSType, int RAM,
            double CPUFrequency, double HDDSpace)
        {
            ListOfInstalledPrograms = new List<Program>();
            UserDictionary = new Dictionary<string, User>();
            specification = new Specification();
            specification.OSType = OSType;
            specification.RAM = RAM;
            specification.CPUFrequency = CPUFrequency;
            specification.HDDSpace = HDDSpace;
        }

        public bool AvailabilityOfUse(Program program) => program < specification;
        public bool ComparePrograms(int index1, int index2) => ListOfInstalledPrograms[index1] < ListOfInstalledPrograms[index2].specification;

        public bool CompareUsers(string user1, string user2)
        {
            return user1 == user2;
        }
      
        public void ChangeVersion(int index, double version)
        {
            ListOfInstalledPrograms[index].ChangeVersion(version);
        }
        public void ProgramInstallation(params Program[] programs)
        {
            foreach (var program in programs)
            {
                ListOfInstalledPrograms.Add(program);
                NumberOfInstalledPrograms++;
            }
        }
        public bool ProgramDelete(Program program)
        {
            if (ListOfInstalledPrograms.Contains(program))
            {
                ListOfInstalledPrograms.Remove(program);
                return true;
            }
            else return false;
        }
        public void AddUser(params User[] users)
        {
            foreach(var user in users)
            {
                string key = $"{user.UserName}+{user.Password}";
                if (!UserDictionary.ContainsKey(key))
                 {
                   UserDictionary.Add(key, user);
                   NumberOfUsers++;
                 }
            }
            
        }
        public void DeleteUser(string key)
        {
                UserDictionary.Remove(key);
        }
        public void ChangeSpecifications(string OSType, double CPUFrequency, int RAM, double HDDSpace)
        {
            specification.OSType = OSType;
            specification.CPUFrequency = CPUFrequency;
            specification.RAM = RAM;
            specification.HDDSpace = HDDSpace;
        }
    }
}
