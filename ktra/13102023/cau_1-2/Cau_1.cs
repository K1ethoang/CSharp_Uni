using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_1_2
{
    internal class Cau_1
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = Encoding.UTF8;

            int h;

            do
            {
                Console.Write("Nhập h (h > 0): ");
                h = int.Parse(Console.ReadLine());

                if (h <= 0)
                    Console.WriteLine("\tNhập lại!");
            } while (h <= 0);


            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= h * 2 - 1; j++)
                {
                    if (j <= h)
                    {
                        if (i == j || j == 1 || i == h || j == h)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    else if (j > h)
                    {
                        if (i == 1)
                        {
                            Console.Write("* ");
                        }
                        else if (h + i - 1 == j)
                        {
                            Console.Write("* ");
                        }
                        else if (j == h*2-1)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }

                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
