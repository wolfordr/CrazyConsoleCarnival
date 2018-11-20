using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class UnfairMineSweeper : CarnivalGame
    {
        Random rng = new Random();
        bool[,] showfield = new bool[10, 10];
        bool[,] minefield = new bool[10, 10];
        String[,] playfield = new String[10, 10];
        bool flag;
        String input;
        int iny, inx;



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

            writeOut("I don't know why you would want to leave but if you do just type in Q");

            writeOut("BTW you can flag mines but to unflag them you must reveal the space, If that sounds unfair reread the name of this game");

            writeOut("correctly reveal all safe spaces to win!");

            writeOut("Board loading...");

            writeOut("done!");

            
           

            




           
            
            flag = true;
           

            for (int i = 0; i < 10; i++) // assigns values to mine, showboard, and the playing field
            {
                for (int k = 0; k < 10; k++)
                {
                    if (rng.Next(0, 100) <= 45)
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

            writeOut("enter a place to start exp 6,7");


            string starter = getInput();
            int y = Int32.Parse(starter.Substring(2, 1));
            int x = Int32.Parse(starter.Substring(0, 1));
            int sy = y - 1, ey = y + 2, sx = x - 2, ex = x + 2;

            if (y == 0) { sy = 0; }
            if (y >= 8) { ey = 9; }
            if (x <= 0) { sx = 0; }
            if (x >= 8) { ex = 9; }



            for (int i = sy; i <= ey; i++)
            {
                for (int k = sx; k <= ex; k++)
                {
                    if (minefield[i, k])
                    {
                        minefield[i, k] = false;
                        

                    }
                }
            }
            for (int i = sy; i <= ey; i++)
            {
                for (int k = sx; k <= ex; k++)
                {


                    playfield[i, k] = minecheck(i, k, minefield);
                    showfield[i, k] = true;

                }
            }
            boardPrint(playfield, showfield);

            while (flag) // flag ends loops if you fail or press Q
            {
                writeLine("input a cordinate with the y first then the x with a comma bewtween, if its mine add an M to the back exp. 7,8 M\n");
                input = getInput();
                if (input.Equals("Q")) { break; }

                if (input.Length > 5 || input.Length <= 2) // if error then loss :D
                {
                    writeLine("INVALID INPUT! Try again :D");
                    break;
                }

                iny = Int32.Parse(input.Substring(0, 1));
                inx = Int32.Parse(input.Substring(2, 1));
                if (minecheck(iny,inx,minefield).Equals(" "))
                {
                    zeros(y, x);
                }
                if (input.Length > 3 && input.Substring(4, 1).Equals("m"))
                {
                    playfield[iny, inx] = "f";
                    showfield[iny, inx] = true;
                }
                else
                {
                    playfield[iny, inx] = minecheck(iny, inx, minefield);
                    showfield[iny, inx] = true;
                }


                zeros(iny, inx);
                 boardPrint(playfield, showfield);

                if (minefield[iny, inx] && !(playfield[iny, inx].Equals("f"))) // fail ending
                {
                    flag = false;
                    writeOut("Welp you hit a at [" + input + "], I am really not surprised! :D");
                    wait(2);
                }

                if (wincheck(playfield, minefield)) // win ending
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
            if (counter == 0)
            {
                
                return " ";
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

        private bool wincheck(String[,] showF, bool[,] mineF)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    if (mineF[i, k])
                    {
                        if (!(showF[i, k].Equals("f")))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (showF[i, k].Equals("f"))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void zeros(int y, int x)
        {

            if (x < 0 || x > 9 || y < 0 || y > 9)
                return;

             if (showfield[y, x]) { return; }

            if (!showfield[y, x] && !minecheck(y, x, minefield).Equals(" "))
            {
                showfield[y, x] = true;
                return;
            }
            else
            {
                showfield[y, x] = true;
                zeros(y, x + 1);
                zeros(y, x - 1);
                zeros(y + 1, x);
                zeros(y - 1, x);
                return;

            }
        } 

       
    }
}
