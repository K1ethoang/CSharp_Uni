using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// 7. Kiểm tra số nguyên dương n có phải là số không trọn vẹn (Deficient number) hay 
//không ? (Số không trọn vẹn là số có tổng các ước số của nó (không kể nó) thì nhỏ
//hơn nó. Vd: 9 có các ước số là 1, 3 và 9>1+3 ➔ 9 là số không trọn vẹn).

namespace BaiTap3
{
    internal class Bai7
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


            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }

            if (sum < n)
                Console.WriteLine("Là số không trọn vẹn");
            else
                Console.WriteLine("Là số trọn vẹn");
        }
    }
}
