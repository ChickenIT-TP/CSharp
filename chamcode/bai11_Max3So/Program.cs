/*
Đề bài: Nhập vào 3 số nguyên, tìm và in ra số lớn nhất trong 3 số.
Đầu vào: Một dòng chứa 3 số nguyên cách nhau bởi dấu cách.
Đầu ra: Một số là số lớn nhất trong 3 số.
*/
using System;

namespace bai11_Max3So
{
    public class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            string[] arrInput = strInput.Split(" ");
            int so1 = Int32.Parse(arrInput[0]);
            int so2 = Int32.Parse(arrInput[1]);
            int so3 = Int32.Parse(arrInput[2]);
            int Max = Max2Number(Max2Number(so1, so2), so3);
            Console.WriteLine($"{Max.ToString()}");
        }

        /// <summary>
        /// Find Max Of 2 Number
        /// </summary>
        /// <param name="so1">Number 1</param>
        /// <param name="so2">Number 2</param>
        /// <returns></returns>
        private static int Max2Number(int so1, int so2)
        {
            if (so1 >= so2)
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
