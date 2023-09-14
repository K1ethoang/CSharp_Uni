using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 6. Nhập vào hai số nguyên dương a, b. Tính và xuất tổng, hiệu, tích, thương (lưu ý phép chia với số nguyên).

namespace BaiTap1
{
    internal class Bai6
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a, b;

            do
            {
                Console.Write("Nhập cạnh a (a > 0): ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhập cạnh b (b > 0): ");
                b = int.Parse(Console.ReadLine());
                if (a <= 0 || b <= 0)
                    Console.WriteLine("Nhập lại!");
            } while (a <= 0 || b <= 0);

            int tong = a + b, hieu = a - b, tich = a * b;
            float thuong = (float)a / b;

            Console.WriteLine("Tổng: {0}\nHiệu: {1}\nTích: {2}\nThương: {3}", tong, hieu, tich, thuong);

            Console.ReadKey();

        }

    }
}
