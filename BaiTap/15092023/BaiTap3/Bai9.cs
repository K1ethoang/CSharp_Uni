using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// 9. Viết chương trình cho nhập vào một số nguyên dương h, in ra các mẫu hình sau 
//ứng với chiều cao h (dùng ký tự ‘*’ và ký tự khoảng trống). Ví dụ với h = 4

namespace BaiTap3
{
    internal class Bai9
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int h;
            do
            {
                Console.Write("Nhập chiều cao: ( > 0): ");
                h = int.Parse(Console.ReadLine());
                if (h <= 0)
                    Console.WriteLine("Không hợp lệ!");
            } while (h <= 0);

            shape_1(h);
            Console.WriteLine();
            shape_2(h);
            Console.WriteLine();
            shape_3(h);
            Console.WriteLine();
            shape_4(h);
            Console.WriteLine();
            shape_5(h);
            Console.WriteLine();
            shape_6(h);
            Console.WriteLine();
            shape_7(h);
            Console.WriteLine();
            shape_8(h);
            Console.WriteLine();
            shape_9(h);
            Console.WriteLine();
            shape_10(h);
            Console.WriteLine();
            shape_11(h);
            Console.WriteLine();
            shape_12(h);
            Console.WriteLine();
            shape_13(h);
            Console.WriteLine();
            shape_14(h);
            Console.WriteLine();
            shape_15(h);

            Console.ReadKey();
        }

        static void shape_1(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (j <= i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void shape_2(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (j >= h - i - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void shape_3(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (j >= i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void shape_4(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (j >= h - i)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void shape_5(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h * 2; j++)
                {
                    if (j > h - i - 1 && j <= h + i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void shape_6(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void shape_7(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (i == 0 || i == h - 1)
                        Console.Write("* ");
                    else
                    {
                        if (j > 0 && j < h - 1)
                            Console.Write("  ");
                        else
                            Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void shape_8(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (j <= i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        static void shape_9(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (j == 0 || j == i || i == h - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        static void shape_10(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (j < h - i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        static void shape_11(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (j == 0 || i == 0 || j == h - i - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        static void shape_12(int h)
        {
            for (int i = 0; i < h * 2 - 1; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    // Nửa trên
                    if (i < h)
                    {
                        if (j <= i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    // Nửa dưới
                    else
                    {
                        if (j > i - h)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void shape_13(int h)
        {
            for (int i = 0; i < h * 2 - 1; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    // Nửa trên
                    if (i < h)
                    {
                        if (j == 0 || j == i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    // Nửa dưới
                    else
                    {
                        if (j == i - h + 1 || j == h - 1)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
        }

        static void shape_14(int h)
        {
            for (int i = 0; i < h * 2 - 1; i++)
            {
                for (int j = 0; j < h * 2; j++)
                {
                    // Nửa trên
                    if (i < h - 1)
                    {
                        if (j <= i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    // Giữa
                    else if (i == h - 1)
                    {
                        Console.Write("* ");
                    }
                    // Nửa dưới
                    else
                    {
                        if (j > i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void shape_15(int h)
        {
            for (int i = 0; i < h * 2 - 1; i++)
            {
                for (int j = 0; j < h * 2; j++)
                {
                    // Nửa trên
                    if (i < h - 1)
                    {
                        if (j == 0 || j == i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    // Giữa
                    else if (i == h - 1)
                    {
                        Console.Write("* ");
                    }
                    // Nửa dưới
                    else
                    {
                        if (j == i +1|| j == h *2-1)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
