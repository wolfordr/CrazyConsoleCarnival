using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class QuizGame : CarnivalGame
    {
        public QuizGame() : base()
        {
            
        }

        public override string getName()
        {
            return "The Quiz Game";
        }
        
        public override void play()
        {
            writeOut("Welcome to the Random Knowledge Quiz !");
            writeOut("What is your name ?");
            String name = getInput();
            writeOut("Oh Hello " + name + " are you ready to test your knowledge");
            bool getsIt = getYesNo();

            if (getsIt)
                writeLine("Great! Best of luck to you");
            else
                writeLine("Well looks like your doing it anyway, I bet you fail");
        }

    }
}
