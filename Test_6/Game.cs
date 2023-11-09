using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Test_6
{
    internal class Game
    {
        public Player player;
        public Computer computer;
        bool checker;
        public int value;
        public int answer;
        public Game()
        {
            player = new Player();
            computer = new Computer();
            checker = true;
            value = 0;
            answer = 0;
        }

        public void GameStart()
        {
            SetValue();
            while (checker)
            {
                SetAnswer();
                UpAndDown();
                CheckGame();
            }
        }

        public void SetValue()
        {
            value = computer.SetValue();
        }
        public void SetAnswer()
        {
            answer = player.SetAnswer();
        }

        public void UpAndDown()
        {
            if (value > answer)
            {
                Console.WriteLine("Up!");
                player.LoseLife();
            }
            else if (value < answer)
            {
                Console.WriteLine("Down!");
                player.LoseLife();
            }
            else if (value == answer)
            {
                Console.WriteLine("Correct!");
                GameClear();
            }
       }
        public void GameClear()
        {
            Console.WriteLine("You Win!");
            checker = false;
        }

        public void Reset()
        {
            player = new Player();
            computer = new Computer();
            checker = true;
            value = 0;
            answer = 0;
        }
        public bool Restart()
        {
            while (true)
            {
                Console.WriteLine("Restart? Y/N");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Y":
                    case "y":
                        Reset();
                        return true;
                    case "N":
                    case "n":
                        return false;
                    default:
                        continue;
                }
            }
        }

        public void GameOver()
        {
            Console.WriteLine("You Lose!");
            checker = false;
        }
        public void CheckGame()
        {
            if (player.life == 0)
            {
                GameOver();
            }
            else
                return;
        }
    }
}