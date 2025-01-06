# Exercícios de SOLID com C# 

Este repositório visa trazer exercícios de SOLID utilizando C# para apoiar nos estudos.

## Como usar

Existe uma `Solution Folder` para cada um dos princípios do SOLID, e cada exercício está em um projeto separado, possibilitando assim a execução individualmente de cada um.

Na branch `main`, encontram-se os exercícios a serem realizados.
Clone ou faça um fork desta branch para realizar os exercícios.

_Se você ainda não fez os exercícios, vá agora pra branch `main` e retorne para a branch `solution` apenas quando finalizá-los._

Na branch `solution`, encontram-se possíveis soluções para os exercícios para serem utilizadas de base na validação.

No tópico [Exercícios](#exercícios) estão listadas as explicações da solução de cada exercício.

## Exercícios

### SRP

#### Exercício 1

A classe `User` violava o SRP, pois estava lidando tanto com lógica de negócios quanto com a persistência de dados.

Explicação da solução:
- A classe `User` agora é apenas um modelo de dados.
- A classe `UserValidator` é responsável apenas por validar as regras de negócio do usuário.
- A classe `UserRepository` cuida apenas da persistência dos dados.

Isso garante que cada classe tenha uma única responsabilidade, facilitando manutenção e testes.

#### Exercício 2

A classe `SalaryCalculator` violava o SRP porque estava misturando a lógica de cálculo com a exibição do resultado.

Explicação da solução:
- A classe `SalaryCalculator` agora é responsável apenas por realizar cálculos.
- A classe `SalaryPresenter` é responsável pela exibição dos resultados.

Isso separa as responsabilidades, facilitando a manutenção e testes.

#### Exercício 3

A classe `ReportGenerator` violava o SRP porque possuia um método muito extenso que realizava várias tarefas.

Explicação da solução:
- O método `GenerateReport` foi dividido em métodos privados menores (`ProcessData`, `CreateReport`, `SendReport`) que realizam tarefas específicas.
- Isso melhora a legibilidade, facilita a manutenção e torna o código mais organizado.

## Referências

- Os exercícios foram desenvolvidos com ajuda do [ChatGPT](https://chatgpt.com/).
