using System;

namespace QuaverMusicCodeChallenge
{
    public class USConstitution

    {
        static void Main()
        {
            //Building a string of characters we need to remove
            char[] delimiterChars = { ' ', ',', '.', ':' };

            //Building the string we are using to test
            string data = "We the People of the United States, in Order to form a more perfect Union, establish Justice, insure domestic Tranquility, provide for the common defence, promote the general Welfare, and secure the Blessings of Liberty to ourselves and our Posterity, do ordain and establish this Constitution for the United States of America.";

            // Settin a counter for each letter we want to keep track of 
            int TCount = 0;
            int ECount = 0;
            int TandECount = 0;

            // We need to parse the string and turn it into a list while removing the unneeded punctuation
            string[] words = data.Split(delimiterChars);
            foreach (string value in words)
            {
                //the first conditional will check for both letters 
                if (value.StartsWith("t") && value.EndsWith("e"))
                {
                    TandECount++;
                }
                //this conditional will check for the first letter to be t 
                else if (value.StartsWith("t"))
                {
                    TCount++;
                }
                //this conditional will check for the last letter to be E
                else if (value.EndsWith("e"))
                {
                    ECount++;
                }

            }
            //Testing the code to see if it works
            Console.WriteLine($"{TCount} word in the the Preamble to the US Constitution starts with T");
            Console.WriteLine($"{ECount} word in the the Preamble to the US Constitution ends with E");
            Console.WriteLine($"{TandECount} word in the the Preamble to the US Constitution start with T and end with E");

        }
    }
}
