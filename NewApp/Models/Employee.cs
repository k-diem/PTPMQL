using System;

namespace NewApp.Models
{
    public class Employee
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }

        public void NhapThongTin()
        {
            Console.WriteLine("Ma Nhan Vien: ");
            MaNhanVien = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ten Nhan Vien: ");
            TenNhanVien = Console.ReadLine();
            Console.WriteLine("Tuoi: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luong: ");
            Luong = Convert.ToInt32(Console.ReadLine());
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("{0} - {1} - {2} tuoi - {3} VND", MaNhanVien, TenNhanVien, Tuoi, Luong);
        }
    }
}
