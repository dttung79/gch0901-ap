using System;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new BTECStudent("Minh", "M");
            System.Console.WriteLine(s);

            s = new TopupStudent("Long", 90);
            System.Console.WriteLine(s);

            BTECStudent b = new BTECStudent();
            System.Console.WriteLine(b);


            // Homework: Write menu program
            // 1. Enter btec student & show
            // 2. Enter topup student & show
            
        }
    }
}
