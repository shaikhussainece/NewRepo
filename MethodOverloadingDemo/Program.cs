using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingDemo
{
    class Program
    {
        
            static void Dispaly(int i)
        {
            Console.WriteLine("Integer =" + i);
        }
        static void Dispaly(String s)
        {
            Console.WriteLine("String =" + s);
        }
        static void Display(int i, int j)
        {
            Console.WriteLine("sum =" + (i + j));
        }


        static void Main(string[] args)

        {
            Display("abc");
            Display(3);
            Display(3, 4);
            Console.ReadLine();
        }
    }
}
