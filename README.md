# Sistema de Ponto Eletronico - ControlePonto
![CI](https://github.com/callegarijv/ControlePonto/actions/workflows/ci.yml/badge.svg)

Sistema de ponto eletronico em C# com Entity Framework Core, focado em cadastro,
validacao de dados e relatorios de batidas.

## Objetivo

Fornecer uma base solida e funcional para controle de ponto de funcionarios,
com estrutura organizada para evolucoes futuras (web e mobile).

## Funcionalidades

- Cadastro de usuarios com senha criptografada (SHA256)
- Cadastro de funcionarios com validacao de nome e CPF
- Registro de batidas de ponto com data e hora
- Geracao de relatorios de ponto por funcionario
- Separacao por camadas: Models, Controllers, Validadores e Helpers

## Tecnologias utilizadas

- C# (.NET 9)
- Entity Framework Core 9
- SQLite (padrao)
- SQL Server (opcional para evolucao futura)
- Console Application

## Estrutura do projeto

```
ControlePonto/
├── src/ControlePonto/Program.cs
├── src/ControlePonto/Models/
│   ├── Usuario.cs
│   ├── Funcionario.cs
│   └── BatidaPonto.cs
├── src/ControlePonto/Controllers/
│   ├── CadastroUsuario.cs
│   ├── CadastroFuncionario.cs
│   ├── RegistroPonto.cs
│   └── Relatorios.cs
├── src/ControlePonto/Helpers/
│   └── HashHelper.cs
├── src/ControlePonto/Validadores/
│   ├── ValidadorCPF.cs
│   └── ValidadorNome.cs
├── src/ControlePonto/Migrations/
├── tests/ControlePonto.Tests/
└── README.md
```

## Banco de dados

- As migrations ficam em `src/ControlePonto/Migrations`.
- O arquivo `controleponto.db` eh criado localmente e fica ignorado no Git.

Para criar ou atualizar o banco:

```
dotnet tool install --global dotnet-ef
dotnet ef database update --project src/ControlePonto/ControlePonto.csproj
```

## Como executar o projeto

```
git clone https://github.com/callegarijv/ControlePonto.git
cd ControlePonto
dotnet restore
dotnet run --project src/ControlePonto/ControlePonto.csproj
```

## Testes

```
dotnet test
```

## CI

O workflow de CI valida build e testes a cada push/PR. O status aparece no badge
do topo do README.

## Em estudo / proximos passos

- Melhorar regras de negocio e relatorios
- Criar API REST para consumo web/mobile
- Adicionar autenticacao e permissao
- Evoluir cobertura de testes e automatizacoes
