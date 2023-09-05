using System;

namespace FormattingPatternsDateTime
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            var date = DateTime.Now;

            var f1 = string.Format("{0:d}", date); // retorna como short date
            var f2 = string.Format("{0:D}", date); // retorna como long date
            var f3 = string.Format("{0:t}", date); // retorna como um short time - apenas as horas
            var f4 = string.Format("{0:T}", date); // retorna como um time longo - apenas as horas
            var f5 = string.Format("{0:f}", date); // combina data e hora sem segundos
            var f6 = string.Format("{0:F}", date); // combina data e hora com segundos
            var f7 = string.Format("{0:g}", date); // combina data e hora no formato short
            var f8 = string.Format("{0:G}", date); // combina data e hora no formato short mas com segundos
            var f9 = string.Format("{0:y}", date); // retorna mês e ano
            var f10 = string.Format("{0:r}", date); // esse segue o padrão que a maioria dos sistemas usa
            var f11 = string.Format("{0:s}", date); // padrão utilizado nas datas do tipo json, se preciso converter algo para o Front-End
            var f12 = string.Format("{0:u}", date); // padrão universal

            // podemos fazer combinações
            var f13 = string.Format("{0:dd/MM/yyyy}", date); // retorna dia, mês e ano
            var f14 = string.Format("{0:dd/MM/yy HH:mm:ss}", date); // retorna dia, mês, ano com dois digitos e hora
            var f15 = string.Format("{0:dd/MM/yy HH:mm:ss zzz}", date); // retorna dia, mês, ano com dois digitos, hora e timezone


            Console.WriteLine(f1); // 05/09/2023
            Console.WriteLine(f2); // terça-feira, 5 de setembro de 2023
            Console.WriteLine(f3); // 11:11
            Console.WriteLine(f4); // 11:13:58
            Console.WriteLine(f5); // terça-feira, 5 de setembro de 2023 11:16
            Console.WriteLine(f6); // terça-feira, 5 de setembro de 2023 11:16:51
            Console.WriteLine(f7); // 05/09/2023 11:17
            Console.WriteLine(f8); // 05/09/2023 11:18:21
            Console.WriteLine(f9); // setembro de 2023
            Console.WriteLine(f10); // Tue, 05 Sep 2023 11:25:52 GMT
            Console.WriteLine(f11); // 2023-09-05T11:29:27
            Console.WriteLine(f12); // 2023-09-05 11:31:09Z
            Console.WriteLine(f13); // 05/09/2023
            Console.WriteLine(f14); // 05/09/23 11:21:54
            Console.WriteLine(f15); // 05/09/23 11:22:32 -03:00
        }
    }

}