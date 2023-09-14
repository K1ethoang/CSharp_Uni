using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 8. Nhập vào tháng t (với 1<=t<=12). Cho biết tháng t có bao nhiêu ngày. Riêng tháng 2 thì phải kiểm tra năm nhuận (Năm nhuận là năm chia hết cho 4 mà không chia hết cho 100, hoặc chia hết cho 400).

namespace BaiTap2
{
    internal class Bai8
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

            short yearNow = (short)DateTime.Now.Year

            bool isLeapYear = ((yearNow % 4 == 0 && yearNow % 100 != 0) || yearNow % 400 == 0) ? true : false;

            byte date = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    date = 31;
                    break;
                case 2:
                    if (isLeapYear)
                        date = 29;
                    else
                        date = 28;
                    break;
                default:
                    date = 30;
                    break;
            }

            Console.WriteLine("Tháng {0} có {1} ngày", month, date);

            Console.ReadKey();
        }
    }
}
