using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

//8.Viết chương trình nhập vào chiều dài 2 cạnh của 1 hình chữ nhật, sau đó vẽ hình 
//chữ nhật này trên màn hình bằng các dấu * theo hai cách khác nhau tuỳ vào chọn 
//lựa của người dùng. Ví dụ: dài 7, rộng 4.
//******* hoặc *******
//*******      *     *
//*******      *     *
//*******      *******

namespace BaiTap3
{
    internal class Bai8
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int length, width;
            do
            {
                Console.Write("Nhập chiều dài: ( > 0): ");
                length = int.Parse(Console.ReadLine());
                Console.Write("Nhập chiều rộng: ( > 0): ");
                width = int.Parse(Console.ReadLine());
                if (width <= 0 || length <= 0)
                    Console.WriteLine("Không hợp lệ!");
            } while (width <= 0 || length <= 0);


            byte choose = 0;
            do
            {
                Console.Write("Nhập lựa chọn (1 hoặc 2): ");
                choose = byte.Parse(Console.ReadLine());
                if (choose <= 0 || choose > 2)
                    Console.WriteLine("\tKhông hợp lệ");
            } while (choose <= 0 || choose > 2);

            int min = Math.Min(length, width);
            int max = Math.Max(length, width);

            if (choose == 1)
            {
                for (int i = 0; i < min; i++)
                {
                    for (int j = 0; j < max; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < min; i++)
                {
                    for (int j = 0; j < max; j++)
                    {
                        if (i == 0 || i == min - 1)
                            Console.Write("*");
                        else
                        {
                            if (j > 0 && j < max - 1)
                                Console.Write(" ");
                            else
                                Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
