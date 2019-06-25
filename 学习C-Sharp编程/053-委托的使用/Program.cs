using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_委托的使用
{
    //委托类似Struct和Enum，都是定义一个新的类型。使用也是用这个类型声明出来一个变量再使用。
    public delegate double MyDelegate(double param1, double param2);
    enum MyEnum
    {

    }
    struct MyStruct
    {
        string name;
        int age;
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate delegate1;
            delegate1 = Multiply;
             double result = delegate1(2, 4);
            //Console.WriteLine(result);
            delegate1 += Divide;             
            Console.WriteLine(delegate1(9, 3));
            Console.ReadKey(); 
        }

        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }
        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }
    }


}
