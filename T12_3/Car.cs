using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_3
{
    /// <summary>
    /// Класс машины
    /// </summary>
    class Car
    {
        /// <summary>
        /// Поле марки
        /// </summary>
        public string mark;
        /// <summary>
        /// Поле модели
        /// </summary>
        public string model;
        /// <summary>
        /// Поле номера
        /// </summary>
        public string number;
        /// <summary>
        /// Конструктор
        /// </summary>
        public Car() { }
        /// <summary>
        /// Конструктор с параметром 
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="model"></param>
        /// <param name="number"></param>
        public Car(string mark, string model, string number)
        {
            this.mark = mark;
            this.model = model;
            this.number = number;
        }
        public void Start()
        {
            Console.WriteLine($"Машина {mark} {model} {number} завелась");
        }
        public void Stop() 
        {
            Console.WriteLine($"Машина {mark} {model} {number} остановилась");
        }

    }
}
