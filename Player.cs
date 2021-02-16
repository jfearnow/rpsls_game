using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_App
{
    public abstract class Player  // Blueprint for an Object
    {
        // member variables- has a 
        public int score;
        public string name;
        public chooseGesture;

        // constructor- sets initial values of member variables
        public Player(string human, string computer, string name)
        {
            this.score = 10;
            this.name = name;
        }

        // member methods- what a class can do

        
        public abstract void ChooseGesture();

    }
}
