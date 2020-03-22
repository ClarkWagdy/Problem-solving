using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bear_and_Big_Brother
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
            while(numbers[0]<=numbers[1])
            {
                numbers[0] = 3 * numbers[0];
                numbers[1] = 2 * numbers[1];
                count++;
            }

            Console.WriteLine(count);
            
        }
    }
}
