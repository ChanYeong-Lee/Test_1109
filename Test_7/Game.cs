using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_7
{
    internal class Game
    {
        public Bingo bingo;
        public Player player;
        public Game()
        {
            bingo = new Bingo();
            player = new Player();  
        }

        public void DisplayPuzzle()
        {
            bingo.DisplayPuzzle();
        }
        
        public void PickNumber()
        {
            bingo.PickNumber(player.InputNumber());
        }
       
    }
}
