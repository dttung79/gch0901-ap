using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace products
{
    public abstract class MenuProgram
    {
        public virtual void Run()
        {
            bool running = true;
            while (running) 
            {
                // print a menu
                PrintMenu();
                // user chooses an option
                int option = ChooseOption();
                // based on option -> do something
                DoTask(option);
                if (option == 0) running = false;
            }
        }

        protected abstract void PrintMenu();
        protected abstract void DoTask(int option);
        protected virtual int ChooseOption()
        {
            System.Console.Write("Enter your choice: ");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
    }
}