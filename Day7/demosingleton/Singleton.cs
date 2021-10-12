using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demosingleton
{
    public class Singleton
    {
        private static Singleton instance = null;
        public string Data { get; set; }
        private Singleton()
        {
            Data = "Hello Singleton";
        }

        public static Singleton GetInstance() 
        {
            if (instance == null) instance = new Singleton();
            return instance;
        }
    }
}