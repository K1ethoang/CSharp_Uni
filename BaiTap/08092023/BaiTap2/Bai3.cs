using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Viết chương trình tính chỉ số BMI của một người khi biết chiều cao và cân nặng. Biết rằng: BMI = Weight / (Height * Height)

namespace BaiTap2
{
    internal class Bai3
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            short heightCen;
            float weight;

            do
            {
                Console.Write("Nhập chiều cao (> 0, đơn vị cm): ");
                heightCen = short.Parse(Console.ReadLine());
                Console.Write("Nhập cân nặng (> 0, đơn vị kg): ");
                weight = float.Parse(Console.ReadLine());

                if (heightCen <= 0 || weight <= 0)
                    Console.WriteLine("\tNhập lại\n");
            } while (heightCen <= 0 || weight <= 0);

            float heightMet = heightCen / 100;

            float bmi = weight / (heightMet * heightMet);

            string status;

            if (bmi < 18.5)
                status = "Gầy";
            else if (bmi >= 18.5 && bmi <= 24.9)
                status = "Bình thường";
            else if (bmi >= 25 && bmi <= 29.9)
                status = "Mập";
            else
                status = "Béo phì";

            Console.WriteLine("Tình trạng: " + status);

            Console.ReadKey();
        }
    }
}
