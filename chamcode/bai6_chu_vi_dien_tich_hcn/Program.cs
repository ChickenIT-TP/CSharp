/*
Đề bài: Nhập vào 2 số nguyên dương là 2 cạnh a, b của hình chữ nhật (0 < a, b <= 100000). Tính chu vi, diện tích HCN.
Đầu vào: Một dòng gồm 2 số cách nhau bởi dấu cách.
Đầu ra: Một dòng gồm 2 số là chu vi, diện tích của hcn cách nhau bởi dấu cách.
*/
using System;

namespace bai6_chu_vi_dien_tich_hcn
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();

            string[] arrInput = strInput.Split(" ");
            double canhThu1 = Double.Parse(arrInput[0]);
            double canhThu2 = Double.Parse(arrInput[1]);

            double outChuVi = (canhThu1 + canhThu2) * 2;
            double outDienTich = canhThu1 * canhThu2;
            Console.WriteLine($"{outChuVi} {outDienTich}");
        }
    }
}
