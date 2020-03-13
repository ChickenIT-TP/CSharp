/*
Đề bài: Viết chương trình nhập vào bán kính hình cầu, tính và in ra diện tích, thể tích của hình cầu đó. Biết công thức tính diện tích và thể tích lần lượt là: S = 4πR^2 và V = (4/3)πR^3. Lấy π = 3.14
Đầu vào: Một số là bán kính hình cầu.
Đầu ra: Hai số cách nhau bởi dấu cách là diện tích và thể tích hình cầu, kết quả làm tròn đến 2 chữ số thập phân.
*/

using System;

namespace bai7_hinh_cau
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14;
            double intBanKinhHinhCau = Double.Parse(Console.ReadLine());
            double outDienTich = 4 * PI * Math.Pow(intBanKinhHinhCau, 2);
            double outTheTich = (4 * PI * Math.Pow(intBanKinhHinhCau, 3))/3;
            Console.WriteLine($"{outDienTich.ToString("0.00")} {outTheTich.ToString("0.00")}");
        }
    }
}
