using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling
{
    class Custom_Exception :Exception
    {
        public Custom_Exception(string message) : base(message)
        {

        }
    }
}
