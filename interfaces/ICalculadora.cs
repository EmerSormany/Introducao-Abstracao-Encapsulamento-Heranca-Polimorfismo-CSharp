using System;

namespace Introducao_Abstracao_Encapsulamento_CSharp.interfaces
{
    public interface ICalculadora // criação de interface
    {
        // métodos sem escopo precisarão ser implementados na classe que implementar a interface
        int Somar(int num1, int num2);
        int Somar(int num1, int num2, int num3);
        int Somar(int num1, int num2, int num3, int num4);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        // métodos com escopo tem sua implemetação opcional
        decimal Dividir(int num1, int num2)
        {
            return (decimal)num1 / num2;
        }
    }
}
