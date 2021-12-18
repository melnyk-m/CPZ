using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SPZ5.Model
{
    class Serialization
    {
        static public void Serialize<T>(string path, List<T> list)
        {
            var serializer = new XmlSerializer(typeof(List<T>));
            using (FileStream file = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(file, list);
            }
        }
        static public List<T> Deserialize<T>(string path, List<T> list)
        {
            var serializer = new XmlSerializer(typeof(List<T>));
            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                return serializer.Deserialize(file) as List<T>;
            }
        }
    }
}
