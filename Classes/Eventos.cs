using System;

namespace Eventos
{
    class Program

    {
        // static void Main(string[] args)
        // {
        //     var room = new Room(3);
        //     room.RoomSoldOutEvent += onRoomSoldOut;
        //     room.ReserveSeat();
        //     room.ReserveSeat();
        //     room.ReserveSeat();
        //     room.ReserveSeat();
        //     room.ReserveSeat();
        // }

        static void onRoomSoldOut(Object sender, EventArgs e)
        {
            Console.WriteLine("Sala Lotada");
        }
    }
    public class Room
    {
        public Room(int seats)
        {
            Seats = seats;
            seatsInUse = 0;
        }
        int seatsInUse = 0;
        public int Seats { get; set; }


        public void ReserveSeat()
        {
            seatsInUse++;
            if (seatsInUse >= Seats)
            {
                //Evento fechado, disparar o evento programado
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Cadeira reservada!");
            }
        }
        public event EventHandler RoomSoldOutEvent;
        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e);
        }

    }
}