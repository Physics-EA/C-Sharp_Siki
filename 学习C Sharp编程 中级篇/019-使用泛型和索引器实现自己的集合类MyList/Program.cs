using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_使用泛型和索引器实现自己的集合类MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>();
            myList.Add(213);
            myList.Add(23);
            myList.Add(24);
            myList.Add(274);

            myList[0] = 100;
            myList.Insert(3, 99);
            myList.RemoveAt(1); 
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine(myList.IndexOf(274));

            myList.Sort();
            Console.WriteLine();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.ReadKey();
        }
    }
}
