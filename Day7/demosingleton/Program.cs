using System;

namespace demosingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton s = new Singleton();
            Singleton s = Singleton.GetInstance();
            System.Console.WriteLine(s.Data);

            s.Data = "Hello Singleton Pattern";

            // somewhere else
            Singleton s2 = Singleton.GetInstance();
            System.Console.WriteLine(s2.Data);
        }
    }
}
