using System;

namespace StringCompare
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            var text = "Testando";

            Console.WriteLine(text.CompareTo("Testando")); // retorna um inteiro, no caso o 0 porque são iguais
            Console.WriteLine(text.CompareTo("testando")); // retorna um inteiro, no caso o 1 porque é são diferentes

            var text2 = "Esse texto é um teste";
            Console.WriteLine(text2.Contains("xto")); // podemos comparar strings completas ou apenas um trecho. Retorna True ou False.
            Console.WriteLine(text2.Contains("T", StringComparison.OrdinalIgnoreCase)); // para que ele ignore o case sensitive. Retorna True

        }
    }
}