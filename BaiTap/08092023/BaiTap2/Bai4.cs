using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tính chỉ số WHI (chỉ số vòng hông)

namespace BaiTap2
{
    internal class Bai4
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            float waist, hip;

            do
            {
                Console.Write("Nhập kích thước eo (> 0, đơn vị cm): ");
                waist = short.Parse(Console.ReadLine());
                Console.Write("Nhập kích thước hông (> 0, đơn vị cm): ");
                hip = float.Parse(Console.ReadLine());

                if (waist <= 0 || hip <= 0)
                    Console.WriteLine("\tNhập lại\n");
            } while (waist <= 0 || hip <= 0);

            float whi = (float)(Math.Round((waist / hip) * 100) / 100);

            string status;

            if (whi < 0.9)
                status = "Nguy cơ tiểu đường thấp";
            else
                status = "Khả năng tiểu đường lớn hơn 50%";

            Console.WriteLine("Tình trạng: " + status);

            Console.ReadKey();
        }
    }
}
