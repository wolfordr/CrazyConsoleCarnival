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

        public bool[] upgrade = new bool[13];

        public override void play()
        {
            
            showTitle("WELCOME TO THE THANOS IDLE GAME!");
            writeLine("So basically... im monky");
            wait(1);
            clear();
            writeLine("You are the Mad Titan Thanos so click spacebar at any time\neven in other menus to raid a world and collect some thanos coins");
            writeLine("When you are ready my lord access the shop via the X key on your magic keyboard thingy to buy better minions or even \nsome magic stones O-O");
            writeLine("Click Q at any time to exit the game");
            
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
                ConsoleKey inputmain = getKey();
                
                if (inputmain == ConsoleKey.Spacebar)
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
                if (inputmain == ConsoleKey.X)
                {
                    clear();
                    Shop();
                }
                if(inputmain == ConsoleKey.Q)
                {
                    clear();
                    writeLine("Do you wish to exit the game? Y/N");
                    bool exit = getYesNo();
                    if(exit)
                    {
                        break;
                    } 
                }

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
                    if (!upgrade[0])
                    {
                        if (thanoscoins >= 5000)
                        {
                            clear();
                            thanoscoins = (thanoscoins - 5000);
                            infinitystonemult = infinitystonemult + 1;
                            writeLine("You bought the Orb!");
                            upgrade[0] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
                }
                if (inputStone == ConsoleKey.S)
                {
                    if (!upgrade[1])
                    {
                        if (thanoscoins >= 20000)
                        {
                            clear();
                            thanoscoins = (thanoscoins - 20000);
                            infinitystonemult = infinitystonemult + 1;
                            writeLine("You bought the Tesseract!");
                            upgrade[1] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
                }
                if (inputStone == ConsoleKey.D)
                {
                    if (!upgrade[2])
                    {
                        if (thanoscoins >= 50000)
                        {
                            clear();
                            thanoscoins = (thanoscoins - 50000);
                            infinitystonemult = infinitystonemult + 1;
                            writeLine("You bought the Aether!");
                            upgrade[2] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
                }
                if (inputStone == ConsoleKey.F)
                {
                    if (!upgrade[3])
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
                            if (answer)
                            {
                                thots = thots - 1;
                                writeLine("The number of thots on this planet: " + thots);
                                wait(3);
                                infinitystonemult = infinitystonemult + 1;
                                writeLine("Soul Stone obtained");
                                upgrade[3] = true;
                            }
                            if (!answer)
                            {
                                writeLine("Don't do that, thots are temporary, infinity stones are forever.\nTry again later");
                            }
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already obtained this stone!");
                    }
                }
                if (inputStone == ConsoleKey.G)
                {
                    if (!upgrade[4])
                    {
                        if (thanoscoins >= 250000)
                        {
                            clear();
                            thanoscoins = (thanoscoins - 250000);
                            infinitystonemult = infinitystonemult + 1;
                            writeLine("You bought the Eye of Agamoto!");
                            upgrade[4] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
                }
                if (inputStone == ConsoleKey.H)
                {
                    if (!upgrade[5])
                    {
                        if (thanoscoins >= 1000000)
                        {
                            clear();
                            thanoscoins = (thanoscoins - 1000000);
                            infinitystonemult = infinitystonemult + 1;
                            writeLine("You freakin killed vision dude holy moly!!!111!1!!!!!!");
                            upgrade[5] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
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
                    if (!upgrade[6])
                    {
                        if (thanoscoins >= 500)
                        {
                            clear();
                            thanoscoins = (thanoscoins - 500);
                            minions = minions + 1;
                            writeLine("You recruited Cull Obsidian!");
                            upgrade[6] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
                }
                if (inputminion == ConsoleKey.S)
                {
                    if (!upgrade[7])
                    {
                        if (thanoscoins >= 1000)
                        {
                            clear();
                            thanoscoins = (thanoscoins - 1000);
                            minions = minions + 1;
                            writeLine("You recruited Ebony Maw!");
                            upgrade[7] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
                }
                if (inputminion == ConsoleKey.D)
                {
                    if (!upgrade[8])
                    {
                        if (thanoscoins >= 2500)
                        {
                            clear();
                            thanoscoins = (thanoscoins - 2500);
                            minions = minions + 1;
                            writeLine("You recruited Corvus Glaive!");
                            upgrade[8] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
                }
                if (inputminion == ConsoleKey.F)
                {
                    if (!upgrade[9])
                    {
                        if (thanoscoins >= 4000)
                        {
                            clear();
                            thanoscoins = (thanoscoins - 4000);
                            minions = minions + 1;
                            writeLine("You recruited Proxima Midnight!");
                            upgrade[9] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
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
                    if (!upgrade[10])
                    {
                        if (thanoscoins >= 3000)
                        {
                            clear();
                            fleet = fleet + 1;
                            writeLine("Thanos Car Wins Piston Cup\nThanos Car Wins Piston Cup");
                            upgrade[10] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
                }
                if (fleetinput == ConsoleKey.S)
                {
                    if (!upgrade[11])
                    {
                        if (thanoscoins >= 6000)
                        {
                            clear();
                            fleet = fleet + 2;
                            writeLine("\"We are now in a flying donut, billions of miles from Earth.\"");
                            upgrade[11] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
                }
                if (fleetinput == ConsoleKey.D)
                {
                    if (!upgrade[12])
                    {
                        if (thanoscoins >= 10000)
                        {
                            clear();
                            fleet = fleet + 3;
                            writeLine("Thanos really travelling in a big old H");
                            upgrade[12] = true;
                        }
                        else { Nomoney(); }
                    }
                    else
                    {
                        clear();
                        writeLine("You already bought that!");
                    }
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
            int random = rnd.Next(0, 5);
            String[] hateToBreakItToYa = new String[5];
            hateToBreakItToYa[0] = "\nYou cannot afford that my lord! Please dont hurt me...";
            hateToBreakItToYa[1] = "\nOkay so basically... you cannot afford this";
            hateToBreakItToYa[2] = "\nYou cannot afford that";
            hateToBreakItToYa[3] = "\nTry again when you have more currency";
            hateToBreakItToYa[4] = "\nNever in a million years would i sell that to you for so little come back with more coins";

            writeLine(hateToBreakItToYa[random]);
        }
        
    }
}
