using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class Room 
    {
        public Room(int number, decimal price, RoomType type)
        {
            Number = number;
            Price = price;
            Type = type;
           
        }

        public int Number { get; set; }
        public decimal Price { get; set; }
        public RoomType Type { get; set; }
       
               
    }
    public enum RoomType
    {
        Single,
        Multiple,

    }
}
