using System;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(-2147483648, -1));
        }

        static int Divide(int dividend, int divisor)
        {

            long count = 0;
            if (dividend == 0)
                return 0;

            if (dividend > 0 && divisor > 0)
            {
                while (dividend - divisor >= 0)
                {
                    dividend -= divisor;
                    count++;
                }
            }
            else if ((dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0))
            {
                while (dividend + divisor <= 0)
                {
                    dividend += divisor;
                    count--;
                }
            }
            else if (dividend > 0 && divisor < 0)
            {
                while (dividend + divisor >= 0)
                {
                    dividend += divisor;
                    count--;
                }
            }
            else if (dividend < 0 && divisor < 0)
            {
                while (dividend - divisor <= 0)
                {
                    dividend -= divisor;
                    count++;
                }
            }

            return count > int.MaxValue ? int.MaxValue :  Convert.ToInt32(count) ;
        }
    }
}
