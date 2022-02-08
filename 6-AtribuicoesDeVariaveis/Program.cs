using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            int idadeGustavo = idade;
            // Atribuindo Valor Na Variável idade e Adicionado o Valor de idade em outra Variável 

            idade = 20;
            // mudando o valor apenas da variavél idade 

            Console.WriteLine(idade);
            // idadeGustavo = 50; Mudará o valor da variavél a baixo
            Console.WriteLine(idadeGustavo);

            Console.ReadLine();
        }
    }
}
