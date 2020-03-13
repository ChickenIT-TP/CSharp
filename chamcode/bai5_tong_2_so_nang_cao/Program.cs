/*
Đề bài: Cho 2 số nguyên a, b. Tính tổng 2 số đó biết (|a| và |b| <= 10 tỷ ).
Đầu vào: Một dòng chứa 2 số cách nhau bởi dấu cách.
Đầu ra: Một số duy nhất là tổng của 2 số.
*/

using System;

namespace bai5_tong_2_so_nang_cao
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arrNum = input.Split(" ");
            double outTong = Double.Parse(arrNum[0]) + Double.Parse(arrNum[1]);
            Console.WriteLine($"{outTong}"); 
        }
    }
}
