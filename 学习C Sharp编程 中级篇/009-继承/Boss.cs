using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_继承
{
    class Boss : Enemy
    {
        public  void AI()
        {
            
        }
        public override void Attack()
        {
            //base.Attack();
            Console.WriteLine("这里是Boss的Attack");
        }
    }
}
