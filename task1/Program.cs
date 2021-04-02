using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            float minTemp, maxTemp, averageTemp;
            string sMinTemp, sMaxTemp;
            const string errMessage = "Неверный формат введенного числа (используйте в качестве разделителя ',')";

            while (true)
            {
                Console.Write("Введите минимальную суточную температуру: ");
                sMinTemp = Console.ReadLine();
                try
                {
                    minTemp = Convert.ToSingle(sMinTemp);
                }
                catch (Exception)
                {
                    Console.WriteLine(errMessage);
                    continue;
                }
                break;
            }
            while(true)
            { 
                Console.Write("Введите максимальную суточную температуру: ");
                sMaxTemp = Console.ReadLine();
                try
                {
                    maxTemp = Convert.ToSingle(sMaxTemp);
                }                
                catch (Exception)
                {
                    Console.WriteLine(errMessage);
                    continue;
                }
                break;
            }
            averageTemp = (maxTemp + minTemp) / 2;
            Console.WriteLine($"Среднесуточная температура - {averageTemp:0.0} грудусов");
            return;
        }
    }
}
