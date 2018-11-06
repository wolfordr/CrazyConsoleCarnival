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
            int planetRaid = 1;
            int minions = 0;
            int infinitystonemult = 1;
            int fleet = 1;
            int earned;
            int time = 1;
            int thots = 1;
            
            showTitle("WELCOME TO THE THANOS IDLE GAME!");
            writeLine("So basically... im monky");
            wait(1);
            clear();
            writeLine("You are the Mad Titan Thanos so click spacebar to raid a world and collect some(or one for now) thanos coins");
            writeLine("When you are ready my lord access the shop via the X key on your magic keyboard thingy to buy better minions or even \nsome magic stones O-O");
            for (int x = 0; x < time; x = x + 1)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                wait(.2);
                if (input.KeyChar == ' ')
                {
                    clear();
                    earned = (thanoscoins * -1);
                    thanoscoins = thanoscoins + (((planetRaid + minions) * fleet) * infinitystonemult);
                    earned = earned + thanoscoins;
                    writeLine("Lord Thanos you earned " + earned + " that raid...");
                    writeLine("\nLord Thanos you have " + thanoscoins + " Thanos coins...");
                }
                if (input.KeyChar == 'x')
                {
                    clear();
                    shop();
                }
                /*
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
                */
                time = time + 1;
                
            }
        }

        public void shop()
        {
            writeLine("Welcome to the shop Lord Thanos, dont ask me why you of all people have to pay for things...\nStones[A]\nMinions[S]\nFleet[D]\nthots[F]");
            ConsoleKeyInfo input = Console.ReadKey();
            if(input.KeyChar == 'a')
            {
                clear();
                writeLine("Infinity Stones are objects which hold great power over an aspect of the universe and they add to your stone multiplier\nBuy Power for 5000[A]\nBuy Space for 20000[D]\nBuy the Reality for 50000[F]\nBuy the Soul Stone for 150000[G]\nBuy the Time Stone for 250000[H]\nBuy The Mind Stone for 1000000[J]");
            }
            if(input.KeyChar == 's')
            {
                clear();
                writeLine("Minions aid in planet raids making them more profitable");
            }
            if(input.KeyChar == 'd')
            {
                clear();
                writeLine("Buying fleet ships will increase the number of raids you can do at once!");
            }
            if (input.KeyChar == 'f')
            {
                clear();
                writeLine("Would you like to know how many thots there are? Y/N");
            }
        }
        
    }
}
