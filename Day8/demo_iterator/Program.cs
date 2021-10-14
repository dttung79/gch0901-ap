using System;
using System.Collections.Generic;
namespace demo_iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(4);
            a.Add(5);
            a.Add(9);
            a.Add(1);
            a.Add(2);
            int s = sum(a.GetEnumerator());
            System.Console.WriteLine("Sum: " + s);

            Stack<int> b = new Stack<int>();
            b.Push(10);
            b.Push(11);
            b.Push(12);
            b.Push(13);

            System.Console.WriteLine("Sum of stack: " + sum(b.GetEnumerator()));

            Queue<int> c = new Queue<int>();
            c.Enqueue(100);
            c.Enqueue(200);
            c.Enqueue(300);

            System.Console.WriteLine("Sum of queue: " + sum(c.GetEnumerator()));

        }

        static int sum(IEnumerator<int> enumerator)
        {
            int s = 0;
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                s += (int) item;
            }
            return s;
        }
    }
}
