using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_面向对象编程_类
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cus = new Customer();
            cus.name = "xingjiaming";
            cus.age = 29;
            cus.address = "shanghai";
            cus.buyTime = "20190909";

            cus.Show();
            Console.ReadKey();
        }
    }
}
