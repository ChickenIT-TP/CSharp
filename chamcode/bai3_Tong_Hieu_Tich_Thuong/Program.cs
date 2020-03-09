/*
    Đề bài: Viết chương trình đọc và 2 số nguyên và in ra kết quả của phép cộng (+), phép trừ (-), phép nhân (*), phép chia (/). 
    Kết quả phép chia làm tròn đến 2 chữ số thập phân.
    Đầu vào: Một dòng gồm 2 số nguyên a, b (b khác 0) cách nhau bởi dấu cách.
    Đầu ra: 2 dòng, dòng đầu ghi tổng, hiệu của 2 số, dòng sau ghi tích thương của 2 số. Các số trên cùng một dòng cách nhau bởi dấu cách.
    Ví dụ:
    input:
    9 3
    output:
    12 6
    27 3.00
*/

using System;

namespace bai3_Tong_Hieu_Tich_Thuong
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            string[] arrInput = strInput.Split(" ");
            int so1 = Convert.ToInt32(arrInput[0].ToString());
            int so2 = Convert.ToInt32(arrInput[1].ToString());
            int tong = so1 + so2;
            int hieu = so1 - so2;
            int tich = so1 * so2;
            double thuong = (double)so1 / (double)so2;
            Console.WriteLine($"{tong} {hieu}");
            Console.WriteLine($"{tich} {thuong.ToString("0.00")}");
        }
    }
}
