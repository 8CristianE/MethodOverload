using System;

namespace MethodOverload
{
    class Program
    {
        public static int Add(int num1, int num2)
        {

            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if (isTrue && sum > 1 || sum < 1)
            {
                return $"{sum} dollars";

            }
            else if (isTrue && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }



        static void Main(string[] args)
        {
            var answer = Add(3, 5);
            Console.WriteLine(answer);

            var decimalanswer = Add(1.5m, 1.3m);
            Console.WriteLine(decimalanswer);

            var boolanswer = Add(4, 5, false);
            Console.WriteLine($"{boolanswer} dollars");

            var boolanswer2 = Add(1, 0, true);
            Console.WriteLine(boolanswer2);
        }
    }
}

