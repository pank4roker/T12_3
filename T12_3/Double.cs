using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12_3
{
    /// <summary>
    /// Double values
    /// </summary>
    class Double
    {
        /// <summary>
        /// First double value
        /// </summary>
        public double value1;
        /// <summary>
        /// Second double value
        /// </summary>
        public double value2;


        /// <summary>
        /// Constructor without parametrs
        /// </summary>
        public Double() { }
        /// <summary>
        /// Constructor with parametrs
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        public Double(double value1, double value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        /// <summary>
        /// Output
        /// </summary>
        public void Output()
        {
            WriteLine($"First double value: {value1};\nSecond double value: {value2};\n");
        }
        /// <summary>
        /// Квадратный корень из их произведения
        /// </summary>
        public void Func()
        {
            WriteLine($"Square root: {Math.Sqrt( value1 * value2 ):f2}");
        }
        
    }
}
