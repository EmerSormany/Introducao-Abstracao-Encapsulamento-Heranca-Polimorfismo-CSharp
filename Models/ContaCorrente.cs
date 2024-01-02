using System;

namespace Introducao_Abstracao_Encapsulamento_CSharp.Models
{
    public class ContaCorrente
    {
        // Criação de construtor que atribui os valores passados na criação do objeto para as propriedades da classe
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        // propriedade privada, apenas a classe pode alterar e consultar seu valor
        private decimal Saldo { get; set; } 

        // Método que encapsula a propriedade saldo, implementando lógica de proteção 
        // impedindo que o valor fique negativo
        public void Sacar(decimal valor){
            if (Saldo < valor)
            {
                Console.WriteLine("Valor desejado é maior do que o saldo disponível.");
            }else
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }
        }

        // Método criado para verificar valor de saldo, uma vez que a cosulta direta não é possível
        public void ExibirSaldo(){
            Console.WriteLine($"Seu Saldo disponível é: {Saldo}.");
        }
    }
}
