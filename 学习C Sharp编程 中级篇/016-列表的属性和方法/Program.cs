using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_列表的属性和方法
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> scoreList = new List<int>();
            scoreList.Add(100);
            scoreList.Add(200);
            scoreList.Add(300);

            scoreList.Insert(3, -1);
            scoreList.RemoveAt(1);
           
            Console.WriteLine(scoreList.IndexOf(100));
            for (int i = 0; i < scoreList.Count; i++)
            {
                Console.WriteLine(scoreList[i]);
            }
            Console.ReadKey();
        }
    }
}
