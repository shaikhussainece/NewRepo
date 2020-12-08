using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingDemo
{
    class InheritanceDemo
    {
        static void Main()
        {
            Console.WriteLine("for Rectangle");
            Rectangle r = new Rectangle();
            r.AcceptSideValues();
            r.ComputeArea();
            r.DisplayArea();

            Console.WriteLine("for circle");
            Circle c = new Circle();
            c.AcceptRadius();
            c.ComputeArea();
            c.DisplayArea();
            Console.ReadLine();

        }
    }
}
