
using Introducao_Abstracao_Encapsulamento_CSharp.Models;


Pessoa p1 = new Pessoa(); // criação de um objeto da classe Pessoa
ContaCorrente c1 = new ContaCorrente(123, 2000); // Valores passados como argumento na criação 
                                                 // do objeto por causa do construtor

// utilização de propriedades e métodos da classe
p1.Nome = "Teresa";
p1.Idade = 29;
p1.Aprensetar();

// exemplo de saque com valor permitido
c1.ExibirSaldo();
c1.Sacar(200);
c1.ExibirSaldo();

// exemplo de saque com valor não permitido
c1.Sacar(2000);
c1.ExibirSaldo();