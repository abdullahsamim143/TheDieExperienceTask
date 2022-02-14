using System;
using System.Collections.Generic;
using System.Text;

namespace TheDieExperienceTask
{
    // The Roller Task
    public class Rolls: IRoleDice
    {
        //Creating a random number generator for use in methd RollDice  
        private Random randomNumber;
        public Rolls()
        {
            randomNumber = new Random();
        }
        public int Die1 { get; set; }
        public int Die2 { get; set; }
        public int Sum { get; set; }
        public int RollDice()
        {
            Die1 = randomNumber.Next(1, 7);
            Die2 = randomNumber.Next(1, 7);
            Sum = Die1 + Die2;          
            //Display result of this roll              
          
            return Sum;
        }// End method roll dice  
    }
}
