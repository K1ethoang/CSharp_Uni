using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. Nhập cạnh a, b, c. Tính và xuất chu vi, diện tích hình tam giác (cv=a+b+c và dt = sqrt(p(p − a)(p – b)(p − c)) với p = cv / 2)

namespace BaiTap1
{
    internal class Bai5
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            float a, b, c;

            do
            {
                Console.Write("Nhập cạnh a (a > 0): ");
                a = float.Parse(Console.ReadLine());
                Console.Write("Nhập cạnh b (b > 0): ");
                b = float.Parse(Console.ReadLine());
                Console.Write("Nhập cạnh c (c > 0): ");
                c = float.Parse(Console.ReadLine());
                if (a <= 0 || b <= 0 || c <= 0)
                    Console.WriteLine("Nhập lại!");
            } while (a <= 0 || b <= 0 || c <= 0);

            double chuVi = a + b + c;
            double p = chuVi / 2;
            double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Chu vi: {0}", chuVi);
            Console.WriteLine("Diện tích: {0}", dienTich);

            Console.ReadKey();

        }

    }
}
