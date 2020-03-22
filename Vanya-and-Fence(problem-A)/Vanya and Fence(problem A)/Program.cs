using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanya_and_Fence_problem_A_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] numbers = new int[2];
            string sline = Console.ReadLine();
            string[] snumbers = sline.Split(' ');
            for (int i = 0; i < 2; i++)
                numbers[i] = Int32.Parse(snumbers[i]);

            int[] arr = new int[numbers[0]];
            string line = Console.ReadLine();
            string[] snumber = line.Split(' ');
            for (int j = 0; j < numbers[0]; j++)
                arr[j] = Int32.Parse(snumber[j]);

            for (int n = 0; n < numbers[0]; n++)

            {
                if (arr[n] <= numbers[1])
                    count++;
                else
                    count = count + 2;

            }
            Console.WriteLine(count);



        }
    }
}
