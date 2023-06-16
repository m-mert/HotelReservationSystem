namespace HotelReservation
{
    public class Hotel
    {
        public Hotel(string name, string adress)
        {
            Name = name;
            Adress = adress;
            Rooms = new();
        }

        public string Name { get; set; }
        public string Adress { get; set; }
        public Dictionary<int, Room> Rooms { get; set; }
        public List<Reservation> Reservations { get; set; }

        public void AddRoom(Room room)
        {
            Rooms.Add(room.Number, room);

        }

        public void AddReservation(Reservation reservation)
        {
            bool roomControl = RoomReservartionControl(reservation.EntranceDate, reservation.RelaseDate, reservation.Room.Number);
            if (roomControl)
            {
                Reservations.Add(reservation);
            }
        }
        public void VacateRoom(string reservationNumber)
        {
            Reservation reservation = Reservations.FirstOrDefault(x=>x.Number == reservationNumber);
            if (reservation != null)
            {
                Reservations.Remove(reservation);
            }
        }
        public List<Room> GetAvaibleRooms(DateTime entranceDate, DateTime relaseDate, RoomType roomType)
        {
            List<Room> rooms = new();
            foreach (KeyValuePair<int, Room> room in Rooms)
            {
                if (room.Value.Type == roomType)
                {
                    bool roomControl = RoomReservartionControl(entranceDate, relaseDate, room.Value.Number);
                    if (roomControl)
                    {
                        rooms.Add(room.Value);
                    }
                }
            }
            return rooms;
        }
        public bool RoomReservartionControl(DateTime entranceDate, DateTime releaseDate, int roomNumber)
        {
            foreach (Reservation reservartion in Reservations)
            {
                if ((reservartion.EntranceDate < entranceDate && reservartion.RelaseDate < releaseDate) || (reservartion.RelaseDate > releaseDate && reservartion.EntranceDate < releaseDate && reservartion.Room.Number == roomNumber))
                {
                    return false;
                }
            }
            return true;
        }


    }
}