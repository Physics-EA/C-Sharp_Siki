using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enemy enemy =new Boss();
            //Boss boss = (Boss)enemy;
            //boss.AI();

            Boss boss = new Boss();
            boss.Attack();
            Console.ReadKey();
            
        }
    }
}
