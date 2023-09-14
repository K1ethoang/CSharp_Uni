using System;
using System.Text;

namespace BaiTap2
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            const int DONGIA = 350000;
            Console.WriteLine("Nhap so thung son:");

            string sTam = Console.ReadLine();
            int iSoThungSon = Convert.ToInt32(sTam);

            int iSoNonDuocTang = iSoThungSon / 3;

            int iSoThungSonTangViet = iSoThungSon % 3;
            int iSoVietDuocTang = iSoThungSonTangViet * 2;

            int iTienTra = iSoThungSon * DONGIA;

            Console.WriteLine("So tien: {0}", iTienTra);
            Console.WriteLine("So non duoc tang: {0}", iSoNonDuocTang);
            Console.WriteLine("So viet duoc tang: {0}", iSoVietDuocTang);
        }
    }
}
