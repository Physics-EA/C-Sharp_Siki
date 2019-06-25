using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_类的定义和声明
{
    public class Vector3
    {
        //习惯上将字段设为private，只是一种编程规范。只可以在该类内部访问，不可以通过对象访问。
        private float x;
        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public float Area { get; set; }
        private float y;
        public void SetY(float y)
        {
            this.y = y;
        }
        private float z;
        public void SetZ(float z)
        {
            this.z = z;
        }
        public float length;


        public Vector3()
        {
            Console.WriteLine("Vector3这个构造函数被调用了");
        }
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            length = Length();
        }
        public float Length()
        {
            double res = Math.Sqrt(x * x + y * y + z * z);
            return (float)res;
        }
    }
}
