using System;

namespace demo_handle_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int a = InputInteger("Enter a: ");
            int b = InputInteger("Enter b: ");
            int c = a / b;
            System.Console.WriteLine("{0} / {1} = {2}", a, b, c);
        }

        static int InputInteger(string prompt)
        {
            int a = 0;
            while (true)
            {
                try 
                {
                    Console.Write(prompt);
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid format. Please try again!");
                } 
            }
            return a;
        }
    }
}
