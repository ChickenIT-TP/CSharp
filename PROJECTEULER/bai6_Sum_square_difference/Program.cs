using System;

namespace bai6_Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double sum_of_the_squares = 0;
            double square_of_the_sum = 0;
            double tempSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum_of_the_squares = sum_of_the_squares + Math.Pow(i, 2);
                tempSum = tempSum + i;
            }
            square_of_the_sum = Math.Pow(tempSum, 2);
            result = square_of_the_sum - sum_of_the_squares;
            Console.WriteLine("{0}", result);
        }
    }
}
