using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingDemo
{
    class Time
    {
        public int hh, mm, ss;
        //operator Overloading;
        public static Time operator -(Time t1, Time t2)
        {
            Time t = new Time();
            t.hh = t1.hh - t2.hh;
            t.mm = t1.mm - t2.mm;
            t.ss = t1.ss - t2.ss;
            return t;
        }
    }

/-------------------------------

class OperaterOverLoading
    {
        static void Main()
        {
            Time startTiome = new Time();
            Time endTime = new Time();
            startTime.hh = 3;
            startTime.mm = 14;
            startTime.ss = 20;
            endTime.hh = 5;
            endTime.mm = 28;
            endTime.ss = 37;

            Time diffTime = endTime - startTime;
            Console.WriteLine("Time difference is {0}hours:{1}minutes:{2}seconds", diffTime.hh, diffTime.mm, diffTime.ss);
            Console.ReadLine();

        }
    }
}

