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
            int increment = 1;
            int infinitystonemult = 1;
            int earned;
            int time = 1;
            int thots = 1;
            
            showTitle("WELCOME TO THE THANOS IDLE GAME!");
            writeLine("So basically... im monky");
            wait(1);
            clear();
            writeLine("You are the Mad Titan Thanos so click spacebar to raid a world and collect some(or one for now) thanos coins");
            writeLine("When you are ready my lord access the shop via the X key on your magic keyboard thingy the buy better minions or even \nsome magic stones O-O");
            for (int x = 0; x < time; x = x + 1)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.KeyChar == ' ')
                {
                    clear();
                    earned = (thanoscoins * -1);
                    thanoscoins = thanoscoins + (increment * infinitystonemult);
                    earned = earned + thanoscoins;
                    writeLine("Lord Thanos you earned " + earned + " that raid...");
                    writeLine(" Lord Thanos you have " + thanoscoins + " Thanos coins...");
                }
                if (input.KeyChar == 'x')
                {
                    clear();
                    Console.WriteLine("Welcome to the shop Lord Thanos, dont ask me why you of all people have to pay for things...");
                }
                else if(input.KeyChar != ' ')
                {
                    clear();
                    writeLine("Try using a key with an actual function\nControls:\nRaid Spacebar\nShop X key");
                }
                time = time + 1;
            }
        }
        
    }
}
