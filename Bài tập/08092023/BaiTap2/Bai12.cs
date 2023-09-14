using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12.Nhập vào số kWh tiêu thụ điện. Tính tiền điện phải trả biết rằng cách thức tính tiền
//theo quy định như sau:
//▪ 100 kWh định mức đầu tiên có đơn giá trung bình là 600 VNĐ/kWh
//▪ Các kWh từ 101 đến 150 có đơn giá là 700 VNĐ/kWh
//▪ Các kWh từ 151 đến 200 có đơn giá là 900 VNĐ/kWh

//▪ Các kWh từ 201 trở đi có đơn giá là 1100 VNĐ/kWh

namespace BaiTap2
{
    internal class Bai12
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int vol;

            do
            {
                Console.Write("Nhập số kWh tiêu thụ (> 0): ");
                vol = int.Parse(Console.ReadLine());

                if (vol <= 0)
                    Console.WriteLine("\tKhông hợp lệ!");
            } while (vol <= 0);


            int tempVol = vol;

            double totalPrice;

            if (tempVol <= 100)
                totalPrice = tempVol * 600;
            else if (tempVol <= 150)
                totalPrice = 100 * 600 + (tempVol - 100) * 700;
            else if (tempVol <= 200)
                totalPrice = 100 * 600 + 50 * 700 + (tempVol - 150) * 900;
            else
                totalPrice = 100 * 600 + 50 * 700 + 50 * 900 + (tempVol - 200) * 1100;

            Console.WriteLine("Tổng tiền: {0} VNĐ", totalPrice);

            Console.ReadKey();
        }
    }
}
