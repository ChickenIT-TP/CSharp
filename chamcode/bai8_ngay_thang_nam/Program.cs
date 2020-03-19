/*
Đề bài: Viết chương trình đọc từ bàn phím 3 số nguyên biểu diễn ngày, tháng, năm và xuất ra màn hình dưới dạng “dd/mm/yyyy”.
Đầu vào: Một dòng gồm 3 số nguyên cách nhau bởi một dấu cách.
Đầu ra: Một chuỗi theo định dạng ngày tháng năm: dd/mm/yyyy
*/
using System;

namespace bai8_ngay_thang_nam
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            string[] arrInput = strInput.Split(" ");
            int ngay = Convert.ToInt32(arrInput[0]);
            int thang = Convert.ToInt32(arrInput[1]);
            int nam = Convert.ToInt32(arrInput[2]);
            DateTime dt = new DateTime(nam, thang, ngay);
            Console.WriteLine(dt.ToString("dd/MM/yyyy"));
        }
    }
}
