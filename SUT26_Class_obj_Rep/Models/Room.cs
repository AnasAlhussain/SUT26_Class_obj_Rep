using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal class Room
    {

        public string Name { get; set; }
        public double SquareMeter { get; set; }


        public Room(string name,double squaremeter)
        {
            Name = name;
            SquareMeter = squaremeter;
        }
    }
}
