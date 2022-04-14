using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class NotFoundException:Exception
    {
        public NotFoundException(string msg) : base(msg) { }
    }
}
