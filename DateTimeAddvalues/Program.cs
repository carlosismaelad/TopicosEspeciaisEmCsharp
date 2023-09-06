using System;
using System.Globalization;

namespace DateTimeAddValues
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            var date = DateTime.Now;

            Console.WriteLine(date.AddDays(30));

            Console.WriteLine(date.AddMonths(3));

            Console.WriteLine(date.AddYears(1));

            /* 
            É aconselhado optar por esses métodos sempre, em vez de realizar adição ou subtração de datas manualmente
            através de atribuição.
             */



            // Verificando a diferença entre datasTimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            DateTime d1 = new DateTime(1998, 12, 29);

            TimeSpan difer = date.Subtract(d1); // TimeSpan porque o resultado será uma duração.

            double yearsDouble = difer.Days / 365.25; // calcula os anos com casa decimais
            int years = (int)Math.Floor(yearsDouble); // arredonda o valor obtido para baixo

            int months = (difer.Days % 365) / 30; // aproximação de meses
            int days = (difer.Days % 365) % 30; // Dias restantes


            Console.WriteLine($"Você tem {years} anos, {months} mêses e {days} dias");


        }
    }

}