using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Console_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
         
            //初期配列
            int[] data1 = new int[n];

            for (var i = 0; i < n; i++)
            {
                data1[i] = i + 1;
            }
            foreach (int data in data1)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("\n");

            var ran = new Random();

            for (var i = 0; i < n; i++)
            {
                int r = ran.Next(0, n - 1);
                int t = 0;

                t = data1[i];
                data1[i] = data1[r];
                data1[r] = t;
                
            }

            foreach (int data in data1)
            {
                Console.WriteLine(data);
            }




            Console.ReadKey();
        }
    }
}
