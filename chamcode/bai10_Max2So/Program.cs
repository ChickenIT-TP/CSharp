/*
Đề bài: Nhập vào 2 số nguyên, tìm và in ra số lớn nhất trong 2 số.
Đầu vào: Một dòng chứa 2 số nguyên cách nhau bởi dấu cách.
Đầu ra: Một số là số lớn nhất trong 2 số.
*/

using System;

namespace bai10_Max2So
{
    public class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            string[] arrInput = strInput.Split(" ");
            int so1 = Int32.Parse(arrInput[0]);
            int so2 = Int32.Parse(arrInput[1]);
            Console.WriteLine($"{Max2Number(so1, so2).ToString()}");
        }

        /// <summary>
        /// Find Max Of 2 Number
        /// </summary>
        /// <param name="so1">Number 1</param>
        /// <param name="so2">Number 2</param>
        /// <returns></returns>
        private static int Max2Number(int so1, int so2)
        {
            if (so1>= so2)
            {
                return so1;
            }
            else
            {
                return so2;
            }
        }
    }
}
