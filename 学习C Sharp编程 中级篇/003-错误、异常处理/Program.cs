using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_错误_异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myArray = { 1, 2, 3, 4 };
                int myEle = myArray[4];
            }
            catch //(NullReferenceException e)
            {
                Console.WriteLine("发生了异常： IndexOutOfRangeException");
            }
            finally
            {
                Console.WriteLine("这里是finally执行的代码");
            }
            Console.WriteLine("test");
            Console.ReadKey();

        }
    }
}
