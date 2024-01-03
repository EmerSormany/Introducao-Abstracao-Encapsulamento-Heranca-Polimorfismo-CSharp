using System;

namespace Introducao_Abstracao_Encapsulamento_CSharp.Models
{
    public abstract class Conta // Classe abstrata criada como modelo para outras classes,
                                // não pode ser instanciada
    {
        protected decimal Saldo; // propreidade que pode ser alterada e consultada apenas pelas classes filhas
                                 // semalhando ao private, porém, mais brando

        public abstract void Creditar(decimal valor); // método criado como abstrato e precisa ser implementado
                                                      // em cada classe filha usando a 'override'

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo disponível é {Saldo}.");
        }
        
    }
}
