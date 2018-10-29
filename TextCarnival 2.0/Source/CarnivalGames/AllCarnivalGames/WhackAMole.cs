using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class WhackAMole : CarnivalGame
    {
        public WhackAMole() : base()
        {
            
        }

        public override string getName()
        {
            return "Whack-A-Mole";
        }
        
        public override void play()
        {
            tutorial();
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
            writeLine("- A -  - S -  - D -  - F -");
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
                writeOut("Alright, let's start!"); wait(2);
            }
        }
    }
}
