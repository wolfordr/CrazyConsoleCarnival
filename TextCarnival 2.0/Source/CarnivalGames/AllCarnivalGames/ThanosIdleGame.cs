using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class ThanosIdleGame : CarnivalGame
    {
        
        public ThanosIdleGame() : base()
        {
            
        }

        public override string getName()
        {
            return "The Thanos Idle Game";
        }
        
        public override void play()
        {
            int thanoscoins = 0;
            int increment = 0;
            int earned;
            int time = 1;
            String input;
            //Shows the green title text
            showTitle("WELCOME TO THE THANOS IDLE GAME!");
            writeLine("So basically... im monky");
            wait(1);
            clear();
            for (int x = 0; x < time; x = x + 1)
            {
                input = Console.ReadLine();
                if(input != " ")
                {
                    Console.WriteLine("Should've aimed for the head...(try spacebar UwU)");
                }
                Console.WriteLine("You earned " + " Thanos buck(s)");
            }
        }
        
    }
}
