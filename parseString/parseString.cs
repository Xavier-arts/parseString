/*  Ben Yoder, 2012, parseString.cs
 *     
 *  Description : Safely Parse a String to a numeric value
 *      using TryParse and loops
 */

using System;

namespace safeParse
{
    class parseString
    {
        ///<summary>
        ///  - Combines ReadLine and TryParse to safely convert a string into a integer
        ///  ,returns an integer
        ///</summary>
        ///<remarks>
        ///Uses a loop to try again until it works
        ///</remarks>
        public static int toInt()
        {
            int number = 0;
            bool testParse;
            string line;

            line = Console.ReadLine( );

            do
            {
                testParse = Int32.TryParse(line, out number);

                if (testParse != true)
                {
                    Console.Write("Error! Please Enter in an Integer: ");
                    line = Console.ReadLine();
                }

            } while (testParse != true);

            return number;
        }//end

        ///<summary>
        ///  - Converst a string using TryParse safely into an integer
        ///  ,returns an integer
        ///</summary>
        ///<remarks>
        ///Uses a loop to try again until it works
        ///has spacing if error occurs
        ///</remarks>
        public static int toInt( string line )
        {
            int number = 0;
            bool testParse;

            do
            {
                testParse = Int32.TryParse(line, out number);

                if (testParse != true)
                {
                    Console.Write("Error! Please Enter in an Integer: ");
                    line = Console.ReadLine();
                }

            } while (testParse != true);

            return number;
        }//end

        ///<summary>
        ///  - Combines ReadLine and TryParse to safely convert a string into a integer
        ///  ,returns an integer
        ///</summary>
        ///<remarks>
        ///Uses a loop to try again until it works
        ///has spacing if error occurs
        ///</remarks>
        public static int toIntSpacing( )
        {
            int number = 0;
            bool testParse;
            string line;

            line = Console.ReadLine();

            do
            {
                testParse = Int32.TryParse(line, out number);

                if (testParse != true)
                {
                    Console.Write("  Error! Please Enter in an Integer: ");
                    line = Console.ReadLine();
                }

            } while (testParse != true);

            return number;
        }//end

        ///<summary>
        ///  - Combines ReadLine and TryParse to safely convert a string into a double
        ///  ,returns a double
        ///</summary>
        ///<remarks>
        ///Uses a loop to try again until it works
        ///</remarks>
        public static double toDouble()
        {
            double number = 0;
            bool testParse;
            string line;

            line = Console.ReadLine();

            do
            {
                testParse = Double.TryParse(line, out number);

                if (testParse != true)
                {
                    Console.Write("Error! Please Enter in a Number: ");
                    line = Console.ReadLine();
                }

            } while (testParse != true);

            return number;
        }//end

        ///<summary>
        ///  - Converst a string using TryParse safely into an double
        ///  ,returns an double
        ///</summary>
        ///<remarks>
        ///Uses a loop to try again until it works
        ///has spacing if error occurs
        ///</remarks>
        public static double toDouble(string line)
        {
            double number = 0;
            bool testParse;

            do
            {
                testParse = Double.TryParse(line, out number);

                if (testParse != true)
                {
                    Console.Write("Error! Please Enter in a Number: ");
                    line = Console.ReadLine();
                }

            } while (testParse != true);

            return number;
        }//end

        ///<summary>
        ///  - Combines ReadLine and TryParse to safely convert a string into a double
        ///  ,returns an double
        ///</summary>
        ///<remarks>
        ///Uses a loop to try again until it works
        ///has spacing if error occurs
        ///</remarks>
        public static double toDoubleSpacing( )
        {
            double number = 0;
            bool testParse;
            string line;

            line = Console.ReadLine();

            do
            {
                testParse = Double.TryParse(line, out number);

                if (testParse != true)
                {
                    Console.Write("  Error! Please Enter in a Number: ");
                    line = Console.ReadLine();
                }

            } while (testParse != true);

            return number;
        }//end
    }//end class parseString
}
