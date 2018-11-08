using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class BallInCup : CarnivalGame
    {
        public override string getName()
        {
            return "Ball In Cup";
        }

        public override void play()
        {
            clear();
            showTitle("Ball In Cup Game");


            int round = 1;
            while (true)
            {
                clear();
                Random rand = new Random();
                int cor = rand.Next(0, cups);
                writeLine("Choose difficulty: (1, 3, 4, or 5)");
                int cups = getInput();
                writeLine("round " + round);
                for ( int i = 1; i <= cups; i++ )
                {
                    writeLine("  ___  \n  /   \  \n /     \ \n    " + i);
                }
                writeLine("Pick a cup");
                int ans = getInput();
                if ( ans == cor )
                {
                    writeLine("  ___  \n  /   \  \n /     \ \n    O");
                    wait(2);
                    writeLine("Lucky Guess...");
                }
                else
                {
                    writeLine("  ___  \n  /   \  \n /     \ ");
                    writeLine("WRONG");
                }

                writeOut("Play Again? (Y/N)");
                string input = getInput();
                if ( input.Contains("Y"))
                {

                }
                else
                {
                    break;
                }
                round++;
            }
        }
    }
}
