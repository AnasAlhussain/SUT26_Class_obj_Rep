using SUT26_Class_obj_Rep.Models;

namespace SUT26_Class_obj_Rep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FullTimeEmpolyee Pär = new FullTimeEmpolyee();
            //Pär.FirstName = "Pär";
            //Pär.LastName = "Wikk";

            //FullTimeEmpolyee Reidar = new FullTimeEmpolyee();
            //Reidar.FirstName = "Reidar";
            //Reidar.LastName = "Nilsen";
            //Reidar.YearlySalary = 999.99;

            ////FullTimeEmpolyee Erik = new FullTimeEmpolyee("Erik","Eriksson");

            //PartTimeEmpolyee Anas = new PartTimeEmpolyee();

            //Anas.FirstName = "Anas";
            //Anas.LastName = "Alhussain";



            //Pär.PrintFullName();
            //Reidar.PrintFullName();
            ////Erik.PRintFullName();

            //Anas.PrintFullName();

            //Employee Em = new Employee();
            ////Em.ID = -10;

            //Em.PassMark = -20;

            ////Console.WriteLine("Employee ID = {0}",Em.ID);
            //Console.WriteLine("Employee PassMark = {0}",Em.PassMark);








            //Manager Pär = new Manager()
            //{
            //    ID = 1,
            //    Name = "Pär",
            //    Department = "HR"
            //};


            //Developer Anas = new Developer()
            //{
            //    ID = 2,
            //    Name = "Anas",
            //    ProgramingLanguge = "C#"
            //};

            //Pär.DisplayData();
            //Pär.Work();
            //Pär.CondactMeeting();

            //Anas.Work();
            //Anas.DisplayData();
            //Anas.DebugingCode();



            //CreaditCard cc = new CreaditCard();

            //cc.ProsccessPayment(200.00m);


            //PayPal pp = new PayPal();
            //pp.ProsccessPayment(599.00m);

            /// Aggragation 

            //var Omar = new Student("Omar");

            //var Zandra = new Student("Zandra");
            //var Pär = new Student("Pär");
            //var Reiadar = new Student("Raider");


            //var Csharp = new Course("C#/.NET");
            //var Cloude = new Course("Azure");


            //Csharp.AddStudent(Omar);
            //Csharp.AddStudent(Zandra);
            //Cloude.AddStudent(Pär);
            //Cloude.AddStudent(Reiadar);


            //Csharp.ShowStudents();
            //Cloude.ShowStudents();


            /// Compostion 
            /// 
            var house = new House("Storgatan");

            house.AddRoom("Bathroom ", 7);
            house.ShowRoomInfo();
            
            Console.ReadKey();
        }


        //public void Add()
        //{
        //    int result = 1 + 1;
        //}

        //public void Add(int num1,int num2)
        //{
        //    int result = num1 + num2;
        //}
    }


   
}
