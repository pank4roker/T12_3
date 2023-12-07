using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_3
{
    /// <summary>
    /// Класс описывающий газету
    /// </summary>
    class Newspaper
    {
        public string name;
        public int circulation;
        public int lines;
        public Newspaper() { }
        public Newspaper(string name, int circulation, int lanes) 
        {

        }
        public void Info()
        {
            Console.WriteLine($"Название: {name};\nТираж: {circulation};\nКоличество полос: {lines};\n");
        }


    }
}
