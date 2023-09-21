using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 14. Viết chương trình giả 1 máy tính tay với các phép toán đơn giản như +,-,*,/ và lấy căn bậc 2.

namespace BaiTap2
{
    internal class Bai14
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            char ope;
            int num1, num2 = 0;

            Console.Write("Nhập toán tử \n+ (cộng), - (trừ), * (nhân), / (chia), ~ (căn bậc 2): ");
            ope = char.Parse(Console.ReadLine());
            if (ope == '~')
            {
                Console.Write("Nhập toán hạng: ");
                num1 = int.Parse(Console.ReadLine());
            }

            else
            {
                Console.Write("Nhập toán hạng 1: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Nhập toán hạng 1: ");
                num2 = int.Parse(Console.ReadLine());
            }

            float result = 0;

            if (ope == '+')
                result = num1 + num2;
            else if (ope == '-')
                result = num1 - num2;
            else if (ope == '*')
                result = num1 * num2;
            else if (ope == '/')
                result = (float)num1 / num2;
            else
                result = (float)Math.Sqrt(num1);

            Console.WriteLine("Kết quả: " + result);
            Console.ReadKey();
        }
    }
}
