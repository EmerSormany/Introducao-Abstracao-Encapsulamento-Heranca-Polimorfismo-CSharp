
using Introducao_Abstracao_Encapsulamento_CSharp.Models;


Pessoa p1 = new Pessoa(); // criação de um objeto da classe Pessoa
ContaCorrente c1 = new ContaCorrente(123, 2000); // Valores passados como argumento na criação 
                                                 // do objeto por causa do construtor

// utilização de propriedades e métodos da classe Pessoa
p1.Nome = "Teresa";
p1.Idade = 29;
p1.Aprensentar();

// exemplo de saque com valor permitido
c1.ExibirSaldo();
c1.Sacar(200);
c1.ExibirSaldo();

// exemplo de saque com valor não permitido
c1.Sacar(2000);
c1.ExibirSaldo();

Aluno aluno = new Aluno(); // criação de um objeto da classe Aluno

// utilização de propriedades e métodos da classe Aluno herdados de Pessoa
aluno.Idade = 17;
aluno.Nome = "Leonardo";
aluno.Nota = 8.8;
aluno.Aprensentar(); // Método chamado para apresentação do aluno

Professor professor = new Professor(); // criação de um objeto da classe Professor
professor.Nome = "Django";
professor.Idade = 30;
professor.Salario = 1000;
professor.Aprensentar(); // Método chamado para apresentação do professor

Calculadora calculadora = new Calculadora(); // criação de um objeto da classe Calculadora
Console.WriteLine(calculadora.Somar(1, 2)); // vai entrar no método que soma 2 números
Console.WriteLine(calculadora.Somar(1, 2, 3)); // vai entrar no método que soma 3 números
Console.WriteLine(calculadora.Somar(1, 2, 3, 4)); // vai entrar no método que soma 4 números
Console.WriteLine(calculadora.Somar(10, 20)); // vai entrar no método que soma 2 números novamente
