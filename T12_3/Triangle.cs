using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12_3
{
    class Triangle
    {
        /// <summary>
        /// First side
        /// </summary>
        public double a;
        /// <summary>
        /// Second side
        /// </summary>
        public double b;
        /// <summary>
        /// Third side
        /// </summary>
        public double c;
        /// <summary>
        /// Constructor without parametrs
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// Constructor with parametrs
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        /// <summary>
        /// Constuctor with only parametr
        /// </summary>
        /// <param name="a"></param>
        public Triangle(double a)
        {
            this.a = a; this.b = a; this.c = a;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void Output()
        {
            WriteLine($"First side: {a};\nSecond side: {b};\nThird side: {c};\n");
        }
        public void Per()
        {
            Write($"Perimeter: {a+b+c};");
        }




    }
}
