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
     this.name = name;
     this.circulation = circulation; 
     this.lanes = lanes;
    }
    public void Info()
    {
     Console.WriteLine($"Название: {name};\nТираж: {circulation};\nКоличество полос: {lanes};\n");
    }
     public void ChangeName(string Newname)
    {
   
     name = Newname;
     Console.WriteLine($"Название новой газеты: {Newname};");
    }
    public void ChangeNumber(int Newlanes)
    {
     lanes = Newlanes;
     Console.WriteLine($"Количество новый полос: {Newlanes};");
    }

    }
}
