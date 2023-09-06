using System;
using System.Diagnostics;

namespace DateCompare
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            DateTime? data = null; // usando o tipo DateTime e o "?" para podermos ter uma data que pode ser nula
            Console.WriteLine(date);

            // Comparação de datas de forma INCORRETA:
            DateTime date = DateTime.Now;

            if (date == DateTime.Now) // nunca será porque o Dotnet compara a estrutura toda e os milissegundos sempre serão diferentes
            {
                Console.WriteLine("É igual!");
            }
            else
            {
                Console.WriteLine("Não é igual"); // esta será a saída
            }

            // Comparando de forma CORRETA:
            if (date.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual"); // a saída será esta
            }
            else
            {
                Console.WriteLine("É diferente");
            }


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