# Exercícios de SOLID com C# 

Este repositório visa trazer exercícios de SOLID utilizando C# para apoiar nos estudos.

## Como usar

Existe uma `Solution Folder` para cada um dos princípios do SOLID, e cada exercício está em um projeto separado, possibilitando assim a execução individualmente de cada um.

Na branch `main`, encontram-se os exercícios a serem realizados.
Clone ou faça um fork desta branch para realizar os exercícios.

No tópico [Exercícios](#exercícios) estão listados todos os exercícios, explicando o que deverá ser feito em cada um. Há também dicas disponíveis para cada exercício, que estão ocultas — evite usá-las sem necessidade para treinar melhor seus conhecimentos.

Na branch `solution`, encontram-se possíveis soluções para os exercícios para serem utilizadas de base na validação.

## Exercícios

### SRP

#### Exercício 1

A classe `User` viola o SRP. Refatore o código aplicando o Princípio de Responsabilidade Única.

<details>
<summary>Dica</summary>

A classe `User` viola o SRP, pois está lidando tanto com lógica de negócios quanto com a persistência de dados.

Separe as preocupações de validação e persistência de dados em classes diferentes.

</details>

#### Exercício 2

A classe `SalaryCalculator` viola o SRP. Refatore o código aplicando o Princípio de Responsabilidade Única.

<details>
<summary>Dica</summary>

A classe `SalaryCalculator` viola o SRP porque está misturando a lógica de cálculo com a exibição do resultado.

Separe a lógica de cálculo e a exibição do resultado.

</details>

#### Exercício 3

A classe `SalaryCalculator` viola o SRP. Refatore o código aplicando o Princípio de Responsabilidade Única.

<details>
<summary>Dica</summary>

A classe `ReportGenerator` viola o SRP porque possui um método muito extenso que realiza várias tarefas.

Divida o método `GenerateReport` em métodos privados menores que realizam tarefas específicas dentro da mesma classe.

</details>

## Referências

- Os exercícios foram desenvolvidos com ajuda do [ChatGPT](https://chatgpt.com/).
