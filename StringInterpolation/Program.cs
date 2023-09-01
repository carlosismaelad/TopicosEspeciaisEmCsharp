using System;

namespace StringInterpolation
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Vamos ver as várias maneiras de mixar/interpolar elementos com as nossas strings
            Console.Clear();

            var price = 10.2;
            var product = "livro";
            var text = "O preço do" + product + "é " + price + " apenas na promoção.";
            var text2 = string.Format("O preço do produto é {0} apenas na promoção.", price);

            var age = 30;
            var name = "Carlos";
            var presentation = string.Format("Me chamo {0} e tenho {1} anos.", name, age);
            var presentation2 = string.Format("Me chamo {0} e tenho {1} anos.",
             age,
             name); // se invertermos a ordem das variáveis a saída também terá os elementos fora de ordem na escrita;
                    // Se a quantidade de variáveis for diferente da quantidade de {} passadas na string ocorrerá erro.

            // $"" é a interpolação mais usada e mais simples. Para quebra de linhas basta adicionar o @ após o $
            var presentation3 = $"Me chamo {name} e tenho {age} anos";

            // usando apenas @. Se você estiver usando apenas strings sem interpolação poderá usar o @ para quebra de linhas.
            // Também usamos o @ quando iremos usar caracteres especiais como \n para que o compilador possa ignorar e ler como string.
            var announcement = @"
            Comunicado:
            No dia 01/01/2023 não haverá aula.
            Motivo: feriado do dia da independência.";

            Console.WriteLine(text);
            Console.WriteLine(text2);
            Console.WriteLine(presentation);
            Console.WriteLine(presentation2);
            Console.WriteLine(presentation3);
            Console.WriteLine(announcement);




        }
    }
}