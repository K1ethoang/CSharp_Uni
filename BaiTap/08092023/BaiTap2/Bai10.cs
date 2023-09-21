using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 10. Nhập vào một ngày (ngày, tháng, năm). Tìm ngày kế trước ngày vừa nhập (ngày/tháng/năm).

namespace BaiTap2
{
    internal class Bai10
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            short day, month, year;

            bool isLeapYear = false;

            do
            {
                Console.Write("Nhập ngày (1 <= ngày <= 31): ");
                day = short.Parse(Console.ReadLine());
                Console.Write("Nhập tháng (1 <= tháng <= 12): ");
                month = short.Parse(Console.ReadLine());
                Console.Write("Nhập năm (1900 <= năm <= 2023): ");
                year = short.Parse(Console.ReadLine());

                isLeapYear = ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) ? true : false;

                if (day < 1 || day > 31 || (month == 2 && day >= 30) || (!isLeapYear && day == 29 && month == 2) || (day == 31 && (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)))
                    Console.WriteLine("\tNgày không hợp lệ\n");
                if (month < 1 || month > 12)
                    Console.WriteLine("\tTháng không hợp lệ\n");
                if (year < 1900 || year > 2023)
                    Console.WriteLine("\tNăm không hợp lệ\n");

            } while (day < 1 || day > 31 || month < 1 || month > 12 || year < 1900 || year > 2023 || (month == 2 && day >= 30) || (!isLeapYear && day == 29 && month == 2) || (day == 31 && (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)));

            Console.WriteLine("\nNgày tháng năm vừa nhập: {0}/{1}/{2}", day, month, year);

            short dayN = day, monthN = month, yearN = year;

            switch (month)
            {
                // Những tháng mà tháng trước đó có có 30 ngày
                case 1:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day == 1)
                    {
                        dayN = 30;
                        if (month == 1)
                        {
                            monthN = 12;
                            yearN -= 1;
                        }
                        else
                            monthN -= 1;
                    }
                    else
                        dayN -= 1;
                    break;
                // Tháng trước của tháng 3 là tháng 2
                case 3:
                    if (day == 1)
                    {
                        if (isLeapYear)
                            dayN = 29;
                        else
                            dayN = 28;
                        monthN -= 1;
                    }
                    else
                        dayN -= 1;
                    break;
                // Những tháng mà tháng trước đó có có 31 ngày
                default:
                    if (day == 1)
                    {
                        dayN = 31;
                        monthN -= 1;
                    }
                    else
                        dayN -= 1;
                    break;
            }

            Console.WriteLine("\t=> Ngày kế trước: {0}/{1}/{2}", dayN, monthN, yearN);

            Console.ReadKey();
        }
    }
}
