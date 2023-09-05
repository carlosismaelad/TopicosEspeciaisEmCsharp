using System;

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


        }
    }

}