TresCamadas — Web API (.NET 8) com Clean Architecture, EF Core e CRUD

Projeto pessoal técnico para demonstrar domínio de Clean Architecture, separação de responsabilidades, e Entity Framework Core em uma aplicação 3 camadas. O objetivo é apresentar um código organizado, testável e escalável, com operações CRUD completas.

🎯 Objetivos

Consolidar Clean Architecture com limites claros entre camadas.

Aplicar SOLID (principalmente SRP e DIP) e boas práticas.

Implementar CRUD com Entity Framework Core (SQLite por padrão).

Facilitar manutenção, testes e evolução do projeto.

🏗️ Arquitetura em 3 Camadas

API (Presentation): Endpoints HTTP minimalistas/Controllers, validação e mapeamentos DTO ↔ Domain.

Application/Domain (Core): Regras de negócio, entidades e contratos (interfaces de repositório/serviços).

Infrastructure/Data: EF Core, DbContext, mapeamentos e repositórios concretos.

🧰 Tecnologias & Boas Práticas

.NET 8, ASP.NET Core Web API

Entity Framework Core (SQLite/SQL Server)

FluentValidation (opcional) para regras de entrada

 mapeamento 

Injeção de Dependências nativa

Convenções de REST e respostas padronizadas


👤 Autor

Thiago Morais — Analista/Desenvolvedor .NET
