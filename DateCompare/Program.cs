using System;
using System.Diagnostics;

namespace DateCompare
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            DateTime? date = null; // usando o tipo DateTime e o "?" para podermos ter uma data que pode ser nula
            Console.WriteLine(date);

            // Comparação de datas de forma INCORRETA:
            DateTime data = DateTime.Now;

            if (data == DateTime.Now) // nunca será porque o Dotnet compara a estrutura toda e os milissegundos sempre serão diferentes
            {
                Console.WriteLine("É igual!");
            }
            else
            {
                Console.WriteLine("Não é igual"); // esta será a saída
            }

            // Comparando de forma CORRETA:
            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual"); // a saída será esta
            }
            else
            {
                Console.WriteLine("É diferente");
            }





        }
    }
}