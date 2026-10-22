using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal class FullTimeEmpolyee : Employee
    {
        

        public double YearlySalary { get; set; }

        //public FullTimeEmpolyee()
        //{

        //}

        //public FullTimeEmpolyee(string firstName,string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //}


        //public void PRintFullName()
        //{
        //    Console.WriteLine("Hello : " + FirstName + " " + LastName);
        //}

        public override void PrintFullName()
        {
            Console.WriteLine("Hello : " + FirstName );
        }
    }
}
