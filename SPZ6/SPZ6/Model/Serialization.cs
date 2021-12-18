using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace SPZ6.Model
{
    class Serialization
    {
        static string path = "Hotel.json";
        static public void Serialize(Hotel hotel)
        {
            var json = new DataContractJsonSerializer(typeof(List<Room>));
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                json.WriteObject(file, hotel.HotelRooms);
            }
        }
    }
}
