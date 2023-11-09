using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_7
{
    internal class Bingo
    {
        public int[,] puzzle;
        public int bingo;
        public Bingo()
        {
            puzzle = new int[5, 5];
            bingo = 0;
            SetPuzzle();
        }

        public void Swap(ref int x, ref int y) 
        {
            int temp = x;
            x = y;
            y = temp;
        }
        
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++) 
            {
                int x = random.Next() % 5;
                int y = random.Next() % 5;
                int newX = random.Next() % 5;
                int newY = random.Next() % 5;
                if (x != newX || y != newY)
                {
                    Swap(ref puzzle[x, y], ref puzzle[newX, newY]);
                }
            }
        }

        public void SetPuzzle()
        {
            for(int i=0; i<5;i++)
            {
                for(int j=0; j<5;j++)
                {
                    puzzle[i, j] = i * 5 + j+1;
                }
            }
            Shuffle();
        }

        public void DisplayPuzzle()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(puzzle[i, j]);
                    if (puzzle[i, j] < 10)
                        Console.Write(" ");
                    Console.Write("           ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        public void PickNumber(int input)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (puzzle[i, j] == input)
                        puzzle[i, j] = 0;
                        return true;
                }
            }
            return false;
        }
        public void CheckBingo()
        { }
        public void MakeBingo()
        {
            bingo++;
        }
    }
}
