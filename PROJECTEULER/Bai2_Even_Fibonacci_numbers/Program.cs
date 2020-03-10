using System;

namespace Bai2_Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long tong = 0;
            int count = 2;
            long[] arrFibonacci = new long[1000];
            long so1 = 1;
            long so2 = 2;
            long so3 = 0; ;
            arrFibonacci[0] = so1;
            arrFibonacci[1] = so2;
            while (true)
            {
                so3 = so2 + so1;
                if (so3 < 4000000)
                {
                    arrFibonacci[count] = so3;
                    so1 = so2;
                    so2 = so3;
                }
                else
                {
                    break;
                }
                count++;
            }

            foreach (var item in arrFibonacci)
            {
                if ((item %2) == 0)
                {
                    tong = tong + item;
                }
            }
            Console.WriteLine("{0}", tong);
        }
    }
}
