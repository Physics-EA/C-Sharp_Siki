using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_面向对象编程_类
{
    class Customer
    {
        public string name;
        public string address;
        public int age;
        public string buyTime;

        public void Show()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(address);
            Console.WriteLine(buyTime);
        }
    }
}
