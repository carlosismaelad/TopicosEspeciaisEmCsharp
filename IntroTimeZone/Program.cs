using System;

namespace IntroTimeZone
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            var utcDate = DateTime.UtcNow; // instancia o presente momento com o padrão Utc
            Console.WriteLine(utcDate);

            Console.WriteLine(utcDate.ToLocalTime()); // fazendo o parse para a hora local

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timeZoneAustralia); // (UTC+12:00) Horário da Nova Zelândia (Auckland)

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);
            Console.WriteLine(horaAustralia);


            /* Como listar todos os TimeZones */
            var timeZones = TimeZoneInfo.GetSystemTimeZones();

            foreach (var timeZone in timeZones)
            {
                Console.WriteLine(timeZone.Id);
                Console.WriteLine(timeZone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZone));
                Console.WriteLine("----------");
            }







        }
    }
}