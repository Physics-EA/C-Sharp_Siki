using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _016_列表的属性和方法;

namespace _017_泛型类_泛型方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //var o1 = new ClassA<int>(23, 34);//当我们利用泛型类构造的时候，需要制定泛型的类型。
            //string s = o1.GetSum();


            //var o2 = new ClassA<string>("dsf", "er");
            //string s = o2.GetSum();
            //Console.WriteLine(s);


            Console.WriteLine(GetSum<int>(12, 23));
            Console.WriteLine(GetSum(12.3, 45.324));
            Console.WriteLine(GetSum("sdf3", "dsfa"));
            Console.ReadKey();
        }

        public static string GetSum<T>(T a, T b)
        {
            return a + " " + b;
        }


    }
}
