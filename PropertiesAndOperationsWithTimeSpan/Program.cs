using System;

namespace PropertiesAndOperationsWithTimeSpan
{
    class Program
    {
        public static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            Console.WriteLine("--------------------");


            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine("t1: " + t1);
            Console.WriteLine("t2: " + t2);
            Console.WriteLine("Soma t1 + t2: " + sum);
            Console.WriteLine("Diferença de t1 para t2: " + dif);
            Console.WriteLine("Multiplicação t2 x 2: " + mult);
            Console.WriteLine("Divisão t2 / 2: " + div);
        }
    }
}