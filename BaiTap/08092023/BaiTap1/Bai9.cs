using System;
using System.Text;

//9.Viết chương trình nhập họ tên, chỉ số điện kế tháng trước, chỉ số điện kế tháng này của 1 khách thuê điện kế. Sau đó in lên màn hình hoá đơn tiền điện có dạng sau:
//----------------------------------------
//Hoá đơn tiền điện
//Khách hàng: < họ tên >
//Chỉ số cũ: < chỉ số cũ >
//Chỉ số mới: < chỉ số mới>
//Tiêu thụ: < chỉ số mới - chỉ số cũ >
//Tiền điện: < tiêu thụ * 452.45 >
//Tiết kiệm điện là quốc sách
//------------------------------------------

namespace BaiTap1
{
    internal class Bai9
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string name;
            int volPre, volNow;

            do
            {
                Console.Write("Nhập tên của bạn: ");
                name = Console.ReadLine();
                Console.Write("Chỉ số điện tháng trước (> 0): ");
                volPre = int.Parse(Console.ReadLine());
                Console.Write("Chỉ số điện tháng này (> 0): ");
                volNow = int.Parse(Console.ReadLine());
                if (volPre <= 0 || volNow <= 0)
                    Console.WriteLine("\tChỉ số điện không hợp lệ!\n");
                if (volNow < volPre)
                    Console.WriteLine("\tChỉ số điện tháng này phải >= tháng trước!\n");
            } while (volPre <= 0 || volNow <= 0 || volNow < volPre);

            int volUse = volNow - volPre;

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Hoá đơn tiền điện");
            Console.WriteLine("Khách hàng: " + name);
            Console.WriteLine("Chỉ số cũ: " + volPre);
            Console.WriteLine("Chỉ số mới: " + volNow);
            Console.WriteLine("Tiêu thụ: " + volUse);
            Console.WriteLine("Tiền điện: " + volUse * 452.45);
            Console.WriteLine("Tiết kiệm điện là quốc sách");
            Console.WriteLine("----------------------------------------");

            Console.ReadKey();

        }

    }
}
