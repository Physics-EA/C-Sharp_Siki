using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_异常处理_案例2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            while (true)
            {
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("输入的字符有误");
                }
            }
            while (true)
            {
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("输入的字符有误");
                }
            }

            int sum = num1 + num2;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
  



    }
}

