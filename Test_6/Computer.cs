using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_6
{
    internal class Computer
    {
        public int value;

        public int SetValue()
        {
            Random random = new Random();
            value = random.Next(0, 1000);
            return value;
        }
    }
}
