using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petya_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text1 = Console.ReadLine();
            string tex = text1.ToLower();
            string text2 = Console.ReadLine();
            string tex1 = text2.ToLower();

            if (tex == tex1)
                Console.WriteLine("0");
            else if (tex.CompareTo(tex1) < 1) 
                Console.WriteLine("-1");
            else
                Console.WriteLine("1");

        }
    }
}