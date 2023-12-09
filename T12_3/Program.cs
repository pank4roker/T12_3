using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task1
                /*Double val1 = new Double(2.1,24.5);
                val1.Output();
                val1.Func();

                Write("\nEnter first value: ");
                double v1=Convert.ToDouble(ReadLine());
                Write("Enter second value: ");
                double v2 = Convert.ToDouble(ReadLine());
                Double val2 = new Double(v1,v2);
                WriteLine();
                //val2.Output();
                val2.Func();*/

                //Task2
                /*Time time1 = new Time(1,2);
                time1.OutPut();
                time1.Minutes();
                Time time2 = new Time(2,3,4);
                time2.Obsh();
                time2.OutPut1();*/

                //Task3
                /*Triangle triag = new Triangle(5,4,6);
                triag.Output();
                triag.Per();*/

                //Task4
                /*Car car1 = new Car();
                car1.mark = "Lexus";
                car1.model = "LFA";
                car1.number = "Т 666 КА";
                car1.Start();
                car1.Stop();
                Car car2 = new Car();
                car1.mark = "Toyota";
                car1.model = "Supra";
                car1.number = "Т 999 TT";
                car1.Start();
                car1.Stop();*/
                //Task5
                Newspaper newspaper = new Newspaper("24часовая",5000,10);
                newspaper.Info();
                Write($"Введите название новой газеты: ");
                string Newname = Console.ReadLine();
                ChangeName(Newname);
                Write("Введите новое количество полос для газеты: ");
                int Newlanes = Convert.ToInt32(Console.ReadLine());
                newspaper.ChangeNumber(Newlanes);
                WriteLine("\nОбновленная газета\n");
                newspaper.Info();
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
