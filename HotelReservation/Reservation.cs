using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class Reservation 
    {
        public Reservation(Customer customer, Room room, DateTime entranceDate, DateTime relaseDate)
        {
            Customer = customer;
            Room = room;
            Number = Guid.NewGuid().ToString();
            EntranceDate = entranceDate;
            RelaseDate = relaseDate;
        }

        public Customer Customer { get; set; }
        public Room Room { get; set; }
        public string Number { get; private set; }
        public DateTime EntranceDate { get; set; }
        public DateTime RelaseDate { get; set; }
    }
}
