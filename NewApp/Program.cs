using System;
using System.Collections;
namespace NewApp.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách các đối tượng Person
            var psList = new List<Person>();

            for (int i = 0; i < 2; i++)
            {
                Person ps = new Person();
                ps.NhapThongTin();
                psList.Add(ps);
            }

            foreach (Person p in psList)
            {
                Console.WriteLine(p.PersonID + "-" + p.FullName);
            }
            //them mot doi tuong ps vao danh sach
            for (int i = 0; i < 2; i++)
            {
                Person ps = new Person();
                ps.NhapThongTin();
                psList.Add(ps);
            }
            //sua mot doi tuong trong danh sach
            int indexToEdit = 0; // chi muc cua phan tu duoc sua doi
            psList[indexToEdit].NhapThongTin(); // sua doi thong tin cua phan tu
            //xoa mot phan tu trong danh sach
            int indexToRemove = 1; // chi muc can xoa
            psList.RemoveAt(indexToRemove); // xoa phan tu chi muc da chon



        }
    }


}
