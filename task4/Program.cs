using System;

namespace task4
{
    class Program
    {
        [Flags]
        enum OfficeShedule
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000
        }
        static void Main(string[] args)
        {
            OfficeShedule office1Shedule = OfficeShedule.Monday | OfficeShedule.Tuesday | OfficeShedule.Wednesday;
            OfficeShedule office2Shedule = OfficeShedule.Saturday | OfficeShedule.Tuesday | OfficeShedule.Sunday;
            OfficeShedule office3Shedule = OfficeShedule.Monday | OfficeShedule.Wednesday | OfficeShedule.Friday; 
            Console.WriteLine($"Дни работы офиса 1 - {SheduleString(office1Shedule)}");
            Console.WriteLine($"Дни работы офиса 2 - {SheduleString(office2Shedule)}");
            Console.WriteLine($"Дни работы офиса 3 - {SheduleString(office3Shedule)}");
        }

        static string SheduleString(OfficeShedule str)
        {
            string res = "";
            if(Convert.ToBoolean(str & OfficeShedule.Monday))
                res += "Понедельник, ";
            if (Convert.ToBoolean(str & OfficeShedule.Tuesday))
                res += "Вторник, ";
            if (Convert.ToBoolean(str & OfficeShedule.Wednesday))
                res += "Среда, ";
            if (Convert.ToBoolean(str & OfficeShedule.Thursday))
                res += "Четверг, ";
            if (Convert.ToBoolean(str & OfficeShedule.Friday))
                res += "Пятница, ";
            if (Convert.ToBoolean(str & OfficeShedule.Saturday))
                res += "Суббота, ";
            if (Convert.ToBoolean(str & OfficeShedule.Sunday))
                res += "Воскресенье, ";

            res = res.Substring(0, res.Length - 2);
            return res;
        }
    }
}
