using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class CapacityLimitException:Exception
    {

        public CapacityLimitException(string msg) : base(msg) { }
    }
}
