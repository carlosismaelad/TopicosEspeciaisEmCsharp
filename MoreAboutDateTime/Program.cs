using System;
using System.Reflection.Metadata;

namespace MoreAboutDateTime
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(DateTime.DaysInMonth(2023, 2)); // quantos dias tem Fevereiro em 2023
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek)); // Retorna True ou False informando se hoje é fim de semana
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); // Responde true ou False informando se estamos em horário de verão

        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Sunday || today == DayOfWeek.Saturday;
        }
    }
}