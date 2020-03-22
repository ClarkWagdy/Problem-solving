using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int num = Int32.Parse(Console.ReadLine());
            string[] arr = new string[num];
            for (int i = 0; i < num; i++)
                arr[i] = Console.ReadLine();

            for (int j = 0; j < num; j++)
                for (int n = 1; n < num; n++)
                    if (arr[j] != arr[n])
                        count++;
                   // else
                       
            Console.WriteLine(count);


        }
    }
}
