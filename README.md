# WebAPI em Clean Architecture

Este projeto é uma WebAPI desenvolvida seguindo os princípios da Clean Architecture, com o objetivo de fornecer uma estrutura modular, escalável e de fácil manutenção. A API utiliza diversos padrões e tecnologias modernas para garantir boas práticas de desenvolvimento, segurança e desempenho.

## Tecnologias e Padrões Utilizados

- **Clean Architecture**: Separação clara das responsabilidades em camadas (Domain, Application, Infrastructure, Presentation).
- **Padrão Repository e UnitOfWork**: Para abstração do acesso a dados e gerenciamento de transações.
- **DTO (Data Transfer Object)**: Para transferência de dados entre as camadas.
- **AutoMapper**: Para mapeamento automático entre entidades e DTOs.
- **HttpPatch**: Para atualizações parciais de recursos.
- **Paginação, Filtro e Ordenação**: Para melhorar a eficiência e usabilidade das consultas.
- **Async Repository**: Para operações assíncronas de acesso a dados.
- **Autenticação e Autorização**: Com suporte a Token JWT.
- **Segurança**: Implementação de CORS e Rate Limiting para proteção contra ataques.

## Estrutura do Projeto

O projeto está organizado em camadas, seguindo a Clean Architecture:

- **Domain**: Contém as entidades, interfaces de repositório e regras de negócio.
- **Application**: Contém os casos de uso, serviços, DTOs e mapeamentos com AutoMapper.
- **Infrastructure**: Implementação dos repositórios, UnitOfWork, configurações de banco de dados, autenticação, etc.
- **Presentation**: Contém os controllers, middleware e configurações da API.

## Configuração e Execução

### Pré-requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) ou [Visual Studio Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) ou outro banco de dados suportado pelo Entity Framework Core

### Configuração

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
