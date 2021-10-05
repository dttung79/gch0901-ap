using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_throw_exception
{
    public class NameEmptyException : Exception
    {
        public NameEmptyException() : base("Student name is empty!")
        {}
        public NameEmptyException(String message) : base(message)
        {}
    }
    // Ex: Create InvalidAgeException (message: Student age is lower than 18)
}