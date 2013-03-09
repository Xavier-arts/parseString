using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace safeParse
{
    class testParseString
    {
        static void Main(string[] args)
        {
            //string input;
            double output;

            Console.Write("Enter in a numeric value: ");

            //toDouble
            output = parseString.toDouble();


            Console.WriteLine("Output as numeric value: " + output);

            //end
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
