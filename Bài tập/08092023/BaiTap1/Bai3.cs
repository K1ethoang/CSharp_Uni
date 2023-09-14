using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. Nhập cạnh a. Tính và xuất chu vi, diện tích hình vuông (cv=4*a và dt=a2)

namespace BaiTap1
{
    internal class Bai3
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            float a;

            do
            {
                Console.Write("Nhập cạnh a (a > 0): ");
                a = float.Parse(Console.ReadLine());
                if (a <= 0)
                    Console.WriteLine("Nhập lại!");
            } while (a <= 0);

            Console.WriteLine("Chu vi: " + 4 * a);
            Console.WriteLine("Diện tích: " + a * a);

            Console.ReadKey();
        }

    }
}
