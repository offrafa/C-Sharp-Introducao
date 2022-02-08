using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_LacoDeRepeticaoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int total = 0;

            while (contador <= 10)
                // Se o Numero for maior ou igual a 10 o Loop continua 
            {
                total += contador;
                
                // Outras Formas De Adicionar Mais Um
                // contador = contador + 1;
                // contador += 1;
                contador++;
            }

            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
