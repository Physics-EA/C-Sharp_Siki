using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_列表的属性和方法
{
    public class ClassA<T>
    {
        private T a;
        private T b;
        public ClassA(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public string GetSum()
        {
            return a + " " + b;
        }
    }
}
