using System;

namespace Guids
{
    class Program
    {
        public static void Main(string[] args)
        {

            /* Sempre que precisamos identificar algo usamos o Id para que possamos identificar esse elemento
            unica e exclusivamente. em diversos caso o id é gerado pelo banco de dados.
            Aqui, iremos usar o Guid (Globally Unique Identifier) 
            O GUID gera um hash que contém 122 bits de entropia forte. É um tipo de dado usado para criar identificadores únicos e exclusivos.
            Sempre que o programa é executado o hash do Guid será diferente. */

            var id = new Guid(); // apenas inicializa e gera um Guid apenas com zeros

            id = Guid.NewGuid(); // atribuindo um Guid para a variável id
            id.ToString(); // como o Guid herda do tipo base (System), podemos transformar ele em uma string dessa forma

            // Também podemos assimiliar um Guid a um id repassando para ele uma string
            id = new Guid("9803f2ff-a45a-42bb-94b4-10329bfd20a9"); // irá exibir exatamente o hash que repassamos como string


            Console.WriteLine(id.ToString().Substring(0, 8));  // informando que queremos apenas o 8 primeiros caracteres (9803f2ff)



        }
    }
}