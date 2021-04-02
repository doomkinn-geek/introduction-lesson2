using System;

namespace task2
{
    class Program
    {        
        static void Main(string[] args)
        {
            uint monthNum;//не стал делать беззнаковым, чтобы не усложнять программу обработкой исключений           
            string monthStr;
            Console.Write("Введите номер месяца: ");
            try
            {
                monthNum = Convert.ToUInt16(Console.ReadLine());
            }
            catch(Exception)
            {
                monthNum = 0;
            }
            switch (monthNum)
            {
                case 1:
                    monthStr = "Январь";
                    break;
                case 2:
                    monthStr = "Февраль";
                    break;
                case 3:
                    monthStr = "Март";
                    break;
                case 4:
                    monthStr = "Апрель";
                    break;
                case 5:
                    monthStr = "Май";
                    break;
                case 6:
                    monthStr = "Июнь";
                    break;
                case 7:
                    monthStr = "Июль";
                    break;
                case 8:
                    monthStr = "Август";
                    break;
                case 9:
                    monthStr = "Сентябрь";
                    break;
                case 10:
                    monthStr = "Октябрь";
                    break;
                case 11:
                    monthStr = "Ноябрь";
                    break;
                case 12:
                    monthStr = "Декабрь";
                    break;
                default:
                    monthStr = "Неверное значение месяца";
                    break;
            }
            Console.WriteLine($"Введен месяц {monthStr}");

        }
    }
}
