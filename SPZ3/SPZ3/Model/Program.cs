using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ3.Model
{
    public struct Specification
    {
        public string OSType { get; set; }
        public double CPUFrequency { get; set; }
        public int RAM { get; set; }
        public double HDDSpace { get; set; }
    }
   public class Program
    {
        public string ProgramName { get; set; }
        public string Manufacturer { get; set; }
        public DateTime InstallationDate { get; set; }
        public double Version { get; set; }
        public Specification specification;

        public Program()
        { }
        public Program(string programName, string OSType, string manufacturer,
            DateTime installationDate, double version, int RAM,
            double CPUFrequency, double HDDSpace)
        {
            ProgramName = programName;
            Manufacturer = manufacturer;
            InstallationDate = installationDate;
            Version = version;
            specification = new Specification();
            specification.OSType = OSType;
            specification.CPUFrequency = CPUFrequency;
            specification.RAM = RAM;
            specification.HDDSpace = HDDSpace;
        }
        public void ChangeVersion(double version)
        {
            Random random = new Random();
            Version += version;
            specification.RAM = random.Next(specification.RAM, specification.RAM + 2);
            specification.CPUFrequency += random.NextDouble();
        }

        public static bool operator >(Program specifications1, Specification specifications2)
        {
            return specifications1.specification.HDDSpace > specifications2.HDDSpace ||
                specifications1.specification.CPUFrequency > specifications2.CPUFrequency ||
                specifications1.specification.OSType != specifications2.OSType ||
                specifications1.specification.RAM > specifications2.RAM;
        }
        public static bool operator <(Program specifications1, Specification specifications2)
        {
            return specifications1.specification.HDDSpace <= specifications2.HDDSpace &&
               specifications1.specification.CPUFrequency <= specifications2.CPUFrequency &&
               specifications1.specification.OSType == specifications2.OSType &&
               specifications1.specification.RAM <= specifications2.RAM;
        }


    }
}
