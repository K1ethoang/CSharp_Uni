using System;
using System.Collections.Specialized;
using System.Text;

namespace BaiTap3
{
    internal class Bai4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n, x;
            do
            {
                Console.Write("Nhập n ( >= 0): ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Nhập x ( >= 0): ");
                x = int.Parse(Console.ReadLine());
                if (n < 0 || x < 0)
                    Console.WriteLine("Không hợp lệ!");
            } while (n < 0 || x < 0);

            float res = 0;

            for (int i = 1; i <= n; i++)
            {
                int bot = (i * (i + 1)) / 2;
                int top = (int)Math.Pow(x, i);

                res += (float)top / bot;
            }

            Console.WriteLine("Kết quả: {0}", res);

            Console.ReadKey();
        }
    }
}
