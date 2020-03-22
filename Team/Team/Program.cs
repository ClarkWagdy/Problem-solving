using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0 ;
            int number = Int32.Parse(Console.ReadLine());
            int[,] num = new int[number, 3];
            string[] farr = new string[number];
            for (int c = 0; c < number; c++)
                farr[c] = Console.ReadLine();
            for (int x = 0; x < number; x++)
            {
                string[] snumber = farr[x].Split(' ');
                    for (int j = 0; j < 3; j++)
                        num[x, j] = Int32.Parse(snumber[j]);
                if ((num[x, 0] + num[x, 1] + num[x, 2]) >= 2)
                    count++;
            }    
            Console.WriteLine(count);
        } 
    }
}
