using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_继承
{
    class Enemy
    {
        public virtual void Attack()
        {
            Console.WriteLine("这里是公有的Attack");
        }
    }
}
