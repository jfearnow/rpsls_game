using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_App
{
    public class Human : Player // Blueprint for an Object
    {
        // member variables- has a 
        public string face = "Do you have a real face?";
        public int age = 20;

        //constructor- sets initial values of member variables
        public Human()
        {
            ChooseGesture = new.ChooseGestures();
           
         
        }




        //member methods- what a class can do

        public override void ChooseGesture()
        {
            throw new NotImplementedException("Please choose your Gesture:");
        }

    }
}
