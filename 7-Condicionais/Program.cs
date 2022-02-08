using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18){
                // Criando uma condição que será um ou outro 
                // Se a Idade Do João for maior que 18 ele poderá entrar 
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            else{
                if (quantidadePessoas >= 2){
                    // Oura Condição é si ele estiver acompanhado poderá entrar 
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado. Pode entrar");
                }
                else{
                    // Caso Nenhuma Das Condições For Verdade Irá Para Esse Bloco
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar");
                }
            }

            Console.ReadLine();
        }
    }
}
