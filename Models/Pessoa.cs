using System;

namespace Introducao_Abstracao_Encapsulamento_CSharp.Models
{
    public class Pessoa // criação da classe abstraindo várias características
                        // mantendo apenas o essencial para o programa
    {
        // propriedades necessárias para uma apresentação simples
        public string Nome { get; set; }
        public int Idade { get; set; }
        public void Aprensetar(){
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}
