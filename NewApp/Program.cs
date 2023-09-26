using NewApp.Models;

public class Program
{
    public static void Main(string[] args)
    {
        // //Khoi tao 2 doi tuong thu class Person
        // Person ps1 = new Person();
        // Person ps2 = new Person();
        // //Gan gia tri cho thuoc tinh doi tuong ps1
        // ps1.FullName = "Nguyen Van A";
        // ps1.Address = "Ha Noi";
        // ps1.Age = 18;
        // //gan gia tri cho thuoc tinh doi tuong ps2
        // ps2.FullName = "Ho ten mac dinh";
        // ps2.Address = "Dia chi mac dinh";
        // ps2.Age = 20;
        // //goi phuong thuc hien thi thong tin
        // ps1.Display();
        // ps2.Display();

        //khoi tao 2 doi tuong tu class Employee
        Employee ep1 = new Employee();
        Employee ep2 = new Employee();
        //gan gia tri cho thuoc tinh doi tuong ep1
        ep1.MaNhanVien = 11;
        ep1.TenNhanVien = "Nguyen Van A";
        ep1.Tuoi = 30;
        ep1.Luong = 4000000;
        //goi phuong thuc hien thi thong tin
        ep1.HienThiThongTin();
    }
}
