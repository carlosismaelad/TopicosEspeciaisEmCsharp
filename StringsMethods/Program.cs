using System;

namespace StringsMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            string original = "abcde FGHIJ ABC abc DEFG";

            string s1 = original.ToUpper(); // todo as letras para maiusculo
            string s2 = original.ToLower(); // todo as letras para minusculo
            string s3 = original.Trim(); // apaga todos os espaços em branco da string
            int n1 = original.IndexOf("bc"); // função de procura. Retorna a primeira ocorrência do trecho informado
            int n2 = original.LastIndexOf("bc"); // função de procura. Retorna a última ocorrência do trecho informado

            string s4 = original.Substring(3); // pega a string a partir do índice 3
            string s5 = original.Substring(3, 5); // pega 5 caracteres da string a partir do índice 3

            string s6 = original.Replace('a', '$'); // troca todas as ocorrências de 'a' por '$'
            string s7 = original.Replace("bc", "@"); // troca todas as ocorrências de 'bc' por '@'. As substituições não precisam ser do mesmo tamanho.

            bool b1 = String.IsNullOrEmpty(original); // testa se o conteúdo da variável é null ou vazio
            bool b2 = String.IsNullOrWhiteSpace(original); // testa se o conteúdo da variável é null ou um espaço em branco


            Console.WriteLine("Original: -" + original + " -");
            Console.WriteLine("ToUpper: -" + s1 + " -");
            Console.WriteLine("ToLower: -" + s2 + " -");
            Console.WriteLine("Trim: -" + s3 + " -");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring('3'): " + s4);
            Console.WriteLine("Substring('3,5'): " + s5);
            Console.WriteLine("Replace('a', '$'): " + s6);
            Console.WriteLine("Replace('bc', '@'): " + s7);
            Console.WriteLine("IsNullOrEmpty: " + b1); // False, porque não é null ou vazio
            Console.WriteLine("IsNullOrWhiteSpace: " + b2); // False, porque o conteúdo da variável possui não é null ou um espaço em branco

        }
    }
}