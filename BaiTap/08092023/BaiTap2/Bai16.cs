using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 16. Nhập n>=0. Tính S(n)=1+2+3+ ... + n.

namespace BaiTap2
{
    internal class Bai16
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;

            do
            {
                Console.Write("Nhập n (> 0): ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("\tKhông hợp lệ!");
            } while (n <= 0);

            int result = (n * (n + 1)) / 2;

            Console.WriteLine("\tKết quả: {0}", result);

            Console.ReadKey();
        }
    }
}
