# AirsoftTactical - Sistema de Gestão de Operações CQB

## Integrantes do Grupo
* **Henrique Teixeira Cesar** - RM: 563088 (Turma 2TDSPF)

## Domínio Escolhido
O projeto **AirsoftTactical** é uma WebAPI voltada para a gestão de campos de Airsoft, focada na modalidade CQB (Close Quarters Battle). O sistema gerencia o arsenal dos operadores, a organização de times e o agendamento de partidas.

## Entidades Modeladas
1. **Operador**: Representa o jogador, com validações de Nome, CallSign e CPF.
2. **Equipamento**: Itens do arsenal (Rifles, Pistolas) vinculados a um Operador (Dono).
3. **Campo**: Local físico onde ocorrem os jogos, com identificação de área tática.
4. **Partida**: Evento agendado em um campo com limite de jogadores e data/hora.
5. **Inscricao**: Gerencia o vínculo entre Operadores e Partidas (N:N), incluindo status de pagamento.
6. **Time**: Agrupamento de jogadores com nome e Tag.

## Relacionamentos e Cardinalidades
* **Operador (1) ↔ (N) Equipamento**: Um operador possui vários equipamentos; um equipamento pertence a um único dono (Obrigatório).
* **Campo (1) ↔ (N) Partida**: Um campo sedia diversas partidas; uma partida ocorre em um único campo (Obrigatório).
* **Operador (N) ↔ (N) Partida**: Relacionamento gerenciado pela entidade **Inscricao**.
* **Time (1) ↔ (N) Operador**: Um time tem vários membros; um operador pode ou não estar em um time (**Opcional**).

## Estrutura do Projeto
Seguindo as boas práticas e o padrão:
* **AirsoftTactical.Domain**: Contém as Entidades, Enums e a BaseEntity com lógica de validação nos construtores.
* **AirsoftTactical.Application**: Camada de lógica de aplicação estruturada.
* **AirsoftTactical.Infrastructure**: Camada de dados.
* **AirsoftTactical.API**: Projeto WebAPI em .NET 10.
