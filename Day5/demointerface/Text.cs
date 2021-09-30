using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demointerface
{
    public class Text : IDrawable
    {
        public string Message { get; set; }
        public void Draw()
        {
            DrawLine();
            System.Console.WriteLine("*" + Message + "*");
            DrawLine();
        }

        private void DrawLine()
        {
            int n = Message.Length + 2;
            for (int i = 0; i < n; i++) System.Console.Write("*");
            System.Console.WriteLine();
        }
    }
}