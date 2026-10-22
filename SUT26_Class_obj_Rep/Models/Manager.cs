using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal class Manager : EmployeeAbst
    {


        public string Department { get; set; }


        public override void Work()
        {
            Console.WriteLine($"{Name} is managing the {Department} department");
        }




        public void CondactMeeting()
        {
            Console.WriteLine($"{Name} is condacting a meetin .......");
        }
    }
}
