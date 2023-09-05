using System;

namespace introTimeSpan
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            /* 
            DateTime representa um instante. Quantos Ticks passaram desde o dia 1, do ano 1 da era atual.
            TimeSpan armazena uma duração na forma de Ticks.            
             */

            TimeSpan t1 = new TimeSpan(); // 1º construtor - vazio - duração 0
            TimeSpan t2 = new TimeSpan(0, 1, 30); // horas, minutos e segundos
            TimeSpan t3 = new TimeSpan(900000000L); // repassando Ticks
            TimeSpan t4 = new TimeSpan(2, 2, 11, 21); // dias, horas, minutos e segundos
            TimeSpan t5 = new TimeSpan(2, 2, 11, 21, 321); // dias, horas, minutos, segundos e milissegundos

            // Usando o método From
            TimeSpan t6 = TimeSpan.FromDays(1.5); // um dia e meio
            TimeSpan t7 = TimeSpan.FromHours(1.5); // uma hora e meia
            TimeSpan t8 = TimeSpan.FromMinutes(1.5); // um minuto e meio
            TimeSpan t9 = TimeSpan.FromSeconds(1.5); // um segundo e meio
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5); // um milissegundo e meio
            TimeSpan t11 = TimeSpan.FromTicks(900000000L); // 900 milhoes de Ticks porque o tick so aceita o valor Long, não aceita valores quebrados



            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t2.Ticks);
            Console.WriteLine(t3); // 00:01:30
            Console.WriteLine(t4); // 2.02:11:21
            Console.WriteLine(t5); // 2.02:11:21.3210000
            Console.WriteLine(t6); // 1.12:00:00 -> 1 dia e 12 horas
            Console.WriteLine(t7); // 01:30:00
            Console.WriteLine(t8); // 00:01:30
            Console.WriteLine(t9); // 00:00:01.5000000
            Console.WriteLine(t10); // 00:00:00.0015000
            Console.WriteLine(t11); // 00:01:30









        }
    }
}