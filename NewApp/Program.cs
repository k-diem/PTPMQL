using System;
using System.Collections;
namespace NewApp.Models // Tùy chọn: Định nghĩa một không gian tên (namespace)
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
        }
    }
}
