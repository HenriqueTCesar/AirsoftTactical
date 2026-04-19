# AirsoftTactical - Sistema de Gestão de Operações CQB

## 🎯 CP2 - Persistência com EF Core e Camada de Infraestrutura

Este projeto contempla a implementação da camada de persistência e acesso a dados para o sistema de gestão de Airsoft, utilizando **Entity Framework Core** e seguindo os princípios da **Clean Architecture**.

## 👥 Integrantes do Grupo
* **Henrique Teixeira Cesar** - RM: 563088 (Turma 2TDSPF)

## 📖 Domínio Escolhido
O projeto **AirsoftTactical** é uma WebAPI voltada para a gestão de campos de Airsoft, focada na modalidade CQB (Close Quarters Battle). O sistema gerencia o arsenal dos operadores, a organização de times e o agendamento de partidas.

## 🛠️ Tecnologias e SGBD
* **Runtime**: .NET 10
* **SGBD**: Oracle Database (Infraestrutura FIAP)
* **ORM**: Entity Framework Core
* **Arquitetura**: Clean Architecture (Domain, Application, Infrastructure, API)

## 🗄️ Estrutura de Persistência
1. **Mapeamento (Fluent API)**: Todas as entidades foram mapeadas utilizando `IEntityTypeConfiguration<T>`, garantindo a separação entre o modelo de domínio e as regras de banco.
2. **Oracle Compatibility**: Implementado mapeamento customizado para tipos `bool` convertidos em `NUMBER(1)`, garantindo compatibilidade total com o Oracle.
3. **Repository Pattern**: Implementação de repositórios (ex: `OperadorRepository`) injetados via interface na camada de Application.
4. **Migrations**: Esquema de banco de dados versionado e gerado automaticamente.

## 🏗️ Estrutura do Projeto
* **AirsoftTactical.Domain**: Entidades de negócio e interfaces base.
* **AirsoftTactical.Application**: Interfaces de repositório e contratos de serviço.
* **AirsoftTactical.Infrastructure**: Implementação do `ApplicationDbContext`, configurações de Fluent API, Migrations e Repositórios.
* **AirsoftTactical.API**: Ponto de entrada, Controllers e configuração de Injeção de Dependência (DI).

## 🚀 Como Executar o Projeto

1. **Configurar a Connection String**:
   No arquivo `appsettings.json` do projeto **API**, insira suas credenciais do Oracle:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Data Source=oracle.fiap.com.br:1521/orcl;User Id=RMXXXXXX;Password=XXXXXX;"
   }
