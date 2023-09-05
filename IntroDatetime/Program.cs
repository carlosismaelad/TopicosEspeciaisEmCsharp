using System;
using System.Globalization;

namespace IntroDatetime
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            // Instanciando com construtores
            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 03); // adicionamos hora, min e seg
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03, 500); // adicionamos hora, min, seg e ms

            // Criando datas usando os builders
            DateTime d4 = DateTime.Now; // uma propriedade que devolve o instante atual do sistema;
            DateTime d5 = DateTime.Today; // devolve a data de hoje no horários das 0 horas (05/09/2023 00:00:00)
            DateTime d6 = DateTime.UtcNow; // devolve o horário de agora de acordo com o Greenwich (GMT, horário universal)

            // Usando parse para gerar datas
            DateTime d7 = DateTime.Parse("2000-08-15"); // formato usado pelos bancos de dados
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58"); // pegando o horário 
            DateTime d9 = DateTime.Parse("15/08/2000 12:10:45"); // formato brasileiro


            // Usando o PaserExact para determinar o formato da nossa data e não usar um formato pre-determinado:
            DateTime d10 = DateTime.ParseExact("1998-12-29", "yyyy-MM-dd", CultureInfo.InvariantCulture); // determinamos a máscara de formatação
            DateTime d11 = DateTime.ParseExact("27/07/2019 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture); // determinamos a máscara de formatação


            // Formatando com string.Fortmat
            var d12 = DateTime.Now;
            var dataFormatada = string.Format("{0:dd/MM/yyyy HH:mm:ss}", d12);
            var dataFormatada2 = string.Format("{0:dd/MM/yy hh:mm:ss}", d12); // 05/09/23 10:58:23
            var dataFormatada3 = string.Format("{0:dd/MM/yy hh:mm:ss ff zzz}", d12); // adicionando fração de segundo e timezone (z, zz ou zzz)


            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine("Tempo atual: " + d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6); // três horas de diferença à frente porque estamos no Brasil e o nosso fuso é GMT-3
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(dataFormatada);
            Console.WriteLine(dataFormatada2);
            Console.WriteLine(dataFormatada3);
        }
    }

}