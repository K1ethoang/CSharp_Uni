using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BaiTap3
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
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
                res += (float)1.0 / i;
            }

            Console.WriteLine("Kết quả: {0}", res);

            Console.ReadKey();
        }
    }
}
