using System;

namespace demo_throw_exception
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ex: Using while loop to enter valid student name & age
            Student s = new Student();
            while (true)
            {
                try
                {
                    System.Console.Write("Enter student name: ");
                    
                    s.Name = Console.ReadLine();
                    System.Console.Write("Enter student age: ");
                    s.Age = Convert.ToInt32(Console.ReadLine());

                    break;
                }
                catch (FormatException e)
                {
                    System.Console.WriteLine("Invalid format!");
                }
                catch (NameEmptyException e)
                {
                    System.Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }            
            }
            Console.WriteLine("Student name: {0}, age: {1}", s.Name, s.Age);
        }
    }
}
