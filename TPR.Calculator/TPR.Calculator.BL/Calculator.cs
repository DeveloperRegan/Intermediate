//Terence Regan
//3/4/2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace TPR.Calculator.BL
{
    public class Calculator
    {
        public bool aSet { get; set; }
        public bool bSet { get; set; }

        //I cannot do a direct tryparse to these values, so I had to add a a1 and b1.  
        //I think this is silly and I am guessing it is bad practice
       public float a { get; set; }
       public float b { get; set; }
        private float a1;
        private float b1;


        public string display { get; set; }
        private bool afterMath = false;

        public string Opperation { get; set; }
        //Constructor
        public Calculator()
        {
            aSet = false;
            bSet = false;
            display = "0";
        }

      
        public void Calculate(string opp)
        {
            //Case Switch function for the math opperations
            switch (opp)

            {
                case "+":
                  a=  Add(a, b);
                    break;
                case "-":
                   a= Subtract(a, b);
                    break;
                case "*":
                  a=  Times(a, b);
                    break;
                case "/":
                   a= Divide(a, b);
                    break;
                default:
                    break;
            }
            //If math is done, the aftermath is set for true;
            afterMath = true;
        }

        public void SetOpperations (string opps)
        {  //Makes the display to be equal to zero if their is an error message displayed
            if (display=="Error")
            {
                display = "0";
            }
            else
            {
                //If math has been done, lets the b number get reset
                if (afterMath == true)
                {  bSet = false; }
                //If A isn't set, sets the a variable.
                if (aSet == false)
                {
                    //I want to do float.TryParse(display, out a); but I get an error.
                    //This is a work around.
                    float.TryParse(display, out a1);
                    a = a1;
                    aSet = true;
                    display = "0";
                }
                //Sets the B variable.
                else if (bSet == false) {
                    float.TryParse(display, out b1);
                    b = b1;
                    bSet = true;
                    //Does the Calculation based on the opperation.  
                    Calculate(Opperation);

                }
              
            }
            //Sets the opperation string to the opps string that was passed
            Opperation = opps;
        }

        /*
         * THe Add, Subtract, Times and Division have the same setup
         * MAth is done, the opperation is set to the appropiate opperation
         * the display is set to the result
         * return the result of the maths
         */
        public float Add(float number1, float number2)
        {
            number1 += number2;
            display = number1.ToString();
            return number1;
        }



        public float Subtract(float number1, float number2)
        {
            number1 += number2;
            Opperation = "-";
            display = number1.ToString();
            return number1;
        }

        public float Times(float number1, float number2)
        {
            Opperation = "*";
            number1 *= number2;
            display = number1.ToString();
            return number1;
        }

        public float Divide(float Number1, float number2)
        {
           Opperation = "/";
            //Checking for a non-0 value
            if (number2 != 0)
            {
                Number1 /= number2;
                display = Number1. ToString();
            }
            else
            {//if non-Zero method, yells at the user.
                DivideByZeroException e = new DivideByZeroException("You Cannot Divide by Zero");
                throw e;
            }
            return Number1;
        }

        public float SquareRoot(string Number)
        {
            //creates a temp variable;
            float temp;
            float.TryParse(Number, out temp);
            //Gets the squareRoot
            float sqr = (float)Math.Sqrt(temp);
            //Sets display to the sqr
            display = sqr.ToString();
            //returns the math result
            return sqr;
        }

        public float Recipricol(string number)
        {
            float temp;
            float.TryParse(number, out temp);
            if (temp != 0)
            {
                temp = (1 / temp);
                display = temp.ToString();
            }
            else
            {
                DivideByZeroException e = new DivideByZeroException("You Cannot Divide by Zero");
                throw e;
            }
            return temp;
        }
    
        public string ChangeDisplay(string currentDisplay, string addDisplay )
        {//checks for a decimal in the Display
            if (afterMath == true)
            {
                currentDisplay = "0";
                bSet = false;
                afterMath = false;
            }
            if(currentDisplay=="0" && addDisplay!=".")
            { return addDisplay; }
            if (currentDisplay.Contains(".") && addDisplay==".")    
                //If the display has a decimal, returns the current value;
            return currentDisplay;
            else { return currentDisplay += addDisplay; }

        }        
        public string Back(string Display)
        {//if the display doesn't have an empty string, deletes the the last character
            if (Display != "")
                return Display.Remove(Display.Length - 1);
            else return Display;
        }


        public string Clear()
        {
            //Clears the values;
            aSet = false;
            bSet = false;
            return "";
        }


        public float negitveOne(string number)
        {
            float temp;
            float.TryParse(number, out temp);

            temp *= -1;
            display = temp.ToString();
            return temp;
        }

        public void Eql()
        {
            if (aSet == true)
            {
                if (bSet != true)
                {
                    float.TryParse(display, out b1);
                    b = b1;
                    bSet = true;
                }
                Calculate(Opperation);

            }
        }
      
    }
}
