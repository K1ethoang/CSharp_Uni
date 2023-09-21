using System;
using System.Collections.Specialized;
using System.Text;

namespace BaiTap3
{
    internal class Bai3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            do
            {
                Console.Write("Nhập n ( >= 0): ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                    Console.WriteLine("Không hợp lệ!");
            } while (n < 0);

            float res = 0;

            for (int i = 1; i <= n; i++)
            {
                int sum = (i * (i + 1)) / 2;

                res += (float)1.0 / sum;
            }

            Console.WriteLine("Kết quả: {0}", res);

            Console.ReadKey();
        }
    }
}
