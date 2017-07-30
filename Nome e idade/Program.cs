using System;
using System.Globalization;

namespace Nome_e_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double mediaIdade;

            string[] dados1;
            string[] dados2;

            dados1 = Console.ReadLine().Split(' ');
            dados2 = Console.ReadLine().Split(' ');

            nome1 = dados1[0];
            idade1 = int.Parse(dados1[1]);

            nome2 = dados2[0];
            idade2 = int.Parse(dados2[1]);

            mediaIdade = (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + mediaIdade.ToString("F1", CultureInfo.InvariantCulture) + " anos.");
            Console.ReadLine();
        }
    }
}
