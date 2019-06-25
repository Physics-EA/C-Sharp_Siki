using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_递归函数
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = Sum(40);
            Console.WriteLine(res);
            Console.ReadKey();

        }

        public static int Sum(int param)
        {
            if (param == 0)
            {
                return 2;
            }
            if (param == 1)
            {
                return 3;
            }
            return Sum(param - 1) + Sum(param - 2);
        }
    }

}
