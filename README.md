# Introducao-Abstra-o-Encapsulamento-C-
Este repositório é um resumo da aula sobre Abstração e Encapsulamento do Bootcamp Decola Tech 2024 da DIO.me

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

Obs: Com sinal de positivo, pode ser consultado e alterado por fontes externas; com sinal negativo, apenas fontes internas podem alterar e consultar.

O Encapsulamento é a proteção de propriedades para que apenas a própria classe possa alterar e consultar seu valor, definindo-a como private (privada). É a implementação de métodos, com lógicas condicionais que irão decidir se o valor será alterado ou consultado, e também construtores.
