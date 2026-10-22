using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal class Developer : EmployeeAbst
    {

        public string ProgramingLanguge { get; set; }



        public override void Work()
        {
            Console.WriteLine($"{Name}  is workin with code in {ProgramingLanguge}");
        }




        public void DebugingCode()
        {
            Console.WriteLine($"{Name} is debuging Code ........");
        }
    }
}
