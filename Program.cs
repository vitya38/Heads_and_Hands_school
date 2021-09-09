using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heads_and_hands_school
{   

    class Program
    {
        static int[][] function(int n)
        {
            int[][] array = new int[n][];
            int[] used = new int[n];
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < n; i++)
            {
                int m = rnd.Next(10000);
                while (used.Contains(m))
                    m = rnd.Next(10000);
                used[i] = m;
                array[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    array[i][j] = rnd.Next();
                }
            }
            for (int i = 0; i < n; i++)
            {
                Array.Sort(array[i]);
                if (i % 2 == 1)
                    Array.Reverse(array[i]);
            }
            return array;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] array = function(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array[i].Count(); j++)
                {
                    Console.Write(array[i][j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
