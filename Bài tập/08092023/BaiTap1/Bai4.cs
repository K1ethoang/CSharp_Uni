using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4. Nhập cạnh a, b. Tính và xuất chu vi, diện tích hình chữ nhật (cv=2*(a+b) và dt = a * b)

namespace BaiTap1
{
    internal class Bai4
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            float a, b;

            do
            {
                Console.Write("Nhập cạnh a (a > 0): ");
                a = float.Parse(Console.ReadLine());
                Console.Write("Nhập cạnh b (b > 0): ");
                b = float.Parse(Console.ReadLine());
                if (a <= 0 || b <= 0)
                    Console.WriteLine("Nhập lại!");
            } while (a <= 0 || b <= 0);

            Console.WriteLine("Chu vi: " + 2 * (a + b));
            Console.WriteLine("Diện tích: " + a * b);

            Console.ReadKey();

        }

    }
}
