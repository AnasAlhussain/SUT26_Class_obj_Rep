using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal class House
    {
        private readonly List<Room> _rooms = new List<Room>();
        public string Address { get; set; }


        public House(string address)
        {
            Address = address;

            _rooms.Add(new Room("Kitchen", 15));
            _rooms.Add(new Room("Living room", 30));
            _rooms.Add(new Room("Bedroom", 25));
        }


        public void AddRoom(string name,double squaremeter)
        {
            _rooms.Add(new Room(name, squaremeter));
        }

        public void ShowRoomInfo()
        {
            Console.WriteLine($"Rooms in the house att {Address}");

            foreach (Room room in _rooms) 
            {
                Console.WriteLine($"  - {room.Name}  ({room.SquareMeter})");
            
            
            }
        }
    }
}
