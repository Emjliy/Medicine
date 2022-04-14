using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class MedicineAlreadyExistException:Exception
    {
        public MedicineAlreadyExistException(string msg) : base(msg) { }
    }
}
