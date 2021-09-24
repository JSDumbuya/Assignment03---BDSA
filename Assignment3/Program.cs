using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    class Program
    {
        IEnumerable<int>[] xs;
        int[] ys;

        delegate void TestDelegate(string s);
        public delegate double Product(double x, double y);

        static void Main(string[] args)
        {
           //public static IEnumerable<T> Flatten<T> (this IEnumerable<IEnumerable<T>> items){x => x} 
           
           
           //Extensions
            var xs = new  IEnumerable<int>[10];
            var flattenXs = xs.SelectMany(i => i);
            
            var ys = new int[10];

            var div7more42YS = ys.Where( i => i % 7 == 0 && i > 42);
            var leapYearys = ys.Where(i => DateTime.IsLeapYear(i));

            

            //Delegates
            //Remember delegate void TestDelegate(string s); outside of the void
            TestDelegate test = (s) => {Console.WriteLine(s.Reverse());};

            
            Product result = (double x, double y) => {return x * y};
            /*var result = new Product {
                delegate(double x, double y) {
                    return x * y;
                }
            } 
            */
            
        }
    }
}
