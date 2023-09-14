using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 9. Nhập vào một ngày (ngày, tháng, năm). Tìm ngày kế sau ngày vừa nhập (ngày / tháng / năm).

namespace BaiTap2
{
    internal class Bai9
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

            switch (day)
            {
                case 28:
                    if (isLeapYear && month == 2)
                        dayN += 1;
                    else
                    {
                        if (month == 2)
                        {
                            dayN = 1;
                            monthN += 1;
                        }
                        else if (month >= 1 && month <= 12)
                            dayN += 1;
                    }
                    break;
                case 29:
                    if (isLeapYear && month == 2)
                    {
                        dayN = 1;
                        monthN += 1;
                    }
                    else
                        dayN += 1;
                    break;
                case 30:
                    dayN += 1;
                    break;
                case 31:
                    dayN = 1;
                    if (month >= 1 && month <= 11)
                        monthN += 1;
                    else
                    {
                        monthN = 1;
                        yearN += 1;
                    }
                    break;
                default:
                    dayN += 1;
                    break;
            }

            Console.WriteLine("\t=> Ngày kế sau: {0}/{1}/{2}", dayN, monthN, yearN);

            Console.ReadKey();
        }
    }
}
