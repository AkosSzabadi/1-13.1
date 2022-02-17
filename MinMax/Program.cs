using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1000;
            int max = -1;
            int minIdx = 0;
            int maxIdx = 0;

            Random rnd = new Random();
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rnd.Next(max,min);
            }
            for (int i = 0; i < 30; ++i) 
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIdx = i;
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIdx = i;
                }

            }
            Console.WriteLine("Minimum {0}, index {1}", min, minIdx);
            Console.WriteLine("Maximum {0}, index {1}", max, maxIdx);
            Console.ReadKey();
        }
    }
}
