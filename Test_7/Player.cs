using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_7
{
    internal class Player
    {
        public int number;
        public int InputNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    number = int.Parse(input);
                    return number;
                }
                catch
                {
                    Console.WriteLine("Wrong number");
                    continue;
                }
            }
        }

    }
}
