using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_用递归函数求阶层
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.ReadKey();
        }

        static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return Factorial(num - 1) * num;
        }
    }
}
