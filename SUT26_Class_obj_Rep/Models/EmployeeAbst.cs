using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal abstract class EmployeeAbst
    {
        public int ID { get; set; }
        public string  Name { get; set; }



        public abstract void Work();



        public void DisplayData()
        {
            Console.WriteLine("Emplyee Name : " + Name);
            Console.WriteLine("Empolyee ID : " + ID);

        }
        
    }
}
