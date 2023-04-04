using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Aula02Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
            // para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
            // realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as
            // notas de menor valor fossem distribuídas em número mínimo possível.
            // Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            // uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
            // Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas
            // de acordo com o critério da “distribuição ótima”.

            // Solicita ao usuário que digite o valor do saque e armazena na variável valorSaque
            Console.Write("Digite o valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            // Calcula o número de notas de R$ 100 necessárias para o saque
            double nota100 = Math.Floor(valorSaque / 100);

            // Calcula o resto da divisão por 100 e repete o processo para as outras notas
            double resto = valorSaque % 100;
            double nota50 = Math.Floor(resto / 50);
            resto %= 50;

            double nota20 = Math.Floor(resto / 20);
            resto %= 20;

            double nota10 = Math.Floor(resto / 10);
            resto %= 10;

            double nota5 = Math.Floor(resto / 5);
            resto %= 5;

            double nota2 = Math.Floor(resto / 2);
            resto %= 2;

            // Armazena o valor restante nas notas de R$ 1
            double nota1 = Math.Floor(resto);

            Console.WriteLine("---------------------------------------");

            // Exibe a distribuição das notas na tela
            Console.WriteLine("Distribuição das notas:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
            Console.WriteLine($"{nota1} nota(s) de R$ 1,00");
        }
    }
}