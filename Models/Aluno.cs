using System;

namespace Introducao_Abstracao_Encapsulamento_CSharp.Models
{
    public class Aluno : Pessoa // Classe Aluno herdando características da classe Pessoa
    {
        public double Nota { get; set; } // Característica exclusiva de Aluno

        // Exemplo de polimorfismo em tempo de execução
        public override void Aprensentar() // Método sobrescrito com palavra override
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} e sou aluno nota {Nota}.");
        }
    }
}
