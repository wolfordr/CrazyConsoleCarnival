using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Hunter : CarnivalGame
    {
        public Hunter() : base()
        {
            
        }

        public override string getName()
        {
            return "Ghoul House";
        }
        
        public override void play()
        {
            showTitle("BEWARE FOR YOU HAVE ENTERED THE HOUSE OF THE GHOUL");
            writeLine("to make choices, press the number key corresponding to your choice.");
            writeLine("press spacebar to begin");
            
            //put wait()'s inbetween all lines?
            if(getKey() == ConsoleKey.Spacebar)
            {
                clear();
                writeLine("You're going Trick-or-Treating with a friend, Carl");
                writeLIne("Being the dare-devil that he is, he suggests going to Old Man Jenkins' house at the end of the block.");
                writeLIne("[Do you say...]");
                writeLIne("1. 'I don't know, that house gives me a bad feeling.'");
                writeLIne("2. 'Let's go! I haven't seen him in forever, do you think he's dead?'");
                if (getKey() == ConsoleKey.NumPad1)
                {
                    clear();
                    writeLine("Carl - Come on, man. Don't wuss out on me like that.");
                    writeLIne("Carl - Worst case scenario, he shakes his fist at us as we walk away.");
                    writeLIne("You reluctantly accept, starting your walk towards the house.");
                    //wait()
                    writeLine("Carl opens the front door of Old Man Jenkins' house and you both walk in together.");
                    writeLIne("The house appears as though it hasn't been inhabited decades.");
                    writeLIne("Everything is covered in a thick layer of dust and cobwebs.");
                    writeLIne("");
                }





            }

            
        }

    }
}
