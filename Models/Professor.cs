using System;

namespace Introducao_Abstracao_Encapsulamento_CSharp.Models
{
    public class Professor : Pessoa // Classe professor herdando características da classe Pessoa
    {
        public Professor() // É preciso repetir a criação de construtor nas classes filhas
        {
            
        }
        public Professor(string nome) : base(nome) // Construtor herdado da classe Pessoa, passa o valor recebido
                                                   // em nome para a base Pessoa 
        {
            
        }
        public decimal Salario { get; set; } // Característica exclusiva de professor

        // Exemplo de polimorfismo em tempo de execução
        public sealed override void Aprensentar() // Método sobrescrito com palavra override
                                                  // e selado para que novas classes filhas não possam sobrescrever
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, Tenho {Idade}, sou professor e recebo {Salario:c}.");
        }
    }
}
