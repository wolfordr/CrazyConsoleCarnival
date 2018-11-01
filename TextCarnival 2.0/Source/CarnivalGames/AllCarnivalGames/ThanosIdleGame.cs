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
        
        public override void play()
        {
            //Shows the green title text
            showTitle("WELCOME TO THE THANOS IDLE GAME!");
            wait(0.5);
            writeLine("So basically... im monky");
            clear();
        }

    }
}
