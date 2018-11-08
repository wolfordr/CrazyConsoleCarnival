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

        int thanoscoins { get; set; }
        int planetRaid { get; set; }
        int minions { get; set; }
        int infinitystonemult { get; set; }
        int fleet { get; set; }
        int earned { get; set; }
        int time { get; set; }
        int thots { get; set; }

        public override void play()
        {
            
            showTitle("WELCOME TO THE THANOS IDLE GAME!");
            writeLine("So basically... im monky");
            wait(1);
            clear();
            writeLine("You are the Mad Titan Thanos so click spacebar to raid a world and collect some(or one for now) thanos coins");
            writeLine("When you are ready my lord access the shop via the X key on your magic keyboard thingy to buy better minions or even \nsome magic stones O-O");
            int x = 0;
            if (x == 0)
            {
                thanoscoins = 0;
                planetRaid = 1;
                minions = 0;
                infinitystonemult = 1;
                fleet = 1;
                time = 1;
                thots = 1;
            }
            for (x = 0; x < time; x = x + 1)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                
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
                ConsoleKeyInfo input2 = Console.ReadKey();
                if(input2.KeyChar == 'a')
                {
                    if(thanoscoins >= 5000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 5000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You bought the Orb!");
                    }
                }
                if (input2.KeyChar == 's')
                {
                    if (thanoscoins >= 20000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 20000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You bought the Tesseract!");
                    }
                }
                if (input2.KeyChar == 'd')
                {
                    if (thanoscoins >= 50000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 50000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You bought the Aether!");
                    }
                }
                if (input2.KeyChar == 'f')
                {
                    if (thanoscoins >= 5000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 5000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You bought the stone of power!");
                    }
                }
                if (input2.KeyChar == 'g')
                {
                    if (thanoscoins >= 150000)
                    {
                        clear();
                        writeLine("You actually cannot buy this one my lord...");
                        wait(3);
                        writeLine("You must sacrifice something close to you my lord...");
                        wait(3);
                        writeLine("Kill Gamora? Y/N");
                        bool answer = getYesNo();
                        if(answer)
                        {
                            writeLine("The number of thots on this planet: " + thots);
                        }
                        if(!answer)
                        {
                            writeLine("Don't do that, thots are temporary, infinity stones are forever.\nTry again later");
                        }
                    }
                }
                if (input2.KeyChar == 'h')
                {
                    if (thanoscoins >= 250000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 250000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You bought the Eye of Agamoto!");
                    }
                }
                if (input2.KeyChar == 'j')
                {
                    if (thanoscoins >= 1000000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 5000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You freakin killed vision dude holy moly!!!111!1!!!!!!");
                    }
                }
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
                bool thotanswer = getYesNo();
                if(thotanswer)
                {
                    writeLine("There are " + thots + " thots in this sector sir.");
                }
            }
        }
        
    }
}
