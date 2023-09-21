using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// 6. Đếm số lượng các chữ nguyên tố của số nguyên dương n

namespace BaiTap3
{
    internal class Bai6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            do
            {
                Console.Write("Nhập n ( > 0): ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Không hợp lệ!");
            } while (n <= 0);

            string strN = n.ToString();

            int count = 0;

            for (int i = 0; i < strN.Length; i++)
            {
                if (isPrime(strN[i] - '0'))
                    count++;
            }

            Console.WriteLine("Có {0} số nguyên tố", count);

            Console.ReadKey();
        }

        static bool isPrime(int n)
        {
            bool isPrime = true;

            if (n <= 1)
                return false;
            else if (n == 2)
                return true;
            else
            {
                if (n % 2 == 0)
                    return false;
                else
                {
                    for (int i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                            return false;
                    }
                }
            }


            return isPrime;
        }
    }
}
