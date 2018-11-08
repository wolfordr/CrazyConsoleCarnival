using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class SantosGame : CarnivalGame
    {
        public SantosGame() : base()
        {
            
        }

        public override string getName()
        {
            return "MadLibs";
        }
        
        public override void play()
        {
            //Shows the green title text
            clear();
            showTitle("Welcome to MadLibs!");

            writeLine("Time to write your own story.");
            writeLine("Choose from one of the genres listed:");

            writeOut("Rom Com");
            String input = getInput();

            if (input.Equals("rom com"))
            {
                writeOut("I need 14 words from you to finish the story--I'll ask them for you now, one by one.");
                writeLine("");

                writeOut("Name (your own, or a friend's, if you would rather subject them to the happenings of the cheesy plot line): ");
                String name = getInput();
                writeLine("");

                writeOut("A friend's name: ");
                String fName = getInput();
                writeLine("");

                writeOut("A nice, generic boy name: ");
                String boyName = getInput();
                writeLine("");

                writeOut("And a nice, equally generic girl name: ");
                String girlName = getInput();
                writeLine("");

                writeOut("Two verbs ending in -ing: ");
                String ing1 = getInput();
                String ing2 = getInput();
                writeLine("");

                writeOut("A verb ending in -ed: ");
                String ed1 = getInput();
                writeLine("");

                writeOut("A noun: ");
                String noun = getInput();
                writeLine("");

                writeOut("Two adjectives: ");
                String adj1 = getInput();
                String adj2 = getInput();
                writeLine("");

                writeOut("Two exclamations: ");
                String exc = getInput();
                String exc2 = getInput();
                writeLine("");

                writeOut("A plural noun: ");
                String pluNoun = getInput();
                writeLine("");

                write("Finally, a plural body part: ");
                String bodyPart = getInput();
                writeLine("");

                // Transition
                writeLine("Wonderful. Time for your final product :)");
                clear();
                dramaticPause(3);

                writeOut(name + " wasn't like other girls.");
                writeLine("");

                writeOut("Most high schoolers didn't care about their grades--");
                dramaticPause(1);
                writeOut(name + " absolutely lost her mind for academics.");
                writeLine("");

                writeOut("Most high schoolers went to football games and parties--");
                dramaticPause(1);
                writeOut(name + " found comfort  in " + ing1 + " in the peace and comfort of her own home.");
                writeLine("");

                writeOut("And most high schoolers had a guy or girl to call their own, their " + noun + "ipoo--");
                dramaticPause(1);
                writeOut(name + " was extremely, extremely single.");
                writeLine("");

                dramaticPause(2);
                writeOut("But you can imagine that changed nice and quick.");
                writeLine("");

                writeOut("Most predictably, " + name + " was just " + ing2 + " in the library one " + adj1 + " Tuesday afternoon. " +
                    "\nShe always did this with the most extreme focus. Suddenly, to her great surprise,\n the second bell for class was already ringing. \"" +
                    exc + "!\" She yelled. \n\" 1:00 already???\" She picked up all her " + pluNoun + " and bolted out the door, rounding corners like a Tokyo drifter." +
                    "But alas,\nshe wasn't slick enough to avoid bumping " + bodyPart + " with the most popular guy in school.");

                writeOut("\"" + exc2 + "\" " + name + " yelled as she tumbled to the floor with her " + pluNoun + 
                    );
            }

        }

    }
}
