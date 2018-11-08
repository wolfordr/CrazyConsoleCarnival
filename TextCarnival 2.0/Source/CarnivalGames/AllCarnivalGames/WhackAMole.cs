using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class WhackAMole : CarnivalGame
    {
        public String q = " ", w = " ", e = " ", r = " ", a = " ", s = " ", d = " ", f = " ", z = " ", x = " ", c = " ", v = " ";
        public static Random rand = new Random();
        public static Stopwatch time = new Stopwatch();
        public int limit = 1000;
        public int hole = rand.Next(1, 12);
        public int score = 0;
        String input;
        public WhackAMole() : base()
        {
            
        }

        public override string getName()
        {
            return "Whack-A-Mole";
        }
        
        public override void play()
        {
            writeOut("Would you like to see the tutorial? yes or no?");
            bool tut = getYesNo();
            if (tut){
                tutorial();
            }
            writeOut("Start!"); wait(2);
            clear();
            drawBoard();
        }
        public void tutorial()
        {
            clear();
            writeOut("Welcome!"); wait(1);
            writeOut("This is Whack-A-Mole!"); wait(1);
            writeOut("In this game, you whack..."); dramaticPause(3);
            writeOut("...moles!"); wait(1);
            writeOut("The board looks like this:");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("- Q -  - W -  - E -  - R -");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("                          ");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("- A -  - S -  - D -  - F -");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("                          ");
            writeLine("+ - +  + - +  + - +  + - +");
            writeLine("- Z -  - X -  - C -  - V -");
            writeLine("+ - +  + - +  + - +  + - +"); wait(3);
            writeOut("It's a 4x3 grid, and you hit a mole by hitting the key shown in the box."); wait(1);
            writeOut("Simple, isn't it?"); wait(1);
            writeOut("Would you like to see the tutorial again?");
            bool again = getYesNo();

            if (again)
            {
                clear();
                tutorial();
            }
            else
            {
                clear();
                writeOut("Alright, let's go!"); wait(2);
            }
        }
        public void drawBoard()
        {
            while (true)
            {
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("- " + q + " -  - " + w + " -  - " + e + " -  - " + r + " -");
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("                          ");
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("- " + a + " -  - " + s + " -  - " + d + " -  - " + f + " -");
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("                          ");
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("- " + z + " -  - " + x + " -  - " + c + " -  - " + v + " -");
                writeLine("+ - +  + - +  + - +  + - +");
                writeLine("SCORE: " + score);
                hitMole();
                clear();
                clearHoles();
                getMole();
                drawBoard();
            }
        }
        public void clearHoles()
        {
            q = " "; w = " "; e = " "; r = " "; a = " "; s = " "; d = " "; f = " "; z = " "; x = " "; c = " "; v = " ";
        }
        public void getMole()
        {
            hole = rand.Next(1, 12);
            if (hole == 1)
            {
                q = "@";
            }
            else if (hole == 2)
            {
                w = "@";
            }
            else if (hole == 3)
            {
                e = "@";
            }
            else if (hole == 4)
            {
                r = "@";
            }
            else if (hole == 5)
            {
                a = "@";
            }
            else if (hole == 6)
            {
                s = "@";
            }
            else if (hole == 7)
            {
                d = "@";
            }
            else if (hole == 8)
            {
                f = "@";
            }
            else if (hole == 9)
            {
                z = "@";
            }
            else if (hole == 10)
            {
                x = "@";
            }
            else if (hole == 11)
            {
                c = "@";
            }
            else if (hole == 12)
            {
                v = "@";
            }
        }
        public void hitMole()
        {
            time.Start();
            input = getKey().ToString();
            time.Stop();
            if(time.ElapsedMilliseconds>limit)
            {
                return;
            }
            if (input == "Q" && hole == 1)
                score++;
            if (input == "W" && hole == 2)
                score++;
            if (input == "E" && hole == 3)
                score++;
            if (input == "R" && hole == 4)
                score++;
            if (input == "A" && hole == 5)
                score++;
            if (input == "S" && hole == 6)
                score++;
            if (input == "D" && hole == 7)
                score++;
            if (input == "F" && hole == 8)
                score++;
            if (input == "Z" && hole == 9)
                score++;
            if (input == "X" && hole == 10)
                score++;
            if (input == "C" && hole == 11)
                score++;
            if (input == "V" && hole == 12)
                score++;
        }
    }
}
