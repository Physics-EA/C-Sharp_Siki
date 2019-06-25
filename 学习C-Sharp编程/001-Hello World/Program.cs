using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Console.WriteLine("Hello World");
            //            Console.WriteLine(@"dsf fdf fds]\
            //dsf \fdsa\""");
            //            //Console.ReadKey();
            //            int num = 12321;
            //            num.ToString();
            string word = "2sdfsdf";

            //byte myMyte = 123;
            //int myInt = myMyte;
            //myMyte = (byte)myInt;
            string[] wordSingle = word.Split('s');
            for (int i = 0; i < wordSingle.Length; i++)
            {
                Console.WriteLine(wordSingle[i]);
            }
            Console.ReadKey();

        }
    }
}
