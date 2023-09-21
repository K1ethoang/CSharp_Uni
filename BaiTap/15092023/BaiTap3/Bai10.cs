using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

//10.Viết chương trình thực hiện Game đoán số như sau:
//Máy lấy ra một số ngẫu nhiên n ∈ [1,100] là số của máy (sử dụng hàm 
//random).
//− Người chơi nhập vào một số:
//• Nếu Số người chơi lớn hơn số của mày thì thông báo “Số bạn lớn hơn 
//số máy”.
//• Nếu Số ngươi chơi nhỏ hơn số của máy thì thông báo “Số bạn nhỏ hơn 
//số máy”.
//− Trò chơi kết thúc khi:
//• Hoặc người chơi đã đoán trúng: Thông báo “Ha ha bạn tài thật” tô màu 
//đỏ.
//• Hoặc người chơi đã đoán sai 7 lần: Thông báo “Bạn đã thua rồi” và 
//hiển thị số của máy.

namespace BaiTap3
{
    internal class Bai7
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int secretNumber = new Random().Next(1, 100);

            int time = 7;

            int result;
            do
            {
                Console.Write("[{0} lượt] Đoán số trong khoảng [1;100]: ", time);
                result = int.Parse(Console.ReadLine());

                if (result > secretNumber)
                    Console.WriteLine("\tSố bạn lớn hơn số máy");
                else if(result < secretNumber)
                    Console.WriteLine("\tSố bạn nhỏ hơn số máy");
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\tHa ha bạn tài thật");
                    Console.ResetColor();
                    break;
                }
                time--;
            }
            while (time > 0);

            if (time == 0)
                Console.WriteLine("\n\tBạn đã thua rồi\n\tĐáp án: {0}", result);
        }
    }
}
