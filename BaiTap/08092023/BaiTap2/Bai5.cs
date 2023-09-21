using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nhập vào số giây t bất kỳ >=0. Tính và xuất ra dạng Giờ:Phút:Giây

namespace BaiTap2
{
    internal class Bai5
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int second;

            do
            {
                Console.Write("Nhập số giây (>= 0): ");
                second = int.Parse(Console.ReadLine());

                if (second < 0)
                    Console.WriteLine("\tNhập lại\n");
            } while (second < 0);

            const int MINUTE = 60;
            const int HOUR = MINUTE * 60;

            int h = second / HOUR;
            second %= HOUR;
            int m = second / MINUTE;
            second %= MINUTE;
            int s = second;

            string mer;

            if (h < 12)
                mer = "AM";
            else
            {
                h %= 12;
                mer = "PM";
            }

            Console.WriteLine("{0}:{1}:{2} {3}", h, m, s, mer);

            Console.ReadKey();
        }
    }
}
