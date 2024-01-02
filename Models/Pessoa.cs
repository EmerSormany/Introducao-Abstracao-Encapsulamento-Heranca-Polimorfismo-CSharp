using System;

namespace Introducao_Abstracao_Encapsulamento_CSharp.Models
{
    public class Pessoa // criação da classe abstraindo várias características
                        // mantendo apenas o essencial para o programa
    {
        // propriedades necessárias para uma apresentação simples
        public string Nome { get; set; }
        public int Idade { get; set; }

        // uma classe pai pode ter várias classes filhas,
        // mas uma classe filha somente pode ter uma classe pai
        public virtual void Aprensentar(){   // Método com palavra virtual em sua definição
                                             // o que permite ser sobrecrito pelas classes filhas
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}
