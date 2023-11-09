using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_6
{
    internal class Player
    {
        public int answer;
        public int life;
        public Player()
        { 
            answer = 0;
            life = 10;
        }
        public int SetAnswer()
        {
            Console.WriteLine("Input Number");
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    answer = Convert.ToInt32(input);

                    if (0 <= answer && answer <= 999)
                        return answer;
                    else
                    {
                        Console.WriteLine("Input 0~999");
                        continue;
                    }
                }
                catch (Exception e) { Console.WriteLine("Input Number!"); }
            }
        }

        public void LoseLife()
        {
            life--;
            Console.WriteLine("Your Life = {0}", life);
        }
    }
}
