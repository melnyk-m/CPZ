using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SPZ6.Model
{
    [DataContract]
    public class Room
    {
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public int NumberBerths { get; set; }
        [DataMember]
        bool Status { get; set; }
        [DataMember]
        public decimal Price { get; set; }
           
            public Room(int number)
            {
                Number = number;
                Status = false;
                if (number > 0 && number <= 30)
                {
                    NumberBerths = 1;
                    Price = 500;
                }
                else if (number > 30 && number <= 60)
                {
                    NumberBerths = 2;
                    Price = 1000;
                }
                else if (number > 60 && number <= 80)
                {
                    NumberBerths = 3;
                    Price = 1800;
                }
                else if (number > 80 && number <= 100)
                {
                    NumberBerths = 4;
                    Price = 2500;
                }
            }

            public void Settling()
            {
                Status = true;
            }
            public void Eviction()
            {
                Status = false;
            }
            static public void Check(int count, out int min, out int max)
            {
                min = 0;
                max = 0;
                switch (count)
                {
                    case 1:
                        min = 1;
                        max = 30;
                        break;
                    case 2:
                        min = 31;
                        max = 60;
                        break;
                    case 3:
                        min = 61;
                        max = 80;
                        break;
                    case 4:
                        min = 81;
                        max = 100;
                        break;
                    default: break;
                }
            }
      }
}
