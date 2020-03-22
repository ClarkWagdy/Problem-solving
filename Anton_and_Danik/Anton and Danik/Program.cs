using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anton_and_Danik
{
    class Program
    {
        static void Main(string[] args)
        {
            int A=0, D = 0;
            int n= Convert.ToInt32(Console.ReadLine());
            char[] arr = new Char[n];
            arr = Console.ReadLine().ToCharArray();
            foreach (char a in arr)
            {
                if (a == 'A')
                    A++;
                else
                    D++;
            }
            if (A>D)

                Console.WriteLine("Anton");
            else if (A<D)
                Console.WriteLine("Danik");
            else
                Console.WriteLine("Friendship");
        }
    }
}
