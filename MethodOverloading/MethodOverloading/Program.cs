using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var integerSum = Add(10, 20);
            var decimalSum = Add(1m, 3m);
            var addParams = Add(0, 1, true);
            Console.WriteLine($"The sum of Integeres: {integerSum}");
            Console.WriteLine($"The sum of Decimals: {decimalSum}");
            Console.WriteLine($"The String: {addParams}");
        }

        public static int Add(int x, int y)
        {
            return x + y;

        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool condition)
        {

            if (condition == true && (x + y) == 1)
            {
                return $"{x + y} dollar";
            }
            else if (condition == true && (x + y) >= 1)
            {
                return $"{x + y} dollars";
            }
            else
            {
                return $"{x + y}";
            }

        }
    }
}
