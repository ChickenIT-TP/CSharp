/*

Đề bài: Viết chương trình nhập vào số giây, đổi số giây nhập vào thành dạng “hh:mm:ss”.
Đầu vào: Một số nguyên duy nhất.
Đầu ra: Một chuỗi định dạng như trên.
*/

using System;

namespace bai9_gio_phut_giay
{
    class Program
    {
        static void Main(string[] args)
        {
            int intInPut = Convert.ToInt32(Console.ReadLine());
            string gio = (intInPut / 3600).ToString("00");
            int duGio = intInPut % 3600;
            string phut = (duGio / 60).ToString("00");
            string giay = (duGio % 60).ToString("00");
            Console.WriteLine($"{gio}:{phut}:{giay}");
        }
    }
}
