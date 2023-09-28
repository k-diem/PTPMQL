using System;
using System.Security.AccessControl;
namespace NewApp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public void EnterData()
        {
            System.Console.Write("Full Name = ");
            FullName = Console.ReadLine();
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
            System.Console.Write("Age = ");
            try{
                //cau lenh co the xay ra ngoai le
                Age = Convert.ToInt16(Console.ReadLine());
            }catch(Exception e)
            {
                //cau lenh xu ly ngoai le
                Age = 0;
            }
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", FullName, Address, Age);
        }
    }
}