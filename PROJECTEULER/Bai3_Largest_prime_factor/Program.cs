using System;
using System.Text;

namespace Bai3_Largest_prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Đéo hiểu sao làm cách này
            //Console.OutputEncoding = Encoding.UTF8;
            //long Tich = 600851475143;
            //long[] arrFactor = new long[1200];
            //int index = 0;
            //arrFactor[index] = 2;
            //index++;
            //arrFactor[index] = 3;
            //index++;
            //arrFactor[index] = 5;
            //index++;
            //bool checkFactor = true;
            //for (int i = 6; i < 8000; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if ((i % j) == 0)
            //        {
            //            checkFactor = false;
            //        }
            //    }
            //    if (checkFactor == true)
            //    {
            //        arrFactor[index] = i;
            //        Console.WriteLine("Số nguyên tố {0}",i);
            //        index++;
            //        checkFactor = false;
            //    }
            //    else
            //    {
            //        checkFactor = true;
            //    }
            //}

            //Console.WriteLine("600851475143 là tích của:");
            //foreach (var item in arrFactor)
            //{
            //    if ((Tich % item) == 0)
            //    {
            //        Console.WriteLine("{0} *", item);
            //        Tich = Tich / item;
            //        if (Tich == 1)
            //        {
            //            Console.WriteLine("Số nguyên tố lớn nhất cần tìm là : {0}", item);
            //            break;
            //        }
            //    }
            //}
            //Console.Read();


            long tong = 600851475143;
            for (long i = 1; i < 600851475143; i++)
            {
                if ((600851475143 % i) == 0)
                {
                    tong = tong / i;
                    Console.WriteLine("Chia cho {0}", i);
                }
                if (tong == 1)
                {
                    break;
                }
            }
            Console.Read();
        }
    }
}
