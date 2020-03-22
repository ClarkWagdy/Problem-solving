using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] arr = new int[2];
            int[,] matrix = new int[5,5];
            string[] line = new string[5];
            for (int i = 0; i < 5; i++)
            {
                line[i] = Console.ReadLine();
                string []number = line[i].Split(' ');
                for (int j = 0; j < 5; j++)
                    matrix[i, j] = Int32.Parse(number[j]);
            }



            for (int c = 0; c < 5; c++)
                for (int v = 0; v < 5; v++)
                    if (matrix[c,v]==1)
                    {
                        arr[0] = c;
                        arr[1] = v;
                    }

            while (arr[0] > 2)
            {
                arr[0] = arr[0] - 1;
                count++;
            }
            while (arr[0] < 2)
            {
                arr[0] = arr[0] + 1;
                count++;
            }
            while (arr[1] > 2)
            {
                arr[1] = arr[1] - 1;
                count++;
            }
            while (arr[1] < 2)
            {
                arr[1] = arr[1] + 1;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
