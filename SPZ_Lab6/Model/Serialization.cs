using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace SPZ_Lab6.Model
{
    class Serialization
    {
       static string path = "Hotel.json";
       static public void Serialize()
        {
            var json = new DataContractJsonSerializer(typeof(List<HotelRoom>));
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                json.WriteObject(file, Hotel.HotelRooms);
            }
        }
    }
}
