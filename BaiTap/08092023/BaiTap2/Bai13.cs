using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//13.Viết chương trình nhập họ tên, số ngày làm việc và số giờ làm việc ngoài giờ trong
//tháng của một nhân viên. Sau đó in lên màn hình phiếu báo lương chi tiết có dạng
//như bên dưới. Biết rằng ngày làm việc 8 tiếng. Công ty trả 70,000 đồng/1 giờ làm
//việc. Công ty phải trả thêm 30% cho mỗi giờ làm việc ngoài giờ của nhân viên.
//Nếu nhân viên đi làm ít hơn 20 ngày trong tháng thì sẽ bị ghi "Kỹ luật" trong phần
//ghi chú:
//----------------------------------------
//Phiếu báo lương chi tiết
//Nhân viên: < họ tên >
//Ngày công: < số ngày làm việc >
//Làm việc ngoài giờ: < số giờ làm việc ngoài giờ >
//Lương: < Số tiền >
//Ghi chú: < Để trống hoặc "Kỹ luật">
//------------------------------------------

namespace BaiTap2
{
    internal class Bai13
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Họ tên: ");
            string name = Console.ReadLine();
            Console.Write("Số ngày làm việc: ");
            byte dayWork = byte.Parse(Console.ReadLine());
            Console.Write("Số giờ làm việc ngoài giờ: ");
            float overtime = float.Parse(Console.ReadLine());

            const float SALARY_BASE = 70000;

            float salary = dayWork * 8 * SALARY_BASE + overtime * SALARY_BASE * 30 / 100;

            string formatSalary = salary.ToString("C0");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Phiếu báo lương chi tiết");
            Console.WriteLine("Nhân viên: " + name);
            Console.WriteLine("Ngày công: " + dayWork);
            Console.WriteLine("Làm việc ngoài giờ: {0} (h)", overtime);
            Console.WriteLine("Lương: " + formatSalary);
            Console.WriteLine("Ghi chú: " + (dayWork < 20 ? "Kỹ luật" : ""));
            Console.WriteLine("----------------------------------------");

            Console.ReadKey();
        }
    }
}
