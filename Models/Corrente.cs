using System;

namespace Introducao_Abstracao_Encapsulamento_CSharp.Models
{
    public class Corrente : Conta // criação de classe Corrente que herda da classe Conta
    {
        public override void Creditar(decimal valor) // implementação do método definido como abstract na classe pai
        {
            Saldo =+ valor;
        }
    }
}
