using System;

namespace vai5_Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 2520;
            while (true)
            {
                if ((count%11) == 0 && (count%12)==0 && (count % 13) == 0 && (count % 14) == 0 && 
                    (count % 15) == 0 && (count % 16) == 0 && (count % 17) == 0 && (count % 18) == 0 && 
                    (count % 19) == 0 && (count % 20) == 0)
                {
                    Console.WriteLine("{0}", count);
                    break;
                }
                count++;
            }
        }
    }
}
