using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class TwentyOne : CarnivalGame
    {
        public override string getName()
        {
            return "21";
        }
        public override void play()
        {
            showTitle("This is the 21 card game");
            writeLine("[1] How to play"); //1 to play a game
            writeLine("[2] Start game");
            writeLine("Choose '1' to learn how to play or choose '2' to start a game");
            int choice = Convert.ToInt32(getInput());
            if (choice == 1)
            {
                writeLine("The goal is to get your hand to be equal or as close as possible to 21. If you go over 21, you lose. You may draw 3 cards. You will be playing against a computer");
                writeLine("[1] Quit");
                writeLine("[2] Play");
                choice = Convert.ToInt32(getInput());
            }
            if (choice == 2)
            {
                bool playing = true; //true until they stop playing
                bool draw = false; //false until they choose to draw a card
                bool first = true; //true until they are done with their first turn
                int[] hand = new int[3]; 
                Random r = new Random(); //random object to be reused

                hand[2] = 0; //third card if they choose to draw a card later on
                
                int c1 = r.Next(3, 14);
                int c2 = r.Next(3, 14); //computer cards(boosted)

                while (playing)
                {
                    if (first == true)
                    {
                        hand[0] = r.Next(1, 14);
                        hand[1] = r.Next(1, 14); //first two cards
                        writeLine("Your cards are: " + hand[0] + ", " + hand[1]); //prints first two cards
                        first = false; //ends first turn

                    }
                    writeLine("Would you like to draw another card?"); //asks if they want to draw
                    draw = getYesNo(); //records the answer
                    if (draw) //if they want to draw a card
                    {
                        hand[2] = r.Next(1, 14); //if they want to draw then fill third slot in hand
                        writeLine("Your next card is: " + hand[2]); //shows next card
                        writeLine("Your total is: " + (hand[0] + hand[1] + hand[2])); //shows title
                        writeLine("The computers total is: " + (c1 + c2)); //shows other players total
                    }
                    else //if they choose not to draw a card
                    {
                        writeLine("Your total is: " + (hand[0] + hand[1] + hand[2]));
                        writeLine("The computers total is: " + (c1 + c2));
                    }
                    if ((hand[0] + hand[1] + hand[2]) < (c1 + c2) || (hand[0] + hand[1] + hand[2]) > 21) //if your cards are less than the computers cards or your hand is greater than 21
                    {
                        writeLine("You Lost"); //losing scenario
                    }
                    else
                    {
                        writeLine("You win"); //winning scenario
                    }
                    writeLine("Would you like to play again?"); //asks if they want to play again
                    bool option = getYesNo(); //records answer
                    if (option)
                    {
                        playing = true;
                        first = true; //make it so they are recieving the first cards in their hand
                    }
                    else
                        playing = false; //end game if they do not want to play again
                }
            } 
        }
    }
}
