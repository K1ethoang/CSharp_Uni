using System;
using System.Runtime.InteropServices;
using System.Text;

// 8. Viết chương trình nhập vào tên, năm sinh 1 người bất kỳ. Sau đó in lên màn hình các kết quả sau: tên, năm sinh, tuổi hiện tại. Biết rằng ngày giờ hiện tại của máy được lấy như sau:

// DateTime thoiGianHienTai = DateTime.Now;
// int namHienTai = thoiGianHienTai.Year;

namespace BaiTap1
{
    internal class Bai8
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string name;
            int year;

            do
            {
                Console.Write("Nhập tên của bạn: ");
                name = Console.ReadLine();
                Console.Write("Nhập năm sinh (1900 <= năm sinh <= 2023): ");
                year = int.Parse(Console.ReadLine());
                if (year < 1990 || year > 2023)
                    Console.WriteLine("\tNăm sinh không hợp lệ!\n");
            } while (year < 1990 || year > 2023);

            DateTime dateTimeNow = DateTime.Now;
            int yearNow = dateTimeNow.Year;

            Console.WriteLine("Tên: {0}\nTuổi: {1}", name, yearNow - year);

            Console.ReadKey();

        }

    }
}
