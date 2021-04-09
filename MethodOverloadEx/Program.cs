using System;

namespace MethodOverloadEx
{
    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal z, decimal w)
        {
            return z + w;
        }
        public static string Add(int x, int y, bool money)
        {
            var sum = x + y;

            if (money == true&& sum > 1)
            {

                return $"{sum} dollars";
            }
            else if (money == true&& sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (money == true&& sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            var x = 12;
            var y = 62;

            var answer = Add(x, y);

            var z = 7.9m;
            var w = 8.3m;

            var correctness = Add(z, w);

            var yesness = Add(9, 6, true);
           
            Console.WriteLine($"int Add:{answer} decimal Add:{correctness}");
            Console.WriteLine($" I have {yesness} to my name");
        }



    }
}






