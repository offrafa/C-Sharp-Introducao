using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeJoao = 18;
            // int quantidadePessoas = 2;
            // bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = false;
            // Nesse caaso iniciamos com falso para indicar que João não está acompanhado
            // e irá ser verificado 
            
            // boll é uma variável que só retorna verdade ou falso

            if (idadeJoao >= 18 && acompanhado == true){
            /*  idadeJoao >= 18 || acompanhado == true */  // Nesse caso Irá Entrar Nesse Bloco pq Uma das Condiçoes é true


                // As Duas Opções Tem Que Ser Verdade Para Entrar Nesse Bloco
                // essa condicional está verificando se João tem mais 18 e comparando se realmente está acompanhado

                Console.WriteLine("Pode entrar.");

            }else{
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
            
        }
    }
}
