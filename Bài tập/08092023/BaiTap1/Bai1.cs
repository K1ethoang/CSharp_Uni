using System;
using System.Text;

// 1. In ra chữ số hàng trăm, hàng chục, hàng đơn vị của một số có ba chữ số. Ví dụ khi nhập số 365 thì in ra: Chữ số hàng trăm: 3, hàng chục: 6, hàng đơn vị: 5

namespace BaiTap1
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;

            do
            {
                Console.Write("Nhập số nguyên có 3 chữ số: ");
                n = int.Parse(Console.ReadLine());
                if (n < 100 || n > 999)
                    Console.WriteLine("\nNhập không hợp lệ!");
            } while (n < 100 || n > 999);

            int c = n % 10;
            n /= 10;
            int b = n % 10;
            n /= 10;
            int a = n % 10;

            Console.WriteLine("Chữ số hàng trăm: {0}, hàng chục: {1}, hàng đơn vị: {2}", a, b, c);

            Console.ReadKey();
        }
    }
}
