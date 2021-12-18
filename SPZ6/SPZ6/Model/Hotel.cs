using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization;

namespace SPZ6.Model
{
    public class Hotel
    {
        public int CountRooms = 100;
        public Dictionary<int, Occupant> HotelDictionary;
        [DataMember]
        public List<Room> HotelRooms;
        public int occupied { get; set; }
        public decimal Income { get; set; } = 0;
        public Hotel()
        {
            HotelDictionary = new Dictionary<int, Occupant>();
            HotelRooms = new List<Room>();
            for (int i = 1; i <= CountRooms; i++)
            {
                HotelDictionary.Add(i, null);
                HotelRooms.Add(new Room(i));
            }
        }
        public void Eviction(int number)
        {
            occupied--;
            HotelRooms[number - 1].Eviction();
            HotelDictionary[number] = null;
        }
        public void Settling()
        {
            Random random = new Random();
            int days = random.Next(1, 14);

            occupied++;
            var firstFree = HotelDictionary.First(item => item.Value == null);
            var room = HotelRooms.Single(item => item.Number == firstFree.Key);
            
            HotelDictionary[firstFree.Key] = new Occupant(days, room.NumberBerths);
            Income += room.Price * days;
            HotelRooms[HotelRooms.IndexOf(room)].Settling();
        }
         public int OccupiedRooms() => HotelDictionary.Where(item => item.Value != null).Count();
       
    }
}
