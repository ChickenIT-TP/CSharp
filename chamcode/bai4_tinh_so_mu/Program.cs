/*
Đề bài: Nhập vào một số nguyên a (a <= 100), Tính và in ra giá trị của a2, a3, a4
Đầu vào: Một số nguyên duy nhất a
Đầu ra: Ba số a2, a3, a4 mỗi số cách nhau bởi dấu cách.
*/

using System;

namespace bai4_tinh_so_mu
{
    class Program
    {
        static void Main(string[] args)
        {
            int intSoDauVao = Convert.ToInt32(Console.ReadLine());
            double outMu2 = Math.Pow(intSoDauVao, 2);
            double outMu3 = Math.Pow(intSoDauVao, 3);
            double outMu4 = Math.Pow(intSoDauVao, 4);
            Console.WriteLine($"{outMu2} {outMu3} {outMu4}");
        }
    }
}
