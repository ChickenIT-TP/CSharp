/****************************************************************************************************************************************
    Author:        Ngô Trọng Phong (ChickenIT)
    Create date:   05/03/2020
    Problem:       "If we list all the natural numbers below 10 that are multiples of 3 or 5, 
                    we get 3, 5, 6 and 9. The sum of these multiples is 23.
                    Find the sum of all the multiples of 3 or 5 below 1000."
    Solution:       Sử dụng vòng lặp từ 0 đến 1000 nếu gặp số nào chia hết cho 3 
                    hoặc chia hết cho 5 thì ta cộng các số đó lại. 
                    Hết vòng lặp đưa ra tổng.         
****************************************************************************************************************************************/

using System;
using System.Text;

namespace Bai1_Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cho phép hiển thị chữ tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            int intTong = 0;
            // Vòng lặp từ 0 đến 1000
            for (int i = 0; i < 1000; i++)
            {
                // Nếu số cần duyệt mà chia hết cho 3 hoặc cho 5 thì cộng lại
                if ((i % 3) == 0 || (i % 5) == 0)
                {
                    intTong = intTong + i;
                }
            }
            Console.WriteLine("Tổng của tất cả các số là " +
                "bội của 3 và 5 nhỏ hơn 1000 là: {0}", intTong);
        }
    }
}
