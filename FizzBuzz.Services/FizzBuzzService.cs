using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Services
{
    public static class FizzBuzzService
    {
        private static readonly IList<Func<int, string, string>> Rules = new List<Func<int, string, string>>
        {
            Fizz,
            Buzz,
            Zero,
            Other
        };

        public static string Translate(int i)
        {
            /*Please Uncomment edit and Use Resharper to convert to LINQ*/
            /*
                var result = string.Empty;
                foreach (var rule in Rules)
                    result = rule(i, result);
                return result;
            */

            return Rules.Aggregate(string.Empty, (current, rule) => rule(i, current));
        }

        private static string Fizz(int i, string returnResult)
        {
            return returnResult + (IsFizz(i) ? "Fizz" : string.Empty);
        }

        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private static string Buzz(int i, string returnResult)
        {
            return returnResult + (IsBuzz(i) ? "Buzz" : string.Empty);
        }

        private static string Other(int i, string returnString)
        {
            if (string.IsNullOrEmpty(returnString))
                returnString = i.ToString();
            return returnString;
        }

        private static string Zero(int i, string returnString)
        {
            if (IsZero(i))
                returnString = "0";
            return returnString;
        }

        private static bool IsZero(int i)
        {
            return i == 0;
        }

        private static bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }
    }
}