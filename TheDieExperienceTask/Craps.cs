using System;
using System.Collections.Generic;
using System.Text;

namespace TheDieExperienceTask
{
    public class Craps
    {
        Rolls rolldice = new Rolls();

        public static int exSumOfDice = 0;

        // PLAY ONE GAME OF CRAP  
        // The Die Task
        public void Play()
        {
            Status gameStatus = Status.CONTINUE;
            int myPoint = 0;
            int sumOfDice = rolldice.RollDice();
            Console.WriteLine("Player rolled {0} + {1} = {2}", rolldice.Die1, rolldice.Die2, rolldice.Sum);

            switch ((DiceName)sumOfDice)
            {
                case DiceName.SEVEN:
                case DiceName.YO_LEVEN:
                    gameStatus = Status.WON;
                    break;
                case DiceName.BOX_CARS:
                case DiceName.SNAKE_EYES:
                case DiceName.TREY:
                    gameStatus = Status.LOST;
                    break;
                default:
                    gameStatus = Status.CONTINUE;
                    myPoint = sumOfDice;
                    Console.WriteLine("Point is {0}", myPoint);
                    break;
            }
            while (gameStatus == Status.CONTINUE)
            {
                sumOfDice = rolldice.RollDice(); // roll dice again 
            
                //if (sumOfDice == myPoint)
                   // sumOfDice = rolldice.RollDice(); // roll dice again

                Console.WriteLine("Player rolled {0} + {1} = {2}", rolldice.Die1, rolldice.Die2, rolldice.Sum);

                if (sumOfDice == myPoint)
                    gameStatus = Status.WON;
                if (sumOfDice == (int)DiceName.SEVEN)
                    gameStatus = Status.LOST;
            }
            // end of while method  

            // Display won or loss  
            if (gameStatus == Status.WON)
                Console.WriteLine("Palyer Wins");
            else
                Console.WriteLine("Player Losses");
        }//end of method Play  

    }
}
