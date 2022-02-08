using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;
            // DOUBLE é Um Tipo de Variável Que Só Recebe Numero com Casa Decimal EX 500.30 

            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2.0;
            Console.WriteLine(idade);
            // Criando Operações Matematicas 

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("A execução acabou. Tecle enter para sair . . . ");
            Console.ReadLine();
        }
    }
}
