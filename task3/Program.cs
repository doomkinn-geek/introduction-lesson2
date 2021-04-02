using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;//не стал делать беззнаковым, чтобы не усложнять программу обработкой исключений                       
            Console.Write("Введите число: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Введено некорректное число");
                return;                
            }
            if(num % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
        }
    }
}
