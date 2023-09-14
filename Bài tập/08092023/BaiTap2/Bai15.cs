using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


//15.Hãy viết chương trình đọc vào một số nguyên.
//a. Tính và in ra cho biết số nguyên đó có bao nhiêu chữ số.
//Ví dụ:
//Hay nhap 1 so nguyen: 1462
//So nay co: 4 chu so
//b. Tính và in ra tổng các chữ số của số nguyên này.
//Ví dụ:
//Hay nhap 1 so nguyen: 2872
//Tong cac chu so cua 2872 la: 2 + 8 + 7 + 2 = 19
//c.Tính và in ra số nguyên có các chữ số có thứ tự ngược với các chữ số của số
//ban đầu.
//d. Một số nguyên dương gọi là đối xứng nếu đọc từ trái qua hay từ phải lại đều
//giống nhau. Ví dụ các số sau đây là đối xứng: 12321, 9999, 55355,... Hãy
//viết chương trình đọc vào một số nguyên dương và in ra thông báo cho biết số
//này có đối xứng không. (đối xứng nếu số đó và số đảo ngược của nó bằng
//nhau)

namespace BaiTap2
{
    internal class Bai15
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;

            Console.Write("Nhập số nguyên n: ");
            n = int.Parse(Console.ReadLine());

            string sN = Convert.ToString(n);

            // a
            Console.WriteLine("\nSố này có: {0} chữ số", sN.Length);

            // b
            string sRes2 = "";
            int total = 0;
            foreach (char c in sN)
            {
                sRes2 += c + " + ";
                total += c - '0';
            }

            sRes2 = sRes2.Substring(0, sRes2.Length - 3);

            Console.WriteLine("\nTổng các chữ số của {0} là: {1} = {2}", n, sRes2, total);

            // c
            string sRes3 = sN;
            char[] charString = sRes3.ToCharArray();
            Array.Reverse(charString);
            sRes3 = new string(charString);

            Console.WriteLine("\nThứ tự ngược: " + sRes3);

            // d
            if (sRes3 == sN)
                Console.WriteLine("\nĐối xứng");
            else
                Console.WriteLine("\nKhông đối xứng");


            Console.ReadKey();
        }
    }
}
