using System;

namespace NewApp.Models
{
    public class Student : Person
    {
        public string StudentID { get; set; }
        public string Major { get; set; }

        public void NhapThongTinStudent()
        {
            NhapThongTin(); // Gọi phương thức NhapThongTin của lớp cha để nhập thông tin chung

            Console.WriteLine("Student ID: ");
            StudentID = Console.ReadLine();

            Console.WriteLine("Major: ");
            Major = Console.ReadLine();
        }
    }
}
