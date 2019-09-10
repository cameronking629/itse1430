/*
 * ISE 1430
 * Lab 1
 * Cameron King
 */

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( string[] args )
        {
            //Movie data
            //string title;
            //int runLength;
            //int releaseYear;
            //string description;
            //bool haveSeen;

            var quit = false;
            while (!quit)
            {
                char input = DisplayMenu ();
                switch (input)
                {
                    //Fallthrough allowed only if case is empty
                    case 'a':
                    case 'A': AddMovie (); break;

                    //Must have break/return at end of each case
                    case 'D': DisplayMovie (); break;
                    case 'R': RemoveMovie (); break;
                    case 'Q':
                    {
                        quit = true;
                        break;
                    }
                    
                    default: Console.WriteLine("Not supported"); break;
                };
                //if (input == 'A')
                //    AddMovie ();
                //else if (input == 'D')
                //    DisplayMovie ();
                //else if (input == 'R')
                //    RemoveMovie ();
                //else if (input == 'Q')
                //    break;
            };

        }


        static void AddMovie()
        {
            //Get title
            Console.Write ("Title: ");
            title = Console.ReadLine ();

            //Get description
            Console.Write ("Description: ");
            description = Console.ReadLine ();

            //Get release year
            releaseYear = ReadInt32 ("Release Year: ");


            //Get run length
            runLength = ReadInt32 ("Run length (in minutes): ");

            //Get have seen
            hasSeen = ReadBoolean ("Have seen? ");
        }

        private static void RemoveMovie ()
        {
            //Confirm removal
            //Please DON'T do this expression == true, expression
            if (!ReadBoolean ($"Are you sure you want to remove {title}?: "))
                return;

            //Remove movie
            title = null;
        }

        static void DisplayMovie()
        {
            //Display message if no movies
            if (String.IsNullOrEmpty (title))
            {
                Console.WriteLine ("No movies.");
                return;
            };
            //Title, description, release year, run length, hasSeen
            Console.WriteLine (title);
            Console.WriteLine (description);

            //Formatting strings
            //1) String concat
            Console.WriteLine ("Released " + releaseYear);

            //2) Printf
            //Console.WriteLine ("Run time: {0}", runLength);

            //3) String formatting
            var formattedString = String.Format ("Run time: {0}", runLength);
            Console.WriteLine (formattedString);

            //4) String interpolation
            Console.WriteLine ($"Seen it? {hasSeen}");

            Console.WriteLine ("".PadLeft(50, '-'));
        }

        static int ReadInt32(string message)
        {
            while (true)
            {
                Console.Write (message);

                string input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                //int result;
                //if (Int32.TryParse (input, out result))
                if (Int32.TryParse(input, out var result))
                    return result;

                Console.WriteLine ("Not a number");
            };
        }

        static bool ReadBoolean ( string message )
        {
            while (true)
            {
                Console.Write (message);

                string input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                bool result;
                if (Boolean.TryParse (input, out result))
                    return result;

                Console.WriteLine ("Not a boolean");
            };
        }

        static char DisplayMenu()
        {
            do
            {
                Console.WriteLine ("A)dd Movie");
                Console.WriteLine ("D)isplay Movie");
                Console.WriteLine ("R)emove Movie");
                Console.WriteLine ("Q)uit");

                string input = Console.ReadLine ();

                //Lower case
                input = input.ToLower ();
                //if (input == "A" || input == "a")
                //if (input == "a")
                if (String.Compare (input, "a", true) == 0)
                {
                    return 'A';
                } else if (input == "d")
                {
                    return 'D';
                }
                else if (input == "r")
                {
                    return 'R';
                }
                else if (input == "q")
                {
                    return 'Q';
                } 
                else
                    Console.WriteLine ("Invalid input");

            } while (true);
        }

        private static void DemoLanguage ()
        {
            //TODO: Move this
            string name = "";

            //string if = "";

            //Definitely assigned
            //name = "Bob";
            string name2 = Console.ReadLine ();

            //name2 = Console.ReadLine ();

            Console.WriteLine (name2);


            name2 = name = "Sue";

            Console.WriteLine ("Hello World!");



            int hours = 8;
            double payRate = 15.25;

            double totalPay = payRate * hours;


            string fullName = "Fred" + " " + "Jones";
        }

        static void DemoArithmetic ()
        {
            Int32 hours2;
            int hours = 8;
            hours2 = hours;
            double payRate = 15.25;

            double totalPay = hours * payRate;

            double taxes = totalPay * 0.33;

            //Combination operators work
            hours += 8;

            totalPay = hours * payRate;
            double newTaxes = totalPay * 0.66;
        }

        static void DemoRelational ()
        {
            int grade = 75;
            int passingGrade = 60;

            bool isGreater = grade > passingGrade;
            bool isGreaterThanOrEqual = grade >= passingGrade;
            bool isLessThan = grade < passingGrade;
            bool isLessThanOrEqual = grade <= passingGrade;
            bool isEqual = grade == passingGrade;
            bool isNotEqual = grade != passingGrade;
        }

        static void DemoLogical ()
        {
            bool value1 = true;
            bool value2 = false;

            //Both left and right must be true
            bool logicalAnd = value1 && value2;

            //Either left or right must be true
            bool logicalOr = value1 || value2;

            //Negates the value
            bool logicalNot = !value1;
        }

        static void DemoConditional ()
        {
            int grade = 75;

            // C ? T : F
            // Evaluate C, if true then T is the value of the expression
            //otherwise F is
            bool isPassing = grade > 60 ? true : false;

            //Equivalent to what an if statement could do if it were an expression
            if (grade > 60)
                isPassing = true;
            else
                isPassing = false;
        }

        static void DemoArray ()
        {
            double[] payRates = new double[100];

            //50th element to 7.25
            payRates[49] = 7.25;

            //Read 89th element into temp variable
            double temp = payRates[88];

            //Print out the 80th element
            Console.WriteLine (payRates[79]);

            //An empty array
            //bool[] isPassing = new bool[0];
            var isPassing = new bool[0];

            //Enumerating an array
            for (int index = 0; index < payRates.Length; ++index)
                Console.WriteLine (payRates[index]);

            //Type inferencing
            //string name = "Bob William Smith Jr III";
            var name = "Bob William Smith Jr III";
            //name = 20;
            

            string[] nameParts = name.Split (' ');
        }

        static void DemoString ()
        {
            string str = null;

            //Checking for null
            if (str != null)
                str = str.ToLower ();

            //Checking for null or empty string
            if (str != null && str != "")
                str = str.ToLower ();

            //Length - NO
            if (str != null && str.Length == 0)
                str = str.ToLower ();

            //Empty - NO
            if (str != null && str != String.Empty)
                str = str.ToLower ();

            //Correct approach
            if (!String.IsNullOrEmpty(str))
                str = str.ToLower ();
        }

        //Don't do this outside Lab 1
        static string title;
        static string description;
        static int runLength;
        static int releaseYear;
        static bool hasSeen;
    }
}
