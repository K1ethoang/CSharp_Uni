using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 6. Nhập vào tháng t (với 1<=t<=12). Cho biết t thuộc quý mấy trong năm.

namespace BaiTap2
{
    internal class Bai6
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            byte month;

            do
            {
                Console.Write("Nhập tháng t (1 <= t <= 12): ");
                month = byte.Parse(Console.ReadLine());

                if (month < 0 || month > 12)
                    Console.WriteLine("\tNhập lại\n");
            } while (month < 0 || month > 12);

            byte quarter = 0;

            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    quarter = 1;
                    break;
                case 4:
                case 5:
                case 6:
                    quarter = 2;
                    break;
                case 7:
                case 8:
                case 9:
                    quarter = 3;
                    break;
                case 10:
                case 11:
                case 12:
                    quarter = 4;
                    break;
            }

            Console.WriteLine("Tháng {0} thuộc quý {1}", month, quarter);

            Console.ReadKey();
        }
    }
}
