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
            string title;
            int runLength;
            int releaseYear;
            string description;
            bool haveSeen;

            while (true)
            {
                char input = DisplayMenu ();
                if (input == 'A')
                    AddMovie ();
                else if (input == 'Q')
                    break;
            };

        }

        static void AddMovie()
        {
            //Get title
            Console.Write ("Title: ");
            string title = Console.ReadLine ();

            //Get description
            Console.Write ("Description: ");
            string description = Console.ReadLine ();

            //Get release year
            int releaseYear = ReadInt32 ("Release Year: ");


            //Get run length
            int runLength = ReadInt32 ("Run length (in minutes): ");

            //Get have seen
            bool haveSeen = ReadBoolean ("Have seen? ");
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
                if (Int32.TryParse(input, out int result))
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
                Console.WriteLine ("Q)uit");

                string input = Console.ReadLine ();
                if (input == "A" || input == "a")
                {
                    return 'A';
                } 
                else if (input == "Q" || input == "q")
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
            int hours = 8;
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
    }
}
