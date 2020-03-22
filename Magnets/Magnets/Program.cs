using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magnets
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=1, num = Int32.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int j = 0; j < num; j++)
                arr[j] = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < num - 1; i++)
                if (arr[i] != arr[i + 1])
                {
                    count++;
                }
            Console.WriteLine(count);

        }
    }
}
