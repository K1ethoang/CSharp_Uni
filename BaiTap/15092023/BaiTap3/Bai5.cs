using System;
using System.Collections.Specialized;
using System.Text;

namespace BaiTap3
{
    internal class Bai5
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

            float res = (float)Math.Sqrt(n);

            for (int i = n - 1; i >= 1; i--)
            {
                res = (float)Math.Sqrt(i + (float)res);
            }

            Console.WriteLine("Kết quả: {0}", res);

            Console.ReadKey();
        }
    }
}
