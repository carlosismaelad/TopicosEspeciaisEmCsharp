using System;

namespace IntroDTKind
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();


            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d1: " + d3);

            Console.WriteLine();


            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d2 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime()); // acrescenta 3 horas na data


            Console.WriteLine();


            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());

            Console.WriteLine();


            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());


            Console.WriteLine();
            /* ISO 8601
            Formato:
            yyyy-MM-ddTHH:mm:ssZ
            Z indica que a data/hora está em Utc */


            DateTime date1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime date2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine(date1);
            Console.WriteLine(date2); // imprime subtraindo 3 horas. A data instanciada por padrão ela já vem adaptada para computador local do usuário.

            Console.WriteLine();

            // Usando as variáveis criadas mais acima
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // mantém a hora atual!

            /* Cuidado!
            Se desejar imprimir uma data no formato ISO 8601, o correto é garantir, amtes, que ela já esteja no formato universal para depois fazer o ToString, como faremos abaixo. */

            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));





        }
    }
}