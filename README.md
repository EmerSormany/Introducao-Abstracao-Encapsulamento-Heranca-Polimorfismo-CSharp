# Introducao a Abstração, Encapsulamento, Herança, Polimorfismo, Classes Abstratas e Interfaces em C#

Este repositório é um resumo das aulas sobres:
 * Abstração e Encapsulamento
 * Herança e Polimorfismo
 * Classes Abstratas e Interfaces com C#

## Introdução a Abstração e Encapsulamento em C#

Explorando o paradigma da programação orientada a objetos.

O que é a Programação Orientada a Objetos?

A POO é um paradigma de programação, ou seja, corresponde a uma técnica (conjunto de regras) de programação para um fim específico.

Dentro dessa técnica existem 4 pilares: Abstração, Encapsulamento, Herança e Polimorfismo.

O principal conceito da POO são classes e objetos.

Classe: é uma representação de um objeto da vida real (modelo).

Objeto: é uma instância da classe, que tem e emprega suas propriedades e métodos.

### Abstração

Abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.

Classe: Pessoa

Propriedades: Nome (string), Idade (int)

Métodos: Apresentar()

### Encapsulamento

O encapsulamento serve para proteger uma classe e definir os limites para alteração de suas propriedades.

Serve para ocultar seu comportamento e expor somente o necessário.

Classe: ContaCorrente

Propriedades: +Numero (int), -Saldo (decimal)

Métodos: +Sacar(decimal valor)

*Obs: Com sinal de positivo, pode ser consultado e alterado por fontes externas; com sinal negativo, apenas fontes internas podem alterar e consultar.*

O Encapsulamento é a proteção de propriedades para que apenas a própria classe possa alterar e consultar seu valor, definindo-a como private (privada). É a implementação de métodos, com lógicas condicionais que irão decidir se o valor será alterado ou consultado, e também construtores.

## Herança e Polimorfismo em C#

### Herança

A herança nos permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes.

Serve para agrupar objetos que são do mesmo tipo, porém com características diferentes.

É como ter uma classe generalista, que possui todas as características de determinadas outras classes. Essas classes herdam da classe generalista os atributos comuns, complementando-os com os atributos próprios de seu contexto, evitando duplicidades de código.

 * Exemplo:

Classe: Pessoa
Propriedades: +Nome (string), +Idade (int)
Métodos: +Apresentar()

Classe: Pessoa <--- Aluno (herda da classe Pessoa as propriedades Nome e Idade e o método Apresentar)
Propriedade: +Nota (double) // atributo exclusivo da classe Aluno

Classe: Pessoa <--- Professor (herda da classe Pessoa as propriedades Nome e Idade e o método Apresentar)
Propriedade: +Salario (decimal) // atributo exclusivo da classe Professor

*Obs: Manter sempre o contexto dos objetos, não aplicando a herança em objetos de diferentes contextos. Exemplo: Carro herdando de Pessoa.*

Para fazer uma classe herdar atributos de outra, inclui-se dois pontos (:) ao final do nome da classe que herda, seguido pelo nome da classe da qual os atributos são herdados.

 * Exemplo de sintaxe:

namespace NomeDoProjeto.Models


{

    public class ClasseQueHerda : ClasseQueDoa
    {  
        // métodos e propriedades
    }
}

*Dica: Evitar complexidade!*

É possível ter heranças em cascata, mas isso aumenta o nível de complexidade do código e o deixa vulnerável a quebras, caso seja necessário excluir alguma propriedade dos primeiros níveis. Também é chamada de "pai" ou "mãe" uma classe que doa atributos para outra, e esta, por sua vez, é chamada de "filha".

Em C#, não existe o conceito de múltiplas heranças. Cada classe pode herdar de uma única classe superior, não podendo herdar de várias classes no mesmo nível.

### Polimorfismo

O polimorfismo vem do grego e significa "muitas formas".

Com o polimorfismo, também conhecido como Override ou Late Binding, é possível sobrescrever métodos das classes filhas para que se comportem de maneira diferente e tenham sua própria implementação.

Sua sintaxe, já aplicada a herança descrita acima, requer a alteração da sintaxe do método da classe pai, incluindo a palavra reservada 'virtual' na sua definição.

 * Exemplo de sintaxe da classe pai:

public virtual void Apresentar(){

    // código do método da classe pai
    
}

E em seguida, utiliza-se a palavra reservada 'override' para definir um novo método na classe filha, que sobrescreverá o método da classe pai.

 * Exemplo de sintaxe da classe filha:

public override void Apresentar(){

    // código do método da classe filha, substituindo o código da classe pai
    
}

Esse é o polimorfismo em tempo de execução, que depende de herança. Existe também o polimorfismo em tempo de compilação, que não depende de herança.

Neste segundo caso, são definidos métodos com o mesmo nome, mas com número de parâmetros diferentes. Ao chamar o método, a quantidade de parâmetros passados determina qual método será chamado.

Para ver os exemplos, navegue pelos arquivos das classes no diretório Models e na classe Program.cs.

Faça um clone deste repositório e execute o comando 'dotnet run' para ver os exemplos na prática.

## Classes Abstratas e Interfaces Em C#

### Classe Abstrata

Uma classe abstrata tem como objetivo ser exclusivamente um modelo para ser herdado, portanto, não pode ser instanciada.

Você pode implementar métodos ou deixá-los a cargo de quem herdar.

 * Sintaxe de uma classe abstrata:

namespace Exemplo.Models
{

    public abstract class ClasseAbstrata
    {
        // Métodos e Propriedades da classe
    }

}

Com a palavra reservada 'abstract' na definição da classe, você indica que a classe não pode ser instanciada e apenas herdada. Também é possível utilizar essa palavra na definição de métodos abstratos e todo método criado como abstrato precisa ser implementado na classe filha, utilizando a palavra reservada 'override'.

É possível criar propriedades com a palavra reservada 'protected' em suas definições. Essa palavra indica que apenas classes filhas podem alterar o valor dessa propriedade.

### Classe Selada

Uma classe selada tem como objetivo impedir que outras classes façam herança dela, ou seja, nenhuma classe pode ser sua filha.

Também é possível ter métodos e propriedades seladas. Quando isso ocorre, impede que a classe filha possa sobrescrever métodos ou alterar e consultar valores de propriedades herdadas.

 * Exemplo de sintaxe de classe selada:

namespace Exemplo.Models
{

    public sealed class ClasseSelada
    {
        // Métodos e Propriedades da classe
    }

}

Assim, nenhuma classe pode ser filha dessa classe selada.

 * Exemplo de sintaxe de método selado:

namespace Exemplo.Models
{

    public class ClasseQueHerda : ClasseQueDoa 
    {
        public sealed override void Metodo()
        {
            // Implementação
        }
    }

}

Dessa forma, é possível herdar e criar uma nova filha da ClasseQueHerda, mas o seu método está selado e não pode ser sobrescrito pela classe filha. O comportamento será o mesmo do implementado na ClasseQueHerda.

### Classe Object

A classe System.Object é a mãe de todas as classes na hierarquia do .NET.

Todas as classes derivam, direta ou indiretamente, da classe Object. Ela tem como objetivo prover serviços de baixo nível para suas classes filhas.

Todas as outras classes criadas pelo programador herdam da Object vários métodos como ToString, Finalize, GetType, entre outros.

### Interfaces

Uma interface é um contrato que pode ser implementado por uma classe.

É como se fosse uma classe abstrata, podendo definir métodos abstratos para serem implementados.

Assim como uma classe abstrata, uma interface não pode ser instanciada.

O nome de uma interface sempre é iniciado com 'I'. Uma classe não herda de uma interface, mas sim a implementa.

Com interfaces, uma classe pode implementar várias interfaces ao mesmo tempo. Diferente da herança, que não existe o conceito de múltiplas heranças em C#.

Em uma interface não são usados os modificadores de acesso, como 'public', apenas o tipo do retorno do método é usado. Os métodos podem possuir escopo ou não. Para os métodos sem escopo, se faz obrigatória sua implementação na classe que implementa a interface, pois são apenas modelos. Já no métodos que possuem escopo dentro da interface, sua implementação na classe é opcional.

 * Sintaxe de uma classe implementando uma interface:

namespace Exemplo.Models
{

    public class Calculadora : ICalculadora
    {
        // implementar métodos da interface
    }

}

Uma interface não pode ser instanciada, mas pode receber uma instância da classe que a implementa, tornando suas operações válidas.
