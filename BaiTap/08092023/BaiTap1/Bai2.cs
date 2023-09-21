using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Nhập bán kính đường tròn r. Tính và xuất chu vi, diện tích đường tròn tương ứng (cv = 2 * π * r và dt = π * r^2)

namespace BaiTap1
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            const float PI = (float)Math.PI;

            Console.WriteLine(PI);
            float radius;

            do
            {
                Console.Write("Nhập bán kính đường tròn (r > 0): ");
                radius = float.Parse(Console.ReadLine());
                if (radius <= 0)
                    Console.WriteLine("Không hợp lệ!");
            } while (radius <= 0);

            float perimeter = 2 * PI * radius;
            float area = PI * (float)Math.Pow(radius, 2);

            Console.WriteLine("Chu vi: " + perimeter);
            Console.WriteLine("Diện tích: " + area);


            Console.ReadKey();
        }
    }
}
