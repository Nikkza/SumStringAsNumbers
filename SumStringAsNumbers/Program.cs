using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SumStringAsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();
                var results = SumStrings(input);
                Console.WriteLine(results);
                Console.WriteLine("---------");
            }
        }

        public static string SumStrings(string inputString)
        {
            BigInteger results = 0;
            BigInteger valueB = 0;
            BigInteger valueA = 0;
            if (!(string.IsNullOrEmpty(inputString)))
            {
                var splitString = inputString.Split(',');
                var numberA = ListAsChar(splitString[0]);
                var numberB = ListAsChar(splitString[1]);

                if (numberA.Count() > 0 && numberB.Count() > 0)
                {
                    if (BigInteger.TryParse(string.Join("", numberA), out valueA)
                        && BigInteger.TryParse(string.Join("", numberB), out valueB))
                        results = valueA + valueB;
                }
                else
                    return "Can't parse";
            }
            else
                return "Sum is 0";

            return $"Sum is: {results.ToString()}";
        }

        static IEnumerable<char> ListAsChar(string splitToArray)
        {
            var charArray = splitToArray.ToCharArray();
            return charArray.Where(x => Char.IsDigit(x));
        }
    }
}
