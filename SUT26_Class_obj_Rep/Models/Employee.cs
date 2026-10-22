using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal class Employee
    {


        private int _Id;
        //public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        private int _passMark;
       


        public int PassMark
        {
            set
            {
                if(value  < 0)
                {
                    throw new Exception("The Pass Mark cannot be less than 0 ");
                }
            }
            get
            {
                return _passMark;
            }
        }

        public int ID
        {
            set
            {
                if(value <= 0)
                {
                    throw new Exception("The Id cannot be less than 1 ");
                }
            }
            get
            {
                return _Id;
            }
        }

        public virtual void PrintFullName()
        {
            Console.WriteLine("Hello : " + FirstName + " " + LastName + " With ID : " + ID);
        }
    }
}
