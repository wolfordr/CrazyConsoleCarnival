using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class UnfairMineSweeper : CarnivalGame
    {
        public UnfairMineSweeper() : base()
        {
            
        }

        public override string getName()
        {
            return "Unfair MineSweeper";
        }

        public override void play()
        {
            //Shows the green title text
            showTitle("WELCOME TO UNFAIR MINESWEEPER");

            writeOut("To play simply input a coordinate to reveal, The cords go 0-9 and originate from the top left corner");
            wait(2);
            writeOut("I don't know why you would want to leave but if you do just type in Q");
            wait(2);
            writeOut("BTW you can't flag mines, If that sounds unfair rearead the name of this game");
            wait(2);
            writeOut("correctly reveal all safe spaces to win!");
            wait(1);
            writeOut("Board loading...");
            wait(1);
            writeOut("done!");
            wait(1);

            Random rng = new Random();
            bool[,] showfield = new bool[10, 10];
            bool[,] minefield = new bool[10, 10];
            String[,] playfield = new String[10, 10];
            bool flag = true;
            String input;

            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    if (rng.Next(0, 100) <= 30)
                    {
                        minefield[i, k] = true;
                        playfield[i, k] = "M";
                    }
                    else
                    {
                        minefield[i, k] = false;
                        playfield[i, k] = "j";
                    }
                    showfield[i, k] = false;
                }
            }

            boardPrint(playfield, showfield);

            while (flag)
            {
                writeLine("input a cordinate with the y first then the x with a comma bewtween exp. 7,8\n");
                input = Console.ReadLine();
                if (input.Equals("Q")) { break; }
                if (input.Length > 3 || input.Length <= 2)
                {
                    writeLine("INVALID INPUT! Try again :D");
                    break;
                }


                playfield[Int32.Parse(input.Substring(0, 1)), Int32.Parse(input.Substring(2, 1))] = minecheck(Int32.Parse(input.Substring(0, 1)), Int32.Parse(input.Substring(2, 1)), minefield);
                showfield[Int32.Parse(input.Substring(0, 1)), Int32.Parse(input.Substring(2, 1))] = true;
                boardPrint(playfield, showfield);

                if (minefield[Int32.Parse(input.Substring(0, 1)), Int32.Parse(input.Substring(2, 1))])
                {
                    flag = false;
                    writeOut("Welp you hit a at [" + input + "], I am really not surprised! :D");
                    wait(2);
                }

                if (wincheck(showfield, minefield))
                {
                    writeOut("You must have gotten a really easy board or you are a god at logic.");
                    wait(2);
                    writeOut("Either that or you got lucky");
                    wait(2);
                    writeOut("Nevertheless you won, I guess you deserve a prize!");
                    wait(2);
                    writeOut("Your prize is information, the creator of this game is Ryan Wolford!");
                    wait(2);
                    writeOut("Also you beat the game with " + rng.Next(1, 10) + " seconds left!");
                    wait(2);
                    writeOut("So um.... goodbye :D");
                    wait(2);
                    break;
                }
            }

        }

        private string minecheck(int y, int x, bool[,] mineF) // Checks for mines around input
        {
            int counter = 0;
            int lowery = y - 1, lowerx = x - 1, uppery = 2, upperx = 2;

            if (mineF[y, x])
                return "X";


            if (y == 0) { lowery = 0; }

            if (y == 9) { uppery = 1; }

            if (x == 0) { lowerx = 0; }

            if (x == 9) { upperx = 1; }

            for (int j = lowery; j < y + uppery; j++)
            {

                for (int a = lowerx; a < x + upperx; a++)
                {
                    if (mineF[j, a])
                    {
                        counter++;
                    }
                }
            }
            return "" + counter;
        }


        private void boardPrint(String[,] playF, bool[,] showF) // Finished
        {
            
            String printer = "";
          
            for (int k = 0; k < 10; k++)
            {

                printer = "[";
                for (int i = 0; i < 10; i++)
                {
                    if (showF[k, i])
                    {
                        printer += playF[k, i] + "] ";
                    }
                    else
                    {
                        printer += "?" + "] ";
                    }
                    if (i != 9)
                        printer += "[";
                }
                writeLine(printer + "\n");
               
            }
        }

        private bool wincheck(bool[,] showF, bool[,] mineF)
        {
            for (int i = 0; i < 10;i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    if (!(showF[i,k]) && !(mineF[i,k]))
                    {
                        return false;
                    }
                }
            }
            return true;
        } 
        

    }
}
