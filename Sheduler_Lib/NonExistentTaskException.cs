using System;
using System.Collections.Generic;
using System.Text;

namespace Sheduler_Lib
{
    public class NonExistentTaskException : Exception
    {
        public NonExistentTaskException(string message) : base(message)
        {

        }
    }
}
