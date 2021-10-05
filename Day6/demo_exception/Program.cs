using System;

namespace demo_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                System.Console.Write("Enter a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Enter b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                System.Console.WriteLine("{0} / {1} = {2}", a, b, c);
            }
            // catch (FormatException ex)
            // {
            //     System.Console.WriteLine(ex.Message);
            // }
            // catch (DivideByZeroException ex)
            // {
            //     System.Console.WriteLine(ex.Message);
            // }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            System.Console.WriteLine("Program terminate successful!");
        }
    }
}
