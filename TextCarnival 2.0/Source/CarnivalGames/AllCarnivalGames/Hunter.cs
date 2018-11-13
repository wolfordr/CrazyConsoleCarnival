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
                    writeLine("The house appears as though it hasn't been inhabited decades.");
                    writeLine("Everything is covered in a thick layer of dust and cobwebs.");
                    writeLine("Carl - Let's go find Old Man Jenkins!");
                    writeLine("Carl sprints up a staircase and zips out of sight.");
                    writeLine("You weren't that interested to begin with so you just walk after him.");
                    writeLine("Walking up the stairs, you notice old portraits of family hanging on the walls.");
                    writeLine("You reach the top of the stair case and arrive at a long hallway.");
                    writeLine("It's so dark that you can't see the end of the hallway");
                    writeLine("You...");
                    writeLine("1. Run towards the scream to help your friend.");
                    writeLine("2. Turn around and walk away. You didn't like Carl that much anyways.");
                    if(getKey() == ConsoleKey.NumPad1)
                    {
                        
                    }
                    if (getKey() == ConsoleKey.NumPad2)
                    {
                        clear();
                        writeLine("You start down the stairs, but you hear heavy footsteps coming quickly down the hallway.");
                        writeLine("You quicken your pace and head for the door.");
                        writeLine("You make it to the door, but the handle won't budge. You're trapped.");
                        writeLine("You turn around to find Carl right infront of you holding a large knife.");
                        writeLine("His eyes are rolled back so only the white show, and his neck is red and bloody.");
                        writeLine("Carl plunges his knife deep into your chest without warning.");
                        writeLine("Everything goes black. you have died.");
                        writeLine("GAME OVER");
                    }
                }





            }

            
        }

    }
}
