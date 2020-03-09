using System;

namespace bai2_tong2so
{
    class Program
    {
        static void Main(string[] args)
        {
            int soA, soB;
            Console.WriteLine("Nhap vao 2 so tu nhien");
            soA = Convert.ToInt32(Console.Read());
            soB = Convert.ToInt32(Console.Read());
            Console.WriteLine("Tong cua 2 so la:");
            Console.WriteLine(Convert.ToString(soA + soB));
        }
    }
}
