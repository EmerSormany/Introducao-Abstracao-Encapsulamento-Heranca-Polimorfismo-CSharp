using System;

namespace Introducao_Abstracao_Encapsulamento_CSharp.Models
{
    public class Calculadora
    {

        // Exemplos de polimorfismo em tempo de compilação

        // Método usado quando é passado 2 argumentos
        public int Somar(int num1, int num2){
            Console.WriteLine("Somar 2 números");
            return num1 + num2;
        }

        // Método usado quando é passado 3 argumentos
        public int Somar(int num1, int num2, int num3){
            Console.WriteLine("Somar 3 números");
            return num1 + num2 + num3;
        }

        // Método usado quando é passado 4 argumentos
        public int Somar(int num1, int num2, int num3, int num4){
            Console.WriteLine("Somar 4 números");
            return num1 + num2 + num3 + num4;
        }
    }
}
