using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_3
{
    /// <summary>
    /// Класс времени
    /// </summary>
    class Time
    {
        /// <summary>
        /// Поле часов
        /// </summary>
        public int hours;
        /// <summary>
        /// Поле минут
        /// </summary>
        public int min;
        /// <summary>
        /// Конструкторы
        /// </summary>
        public Time() { }
        public Time(int hours, int min) 
        {
            this.hours = hours;
            this.min = min;
        }
        /// <summary>
        /// Вывод
        /// </summary>
        public void OutPut()
        {
            Console.WriteLine($"Часы: {hours}\nМинуты: {min}\n");
        }
        /// <summary>
        /// общее кол-во минут
        /// </summary>
        public void Minutes()
        {
            Console.WriteLine($"Общее кол-во минут: {(hours*60)+min}");
        }
        /// <summary>
        /// Поле секунд
        /// </summary>
        public int sek;
        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="min"></param>
        /// <param name="sek"></param>
        public Time(int hours, int min, int sek) : this(hours, min)
        {
            this.sek = sek;
        }
        /// <summary>
        /// Общее кол-во секунд
        /// </summary>
        public void Obsh()
        {
            Console.WriteLine($"Общее кол-во секунд: {((hours * 60) + min)*60 + sek}");
        }
        /// <summary>
        /// Обновленный вывод
        /// </summary>
        public void OutPut1()
        {
            Console.WriteLine($"Часы: {hours}\nМинуты: {min}\nСекундны: {sek}");
        }

    }
}
