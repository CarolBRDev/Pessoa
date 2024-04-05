using System;

namespace Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o nome da pessoa:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da pessoa:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura da pessoa:");
            double altura = double.Parse(Console.ReadLine());

            Pessoa pessoa1 = new Pessoa(nome, idade, altura);
            pessoa1.Apresentar();
        }
    }
}
