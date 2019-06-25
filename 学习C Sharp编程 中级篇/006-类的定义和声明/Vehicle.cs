using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_类的定义和声明
{
    class Vehicle
    {
        public float speed;
        public float maxSpeed;
        public float weight;

        public void Run()
        {
            Console.WriteLine("速度为："+speed);
        }

        public void Stop()
        {
            speed = 0;
            Console.WriteLine("车辆停止");
        }

            
    }
}
