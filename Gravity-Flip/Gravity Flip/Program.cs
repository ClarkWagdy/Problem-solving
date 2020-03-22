using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravity_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            
            int[] arr = new int[num];
            string number = Console.ReadLine();
            string[] line = number.Split(' ');
            for(int i=0;i<num;i++)
                arr[i]= Int32.Parse(line[i]);

            int temp;
            for (int j = 0; j < num; j++)
            {
                for (int x = j+1; x < num; x++)
                {
                    if (arr[j] > arr[x])
                    {
                        temp = arr[x];
                        arr[x] = arr[j];
                        arr[j] = temp;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            for (int w = 0; w < num; w++)
                Console.Write(arr[w]+" ");

        }
    }
}
