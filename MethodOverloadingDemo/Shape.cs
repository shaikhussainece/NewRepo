using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingDemo
{
   abstract class Shape
    {
        protected int side1;
        protected double area;
        public virtual void DisplayArea()
        {
            Console.WriteLine("Area = " + area);

        }
        public abstract void ComputeArea();
    }
    //-----------------------
    class Rectangle : Shape
    {
        int side2;
        public  override void DisplayArea()
        {
            Console.WriteLine("area of rectangle =" + area);
        }
        public void AcceptSideValues()
        {
            Console.WriteLine("enter length =");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Breadth=");
            side2 = Convert.ToInt32(Console.ReadLine());
        }

        public override void ComputeArea()
        {
            area = side1 * side2;

        }
    }
    //--------------------------------------
    class Circle : Shape
    {
        
        public void AcceptRadius()
        {
            Console.WriteLine("enter radius = ");
                side1 = Convert.ToInt32(Console.ReadLine());
        }
        public override void ComputeArea()
        {
            area = 3.14 * side1 * side1;
        }
    }
}
