using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal class PartTimeEmpolyee : Employee 
    {
       

        public decimal HourlySalary { get; set; }


        //public PartTimeEmpolyee()
        //{
        //    Console.WriteLine("Hello from Child Class ........");
        //}



        public override void PrintFullName()
        {
            Console.WriteLine("Hello : " + FirstName + " " + LastName + " With ID : " + ID);
        }
    }
}
