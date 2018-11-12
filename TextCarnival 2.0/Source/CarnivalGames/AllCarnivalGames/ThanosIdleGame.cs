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
                    thanoscoins = thanoscoins + (((planetRaid + minions) * infinitystonemult) * fleet);
                    earned = earned + thanoscoins;
                    writeLine("Lord Thanos you earned " + earned + " that raid...");
                    writeLine("\nLord Thanos you have " + thanoscoins + " Thanos coins...");
                    if(infinitystonemult == 1)
                    {
                        writeLine("Stats:\nMinion Bonus: " + minions + "\nFleet Ships: " + fleet + "\nInfinity Stone Multiplier: None");
                    }
                    else
                    writeLine("Stats:\nMinion Bonus: " + minions + "\nFleet Ships: " + fleet + "\nInfinity Stone Multiplier: " + infinitystonemult);
                }
                if (input.KeyChar == 'x')
                {
                    clear();
                    Shop();
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

        public void Shop()
        {
            writeLine("Welcome to the shop Lord Thanos, dont ask me why you of all people have to pay for things...\nStones[A]\nMinions[S]\nFleet[D]\nthots[F]");
            ConsoleKey input = getKey();
            if(input == ConsoleKey.A)
            {
                clear();
                writeLine("Infinity Stones are objects which hold great power over an aspect of the universe and they add to your stone multiplier\n(A)Buy Power for [5000]\n(S)Buy Space for [20000]\n(D)Buy the Reality for [50000]\n(F)Buy the Soul Stone for [150000]\n(G)Buy the Time Stone for [250000]\n(H)Buy The Mind Stone for [1000000]");
                ConsoleKey inputStone = getKey();
                if(inputStone == ConsoleKey.A)
                {
                    if (thanoscoins >= 5000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 5000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You bought the Orb!");
                    }
                    else { Nomoney(); }
                }
                if (inputStone == ConsoleKey.S)
                {
                    if (thanoscoins >= 20000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 20000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You bought the Tesseract!");
                    }
                    else { Nomoney(); }
                }
                if (inputStone == ConsoleKey.D)
                {
                    if (thanoscoins >= 50000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 50000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You bought the Aether!");
                    }
                    else { Nomoney(); }
                }
                if (inputStone == ConsoleKey.F)
                {
                    if (thanoscoins >= 5000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 5000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You bought the stone of power!");
                    }
                    else { Nomoney(); }
                }
                if (inputStone == ConsoleKey.G)
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
                    else { Nomoney(); }
                }
                if (inputStone == ConsoleKey.H)
                {
                    if (thanoscoins >= 250000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 250000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You bought the Eye of Agamoto!");
                    }
                    else { Nomoney(); }
                }
                if (inputStone == ConsoleKey.J)
                {
                    if (thanoscoins >= 1000000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 5000);
                        infinitystonemult = infinitystonemult + 1;
                        writeLine("You freakin killed vision dude holy moly!!!111!1!!!!!!");
                    }
                    else { Nomoney(); }
                }
            }
            if(input == ConsoleKey.S)
            {
                clear();
                writeLine("Minions aid in planet raids making them more profitable");
                writeLine("To buy minions click the corresponding key");
                writeLine("(A)Recruit Cull Obsidian[500]\n(S)Recruit Ebony Maw[1000]\n(D)Recruit Corvus Glaive[2500]\n(F)Recruit Proxima Midnight[4000]");
                ConsoleKey inputminion = getKey();
                if(inputminion == ConsoleKey.A)
                {
                    if (thanoscoins >= 500)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 500);
                        minions = minions + 1;
                        writeLine("You recruited Cull Obsidian!");
                    }
                    else { Nomoney(); }
                }
                if (inputminion == ConsoleKey.S)
                {
                    if (thanoscoins >= 1000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 1000);
                        minions = minions + 1;
                        writeLine("You recruited Ebony Maw!");
                    }
                    else { Nomoney(); }
                }
                if (inputminion == ConsoleKey.D)
                {
                    if (thanoscoins >= 2500)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 2500);
                        minions = minions + 1;
                        writeLine("You recruited Corvus Glaive!");
                    }
                    else { Nomoney(); }
                }
                if (inputminion == ConsoleKey.F)
                {
                    if (thanoscoins >= 4000)
                    {
                        clear();
                        thanoscoins = (thanoscoins - 4000);
                        minions = minions + 1;
                        writeLine("You recruited Proxima Midnight!");
                    }
                    else { Nomoney(); }
                }

            }
            if(input == ConsoleKey.D)
            {
                clear();
                writeLine("Purchasing fleet ships will increase the number of raids you can do at once!");
                writeLine("(A)Thanos Car Thanos Car[3000]\n(S)Q-Ship(6000)\n(D)Big H Ship(10000)");
                ConsoleKey fleetinput = getKey();
                
                if(fleetinput == ConsoleKey.A)
                {
                    if (thanoscoins >= 3000)
                    {
                        clear();
                        fleet = fleet + 1;
                        writeLine("Thanos Car Wins Piston Cup\nThanos Car Wins Piston Cup");
                    }
                    else { Nomoney(); }
                }
                if (fleetinput == ConsoleKey.S)
                {
                    if (thanoscoins >= 6000)
                    {
                        clear();
                        fleet = fleet + 2;
                        writeLine("\"We are now in a flying donut, billions of miles from Earth.\"");
                    }
                    else { Nomoney(); }
                }
                if (fleetinput == ConsoleKey.D)
                {
                    if (thanoscoins >= 10000)
                    {
                        clear();
                        fleet = fleet + 3;
                        writeLine("Thanos really travelling in a big old H");
                    }
                    else { Nomoney(); }
                }
            }
            if (input == ConsoleKey.F)
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

        public void Nomoney()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 4);
            String[] hateToBreakItToYa = new String[4];
            hateToBreakItToYa[0] = "\nYou cannot afford that my lord! Please dont hurt me...";
            hateToBreakItToYa[1] = "\nOkay so basically... you cannot afford this";
            hateToBreakItToYa[2] = "\nYour coins are monky";
            hateToBreakItToYa[3] = "\nYou > Thanoscoins";

            writeLine(hateToBreakItToYa[random]);
        }
        
    }
}
