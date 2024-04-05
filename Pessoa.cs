using System;
using System.Collections.Generic;
using System.Text;

namespace Pessoa
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public double Altura;

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade} anos\nAltura: {Altura:F2} m");
        }
    }
}

    

