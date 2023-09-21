using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 11. Nhập vào một ngày (ngày, tháng, năm). Cho biết ngày đó là ngày thứ bao nhiêu trong tuần.

namespace BaiTap2
{
    internal class Bai11
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            short day, month, year;

            bool isLeapYear;

            do
            {
                Console.Write("Nhập ngày (1 <= ngày <= 31): ");
                day = short.Parse(Console.ReadLine());
                Console.Write("Nhập tháng (1 <= tháng <= 12): ");
                month = short.Parse(Console.ReadLine());
                Console.Write("Nhập năm (1900 <= năm <= 2023): ");
                year = short.Parse(Console.ReadLine());

                isLeapYear = ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);

                if (day < 1 || day > 31 || (month == 2 && day >= 30) || (!isLeapYear && day == 29 && month == 2) || (day == 31 && (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)))
                    Console.WriteLine("\tNgày không hợp lệ\n");
                if (month < 1 || month > 12)
                    Console.WriteLine("\tTháng không hợp lệ\n");
                if (year < 1900 || year > 2023)
                    Console.WriteLine("\tNăm không hợp lệ\n");

            } while (day < 1 || day > 31 || month < 1 || month > 12 || year < 1900 || year > 2023 || (month == 2 && day >= 30) || (!isLeapYear && day == 29 && month == 2) || (day == 31 && (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)));

            DateTime date = new DateTime(year, month, day);

            byte NumberWeekDay = (byte)date.DayOfWeek;
            string weekDay = "";

            switch (NumberWeekDay)
            {
                case 0:
                    weekDay = "Chủ nhật";
                    break;
                case 1:
                    weekDay = "Thứ Hai";
                    break;
                case 2:
                    weekDay = "Thứ Ba";
                    break;
                case 3:
                    weekDay = "Thứ Tư";
                    break;
                case 4:
                    weekDay = "Thứ Năm";
                    break;
                case 5:
                    weekDay = "Thứ Sáu";
                    break;
                case 6:
                    weekDay = "Thứ Bảy";
                    break;
            }

            Console.WriteLine("\t=> Ngày {0}/{1}/{2}: {3}", day, month, year, weekDay);

            Console.ReadKey();
        }
    }
}
