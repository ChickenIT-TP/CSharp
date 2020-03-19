/*
Đề bài: Hãy lập trình chương trình giải phương trình bậc 2: ax^{2} + bx + c = 0 với a, b, c nhập từ bàn phím.
Đầu vào: Một dòng gồm 3 số cách nhau bởi dấu cách.
Đầu ra: In ra cho các trường hợp.
1/ “VSN” – Nếu phương trình vô số nghiệm
2/ “VN” – Nếu phương trình vô nghiệm
3/ “x = 2.00” – Nếu phương trình có một nghiệm (Nghiệm 2).
4/ Nếu phương trình có 2 nghiệm, in 2 nghiệm đó trên một dòng và cách nhau bởi dấu cách. Nghiệm nhỏ in trước, nghiệm lớn in sau.
Các nghiệm được làm tròn tới 2 chữ số thập phân.
*/
using System;

namespace bai13_phuong_trinh_bac_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            string[] arrInput = strInput.Split(" ");
            int soa = Int32.Parse(arrInput[0]);
            int sob = Int32.Parse(arrInput[1]);
            int soc = Int32.Parse(arrInput[2]);
            double denta = Math.Pow(sob, 2) - 4 * soa * soc;
            if (soa == 0 && sob == 0 && soc == 0)
            {
                Console.WriteLine("VSN");
            }
            else if (denta < 0)
            {
                Console.WriteLine("VN");
            }
            else if (denta == 0)
            {
                Console.WriteLine($"x = {(Convert.ToDouble(-sob)/Convert.ToDouble(2*soa)).ToString("0.00")}");
            }
            else if (denta > 0)
            {
                double nghiem1 = (Convert.ToDouble(-sob) + Math.Sqrt(denta)) / Convert.ToDouble(2 * soa);
                double nghiem2 = (Convert.ToDouble(-sob) - Math.Sqrt(denta)) / Convert.ToDouble(2 * soa);
                if (nghiem1<=nghiem2)
                {
                    Console.WriteLine($"{nghiem1.ToString("0.00")} {nghiem2.ToString("0.00")}");
                }
                else
                {
                    Console.WriteLine($"{nghiem2.ToString("0.00")} {nghiem1.ToString("0.00")}");
                }
            }
        }
    }
}
