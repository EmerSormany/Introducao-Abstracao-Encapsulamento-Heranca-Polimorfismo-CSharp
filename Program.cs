
using Introducao_Abstracao_Encapsulamento_CSharp.interfaces;
using Introducao_Abstracao_Encapsulamento_CSharp.Models;


Pessoa p1 = new Pessoa("Teresa"); // criação de um objeto da classe Pessoa
ContaCorrente c1 = new ContaCorrente(123, 2000); // Valores passados como argumento na criação 
                                                 // do objeto por causa do construtor
// utilização de propriedades e métodos da classe Pessoa
p1.Idade = 29;
p1.Aprensentar();

// EXEMPLO CRIADO APENAS PARA ELUCIDAR O ENCAPSULAMENTO DE UMA PROPRIEDADE{
// exemplo de saque com valor permitido
c1.ExibirSaldo();
c1.Sacar(200);
c1.ExibirSaldo();
// exemplo de saque com valor não permitido
c1.Sacar(2000);
c1.ExibirSaldo();
//  }

Aluno aluno = new Aluno(); // criação de um objeto da classe Aluno
// utilização de propriedades e métodos da classe Aluno herdados de Pessoa
aluno.Nome = "Leonardo";
aluno.Idade = 17;
aluno.Nota = 8.8; // Característica não herdada, pois é exclusiva de Aluno
aluno.Aprensentar(); // Método chamado para apresentação do aluno

Professor professor = new Professor("Django"); // criação de um objeto da classe Professor
professor.Idade = 30;
professor.Salario = 1000; // Característica não herdada, pois é exclusiva de Professor
professor.Aprensentar(); // Método chamado para apresentação do professor

ICalculadora calculadora = new Calculadora(); // criação de um objeto da classe Calculadora
// interface ICalculadora recebendo diretamente uma instancia da classe Calculadora
// é preciso que a classe implemente a interface para que isso seja possível
Console.WriteLine(calculadora.Somar(1, 2)); // vai entrar no método que soma 2 números
Console.WriteLine(calculadora.Somar(1, 2, 3)); // vai entrar no método que soma 3 números
Console.WriteLine(calculadora.Somar(1, 2, 3, 4)); // vai entrar no método que soma 4 números
Console.WriteLine(calculadora.Somar(10, 20)); // vai entrar no método que soma 2 números novamente
Console.WriteLine(calculadora.Multiplicar(10, 20)); 
Console.WriteLine(calculadora.Dividir(10, 20)); 
Console.WriteLine(calculadora.Subtrair(10, 20)); 


Corrente corrente = new Corrente(); // criação de um objeto da classe Corrente
corrente.Creditar(5000); // chama o método herdado de Conta e implementado em Corrente
corrente.ExibirSaldo(); // chama o método herdado de Conta


Diretor diretor = new Diretor(); // criação de um objeto da classe Diretor
// utilização de métodos e propriedades herdadas de Professor, inclusive o método selado Apresentar
diretor.Nome = "José";
diretor.Idade = 43;
diretor.Salario = 1650;
diretor.Aprensentar();

Computador computador = new Computador(); // criação de um objeto da classe Computador
computador.ToString(); // Chamando método herdado da classe Object