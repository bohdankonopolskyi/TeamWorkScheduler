using System;
using System.Collections.Generic;
using System.Text;

namespace Sheduler_Lib
{
    public class NonExistentEmployeeException : Exception
    {
        public NonExistentEmployeeException(string message) : base(message)
        {

        }
    }
}
