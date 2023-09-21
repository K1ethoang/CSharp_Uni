using System;
using System.Text;

namespace BaiTap2
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            string strTenHang;
            Console.Write("Nhap ten hang: ");
            strTenHang = Console.ReadLine();
            Console.Write("Nhap so luong hang: ");
            string strTam;
            strTam = Console.ReadLine();
            int iSoLuong = Convert.ToInt32(strTam);
            Console.Write("Nhap vao don gia: ");
            strTam = Console.ReadLine();
            int iDonGia = Convert.ToInt32(strTam);
            int iThanhTien = iSoLuong * iDonGia;
            int iThueVAT = iThanhTien * 10 / 100;
            int iThucTra = iThanhTien + iThueVAT;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ten hang: {0}", strTenHang);
            Console.WriteLine("So luong hang: {0}", iSoLuong);
            Console.WriteLine("Don gia: {0}", iDonGia);
            Console.WriteLine("Thanh Tien: {0}", iThanhTien);
            Console.WriteLine("Thue VAT: {0}", iThueVAT);
            Console.WriteLine("Thuc Tra: {0}", iThucTra);
            Console.WriteLine("--------------------------");
            Console.ReadLine();
        }
    }
}
