using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ6.Model
{
    public class Occupant
    {
        public int Days { get; set; }
        public int NumberOfSeats { get; set; }

        static Random random = new Random();
        public Occupant()
        {
            Days = random.Next(1, 14);
            NumberOfSeats = random.Next(1, 5);
        }
        public Occupant(int days, int numberOfSeats)
        {
            Days = days;
            NumberOfSeats = numberOfSeats;
        }
    }
}
