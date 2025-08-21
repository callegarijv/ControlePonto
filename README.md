# Sistema de Ponto Eletrônico - JVSYSTEMS

Este é um sistema de ponto eletrônico desenvolvido em C# com Entity Framework Core.  
O projeto foi criado para registrar horários de entrada, saída e intervalos dos funcionários, com funcionalidades de cadastro, validação de dados e geração de relatórios.

---

## Objetivo

O sistema tem como objetivo fornecer uma base sólida e funcional para controle de ponto de funcionários, com estrutura organizada e pronta para futuras expansões web e mobile.

---

## Funcionalidades

- Cadastro de usuários com senha criptografada (SHA256)
- Cadastro de funcionários com validação de nome e CPF
- Registro de batidas de ponto com data e hora
- Geração de relatórios de ponto por funcionário
- Estrutura separada em camadas: Models, Controllers, Validadores e Helpers

---

## Tecnologias utilizadas

- C# (.NET 6 ou superior)
- Entity Framework Core
- SQL Server (banco de dados)
- Console Application (modo texto)

---

## Estrutura do projeto

- **Program.cs** — ponto de entrada da aplicação
- **Models/** — classes que representam as entidades (Usuário, Funcionário, Batida de ponto)
- **Controllers/** — lógica de cadastro, registro de ponto e relatórios
- **Validadores/** — validações de entrada (nome, CPF, etc.)
- **Helpers/** — funções auxiliares (como criptografia de senha)
- **Data/** — contexto do banco de dados com EF Core

---

## Como executar o projeto

### Pré-requisitos

- .NET SDK 6.0 ou superior instalado
- Git (para clonar o repositório)

### Passos

1. Clone este repositório:
git clone https://github.com/callegarijv/JVSYSTEMS.git

2. Acesse a pasta do projeto:
cd JVSYSTEMS

3. Restaure: dotnet build
  
4. Execute: dotnet run


/JVSYSTEMS<br>
│<br>
├── Program.cs<br>
├── Models/<br>
│ ├── Usuario.cs<br>
│ ├── Funcionario.cs<br>
│ └── BatidaPonto.cs<br>
│<br>
├── Controllers/<br>
│ ├── CadastroUsuario.cs<br>
│ ├── CadastroFuncionario.cs<br>
│ ├── RegistroPonto.cs<br>
│ └── Relatorios.c<br>
|<br>
├── Helpers/<br>
│ └── HashHelper.cs<br>
│<br>
├── Validadores/<br>
│ ├── ValidadorCPF.cs<br>
│ └── ValidadorNome.cs<br>
│<br>
└── README.md<br>

