using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_类的定义和声明
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle car1 = new Vehicle();
            //car1.speed = 100;
            //car1.Run();
            //car1.Stop();
            //Console.WriteLine(car1.speed);
            //Console.ReadKey();

            Vector3 v1 = new Vector3(1, 1, 1);
            v1.Area = 100;
            Console.WriteLine(v1.Area);


            v1.X = 20;
            Console.WriteLine(v1.X);
         
            //v1.SetX(1);
            //v1.SetY(1);
            //v1.SetZ(1);
            Console.WriteLine(v1.length);
            Console.ReadKey();
        }
    }
}
