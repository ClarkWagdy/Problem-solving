using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sereja_and_Dima
{
    class Program
    {
        static void Main(string[] args)
        {
            int se=0,di=0, swap,num = Int32.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int[] arr = new int[num];
            string[] numper = line.Split(' ');
            for (int i = 0; i < num; i++)
                arr[i] = Int32.Parse(numper[i]);

            for(int x=0;x<num;x++)
                for (int y = x+1; y < num; y++)
                    if(arr[x]<arr[y])
                    {
                        swap = arr[y];
                        arr[y] = arr[x];
                        arr[x] = swap;
                    }
            for (int s = 0; s < num; s = s + 2)
                se =se+ arr[s];
            for (int d = 1; d < num; d = d + 2)
                di= di + arr[d];
            for (int p = 0; p < num; p++)
                Console.WriteLine(arr[p]);
            Console.WriteLine(se+" "+di);

        }
    }
}
