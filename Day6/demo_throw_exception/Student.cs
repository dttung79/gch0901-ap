using System;

namespace demo_throw_exception
{
    public class Student
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set 
            {
                if (value == "") throw new NameEmptyException();
                else name = value;  // Ex: validate name != empty
            }
        }    

        private int age;
        public int Age 
        {
            get { return age; }
            set // validate age >= 18
            {
                if (value < 18) throw new Exception("Invalid age. Age must be >= 18");
                else age = value;
            }
        }
    }
}