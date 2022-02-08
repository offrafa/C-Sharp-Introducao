using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            // character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);
            // Adicionando um Valor Vazio Na Variável 

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);
            // Em Uma Tabela Do C# 61 é o Sinal de Igual 
            // primeiraLetra Está Adicionado Um Caracter da Tabela

            primeiraLetra = (char)(primeiraLetra + 1);
            // Agora Está Somando Um Caracter Da Tabela Mais Um 
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;
            // A Variável Recebe Apenas Letras 
            string cursosProgramacao =
            @"- .NET 
- Java 
- Javascript";
            // Adicionando @ "" Se Cria Uma Tabela 

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);


            Console.ReadLine();
        }
    }
}
