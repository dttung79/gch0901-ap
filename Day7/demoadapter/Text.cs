using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoadapter
{
    public class Text
    {
        public String Content { get; set; }

        public Text() 
        {
            Content = "Hello";
        }

        public Text(string content)
        {
            Content = content;
        }

        public void Print()
        {
            int n = Content.Length + 2;
            for (int i = 0; i < n; i++) System.Console.Write("*");
            System.Console.WriteLine();
            System.Console.WriteLine("*" + Content + "*");
            for (int i = 0; i < n; i++) System.Console.Write("*");
            System.Console.WriteLine();
        }
    }
}