using System;
using System.Text;

// 7. Viết chương trình nhập vào điểm ba môn Toán, Lý, Hóa của một học sinh. In ra điểm trung bình của học sinh đó với hai số lẻ thập phân.

namespace BaiTap1
{
    internal class Bai7
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            float toan, ly, hoa;

            do
            {
                Console.Write("Nhập điểm toán (1 <= toán <= 10): ");
                toan = float.Parse(Console.ReadLine());
                Console.Write("Nhập điểm lý (1 <= lý <= 10): ");
                ly = float.Parse(Console.ReadLine());
                Console.Write("Nhập điểm hoá (1 <= hoá <= 10): ");
                hoa = float.Parse(Console.ReadLine());
                if (toan < 1 || toan > 10 || ly < 1 || ly > 10 || hoa < 1 || hoa > 10)
                    Console.WriteLine("\tĐiểm không hợp lệ!\n");
            } while (toan < 1 || toan > 10 || ly < 1 || ly > 10 || hoa < 1 || hoa > 10);

            float diemtb = (toan + ly + hoa) / 3;

            string diemtbFormat = diemtb.ToString("F2");


            Console.WriteLine("Điểm trung bình: {0}", diemtbFormat);

            Console.ReadKey();

        }

    }
}
