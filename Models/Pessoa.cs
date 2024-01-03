using System;

namespace Introducao_Abstracao_Encapsulamento_CSharp.Models
{
    public class Pessoa // criação da classe abstraindo várias características
                        // mantendo apenas o essencial para o programa
    {
        public Pessoa() // Criação de construtor vazio, para que não seja obrigatório passar algum valor
                        // quando a classe for instanciada
        {
            
        }
        public Pessoa(string nome) // definição de construtor que obrigado ser passado valor para a propriedade Nome
        {
            Nome = nome;
        }
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
