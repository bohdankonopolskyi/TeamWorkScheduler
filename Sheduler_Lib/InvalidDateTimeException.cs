using System;
using System.Collections.Generic;
using System.Text;

namespace Sheduler_Lib
{
    public class InvalidDateTimeException : Exception
    {

        public InvalidDateTimeException(string message) : base(message)
        {

        }

    }
}
