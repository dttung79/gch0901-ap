using System;

namespace student
{
    class Program : MenuProgram
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("Student Program");
            System.Console.WriteLine("1. Btec");
            System.Console.WriteLine("2. Topup");
            System.Console.WriteLine("0. Exit");
        }
        protected override void DoSomething(int option)
        {
            switch (option)
            {
                case 1: EnterBTECStudent();  break;
                case 2: EnterTopupStudent(); break;
                case 0: break;
                default: System.Console.WriteLine("Invalid option!"); break;
            }
        }

        private void EnterTopupStudent()
        {
            // enter name, grade
            System.Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter student grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            // create TopupStudent object
            TopupStudent s = new TopupStudent(name, grade);
            // print student
            System.Console.WriteLine(s);
        }

        private void EnterBTECStudent()
        {
            // enter name, grade
            // create BTECSTudent object
            // call Show method
            System.Console.WriteLine("TODO: EnterBTEC");
        }
    }
}
