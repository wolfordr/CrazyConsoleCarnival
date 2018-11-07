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
            showTitle("WELCOME TO A BAD GAME!");

            writeLine("To play simply input a coordinate to reveal, The cords go 0-9 and originate from the top left corner");
            writeLine("I don't know why you are reading this, There is a time limit");
            writeLine("I don't know why you would want to leave but if you do just type in |60Q");

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
                if (input.Length > 3 || input.Length <= 2)
                {
                    writeLine("INVALID INPUT! Try again :D");
                    break;
                }

                if (input.Equals("Q")) { break; }
                playfield[Int32.Parse(input.Substring(0, 1)), Int32.Parse(input.Substring(2, 1))] = minecheck(Int32.Parse(input.Substring(0, 1)), Int32.Parse(input.Substring(2, 1)), minefield);
                showfield[Int32.Parse(input.Substring(0, 1)), Int32.Parse(input.Substring(2, 1))] = true;
                boardPrint(playfield, showfield);

                if (minefield[Int32.Parse(input.Substring(0, 1)), Int32.Parse(input.Substring(2, 1))])
                {
                    flag = false;
                    writeLine("Welp you hit a mine, I am really not surprised! :D");
                    wait(2);
                }
            }

        }





            /* writeLine("Follow along with it both in the console and in the code to see what to do");
            
            //Color example
            writeLine("|70Cool that I can color things right?|f0");

            //To add color put the character ' | ' somewhere in a string
            //then follow it by two hexadecimal characters that represend color
            //|a0 would represend changing the string to foreground color 'a' and background color '0'
            //Experiment to see what characters give what color!
            //black is '0' and white is 'f'
            //this is not part of normal c#, the client side of this program actualy parses the string and changes color
            //On a normal c# project this will not work
            //writeLine("|50The Code shows how to do this!|f0");
            
            //Shows a seperation 
            //showSeperator(30);

           // writeLine("|e0Hey, yea you, are you getting this so far?");

            //Asks for a yes or no responce and return if it was yes
            //bool getsIt = getYesNo();

           // if (getsIt)
               // writeLine("Cool, you get it dont you!");
            //else
                //writeLine("You dont :( how sad, look at the code then.");

            writeLine("Try not answering yes or no to this next one, see how that goes.");
            writeLine("Are you a enjoying this so far?");

            //Gets yes / no
            bool likesIt = getYesNo();

            writeLine("You see how you can controll what the user types so that it has to be something like I requested");

            writeLine("It doesnt have to be yes or no either.");

            writeLine("Are you a [boy] or a [girl]?");      //OMG dont get triggered, its an example

            //Gets a option
            String gender = getOption("boy", "girl");       //YES! in this case there are two options, this is for learning

            writeLine("See there how I restricted it to whatever I wanted, not just yes or no?");

            wait(0.5);

            //Writes the line, character by character
            writeOut("Hey! look at this line, it is writing itself, isnt that cool!");
            writeOut("TEST!");
            writeOut("TEST!");
            writeOut("TEST!");

            writeOut("cool right!");

            getYesNo();
        
            //Clears console
            clear();

            writeOut("You can also clear the screen like i just did!");

            wait(0.5);

            writeOut("You can also have the user wait for something, or for a specific amount of time");

            //Waits x amoutn of seconds, doesnt have to be a whole number
            wait(3.1);

            writeOut("That was 3 seconds");

            wait(2);

            writeOut("And that was another 2");

            writeOut("You can even make it super dramatic if you want");

            //The number specifies how many seconds it waits
            dramaticPause(3);

            writeOut("Do you get it so far?");

            //Gets yes no
            bool stillGetsIt = getYesNo();

            //YOu can use custom colors
            showSeperator(30,"|e0","|d0");

            writeOut("Oh, by the way, whats your name");

            String name = getInput();

            writeOut("See, " + name + " this can also get raw inputs too");

            wait(1);

            writeOut("If you want you can also make the console play sounds");

            //Makes the console beep
            beep();

            writeLine("They are fairly basic, but you can specify frequency and durration if you want");

            //Using the beep command you can specify frequency and durration
            beep(700, 2);
            beep(800, 0.5f);
            beep(900, 0.4f);
            beep(600, 1);

            writeLine("Thats kinda cool, right!");
            writeLine("If you combine some of these features you can do things like this!");
            writeLine("Wana see?");
            getYesNo();

            //This prints out text to try to sound like a type writer
            typeWriter("This is very slow, but kinda cool!");

            wait(1);

            writeLine("Thats about all that this can do.");
            
            writeLine("Have fun and build an amazing game!");

            // To make your own game, dont edit this, but rather create another file in this same locaiton
            // Name the class whatever you want, but make sure that you extend the main carnival game class (inheritance)
            //
            // class [your class name] : CarnivalGame
            //
            // Make sure its namespace at the top reads:
            //
            // namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
            //
           */ // Have fun

        private string minecheck(int y, int x, bool[,] mineF) // Finished
        {
            int counter = 0;
            int lowery = y - 1, lowerx = x - 1, uppery = 2, upperx = 2;

            if (mineF[y, x])
                return "X";


            if (y == 0)
                lowery = 0;

            if (y == 9)
                uppery = 1;

            if (x == 0)
                lowerx = 0;

            if (x == 9)
                upperx = 1;

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
            writeLine("------------------------------\n");
            for (int k = 0; k < 10; k++)
            {

                printer = "[";
                for (int i = 0; i < 10; i++)
                {
                    if (showF[k, i])
                    {
                        printer += playF[k, i] + "]";
                    }
                    else
                    {
                        printer += "?" + "]";
                    }
                    if (i != 9)
                        printer += "[";
                }
                writeLine(printer + "\n");
                writeLine("------------------------------\n");
            }
        }

        /*private bool wincheck(bool[,] showF, bool[,] mineF)
        {
            
        } */
        

    }
}
