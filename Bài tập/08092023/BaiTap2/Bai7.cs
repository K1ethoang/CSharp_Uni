using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 7. Nhập vào một năm và cho biết năm đó có phải là năm nhuận hay không? (Năm nhuận là năm chia hết cho 4 mà không chia hết cho 100, hoặc chia hết cho 400).

namespace BaiTap2
{
    internal class Bai7
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            short year;

            do
            {
                Console.Write("Nhập năm (> 0): ");
                year = short.Parse(Console.ReadLine());

                if (year <= 0)
                    Console.WriteLine("\tNhập lại\n");
            } while (year <= 0);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("\tNăm nhuận");
            else
                Console.WriteLine("\tKhông phải năm nhuận");

            Console.ReadKey();
        }
    }
}
