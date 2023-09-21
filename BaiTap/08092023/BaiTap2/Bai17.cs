using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 17. Nhập n >= 0, n chẵn. Tính S(n)= 2 + 4 + ... +n.

namespace BaiTap2
{
    internal class Bai17
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;

            do
            {
                Console.Write("Nhập n (> 0, chẵn): ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0 || n % 2 != 0)
                    Console.WriteLine("\tKhông hợp lệ!");
            } while (n <= 0 || n % 2 != 0);

            int result = 2 * ((n / 2 * (n / 2 + 1)) / 2);

            Console.WriteLine("\tKết quả: {0}", result);

            Console.ReadKey();
        }
    }
}
