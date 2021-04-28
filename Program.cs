using System;

namespace Backend_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nomePessoa = Console.ReadLine();
        
        Console.WriteLine("Bom dia " + nomePessoa);

        Console.Write("Digite o primeiro número: ");
        int primeiroNumero = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int segundoNumero = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        int terceiroNumero = int.Parse(Console.ReadLine());

        int soma = primeiroNumero + segundoNumero + terceiroNumero;

        Console.WriteLine("A soma dos números é: " + soma);

        Console.Write("A divisão dos três" + soma/3);
      


    


            

        }
    }
}
