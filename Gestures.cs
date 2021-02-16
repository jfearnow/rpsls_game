using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_App
{
    class Gestures // Blueprint of an Object
    {
        //member variables- has a 
        public string rock;
        public string paper;
        public string scissors;
        public string spock;
        public string lizard;
        List<Gestures> chooseGesture;
        

        //Constructor 
        public Gestures()
        {
            chooseGesture = new List<Gestures>;
        }
            
        
            
                
            

        

        //constructor- sets initial values of member variables
        public Gestures(string rock, string paper, string scissors, string spock, string lizard)
        {
            this.rock = rock;
            this.paper = paper;
            this.scissors = scissors;
            this.spock = spock;
            this.lizard = lizard;

            
        }

        //member methods- what a class can do

    }
}
