using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization;

namespace SPZ_Lab6.Model
{
    
    static class Hotel
    {
        static public int CountRooms = 100;
        static public Dictionary<int, Occupant> HotelDictionary;
        [DataMember]
        static public List<HotelRoom> HotelRooms;
        static public decimal Income { get; set; } = 0;
        static Random rand = new Random();
        static Hotel()
        {
            HotelDictionary = new Dictionary<int, Occupant>();
            HotelRooms = new List<HotelRoom>();
            for (int i = 1; i <= CountRooms; i++)
            {
                HotelDictionary.Add(i, null);
                HotelRooms.Add(new HotelRoom(i));
            }
        }

        static public void Generate()
        {
            int numberOccupiedRooms = rand.Next(30, 60);
            Filling(numberOccupiedRooms);
        }
        static public int OccupiedRooms()=> HotelDictionary.Where(item => item.Value != null).Count();
        static void Filling(int numberOccupiedRooms)
        { 
            for (int i = 1; i <= numberOccupiedRooms; i++)
            {
                int number = rand.Next(1, CountRooms + 1);
                if (HotelDictionary[number] == null)
                {
                    HotelRooms[number - 1].Settling();
                    HotelDictionary[number] = new Occupant();
                    Income += HotelDictionary[number].Days * HotelRooms[number - 1].Price;
                    Form1.Occupied++;

                }
            }
        }
        static public void FillingWithTourists()
        {
            while(Form1.Occupied < 100)
            {
            Filling(CountRooms); 
            }
            
        }

    }
}
