using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2021.Assignment03
{
    public class Program
    {
        IEnumerable<int>[] xs;
        int[] ys;

        //Delegates
        public delegate void Reverse(string s);
        public static Reverse reverse = (s) => {Console.WriteLine(s.Reverse().ToArray());};


        public delegate bool NumericEqual(string s, int i);
        public static NumericEqual numericEqual = (string s, int i) => {return Int32.Parse(s) == i;};
        
        public delegate double Product(double x, double y);
        public static Product calculateProduct = (double x, double y) => {return x * y;};

        static void Main(string[] args)
        {
           //public static IEnumerable<T> Flatten<T> (this IEnumerable<IEnumerable<T>> items){x => x} 
           
           
           //Extensions
            var xs = new  IEnumerable<int>[10];
            var flattenXs = xs.SelectMany(i => i);
            
            var ys = new int[10];

            var div7more42YS = ys.Where( i => i % 7 == 0 && i > 42);
            var leapYearys = ys.Where(i => DateTime.IsLeapYear(i));

            

            
        
            

            
        }
    }
}
