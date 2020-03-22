using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boy_or_Girl
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            var name = new StringBuilder(Console.ReadLine());
            for (int n = 0; n < name.Length; n++)
                for (int i = 0; i < name.Length; i++)
                   for (int j = i + 1; j < name.Length; j++)
                   if (name[i] == name[j])
                    { 
                        name.Remove(j, 1);
                    }
            Console.WriteLine(name);
            Console.WriteLine(name.Length);
            
         if(name.Length%2==0)
          Console.WriteLine("CHAT WITH HER!");
          else
            Console.WriteLine("IGNORE HIM!");


        }
    }
}
