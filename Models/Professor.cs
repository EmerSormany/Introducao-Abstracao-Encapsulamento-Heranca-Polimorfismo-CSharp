using System;

namespace Introducao_Abstracao_Encapsulamento_CSharp.Models
{
    public class Professor : Pessoa // Classe professor herdando características da classe Pessoa
    {
        public decimal Salario { get; set; } // Característica exclusiva de professor

        // Exemplo de polimorfismo em tempo de execução
        public override void Aprensentar() // Método sobrescrito com palavra override
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, Tenho {Idade} e sou professor e recebo {Salario:c}.");
        }
    }
}
