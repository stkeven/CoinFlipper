using System;
using System.Collections.Generic;
using System.Text;

namespace SCPart13
{//Classes can help keep code organized when applications become large
    public class Coin
    {/// <summary>
    /// declaration of variables
    /// </summary>
        private string sideUp;
        //Allows randomization
        Random rand;
        //private variable declared
        private string _sideup;
        public Coin()
        {//instantiates the class Random which is already available for use
            rand = new Random();
            //Declares a value for _sideup for default.
            _sideup = "Heads";
        }
        /// <summary>
        /// Logic to simulate a coinflip
        /// </summary>
        public void FlipCoin()
        {//Gets 2 possible random integers starting at 0
            int randomSide = rand.Next(2);
            //if the flip is equal to 0...
            if (randomSide == 0)
            {//set sideup equal to heads
                _sideup = "Heads";
            }//if the flip isn't equal to 0
            else
            {//set sideup equal to tails
                _sideup = "Tails";
            }
        }
        /// <summary>
        /// For returning the result of the computation
        /// </summary>
        /// <returns></returns>
        public string GetSideUp()
        {//Return the sideup result
            return _sideup;
        }
       
    }
}
