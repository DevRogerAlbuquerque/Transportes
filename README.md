**API de Controle de Transportes**

Esta é uma Web API desenvolvida em C# utilizando uma arquitetura RESTful para controlar um módulo de transportes em um sistema.
A API oferece funcionalidades para gerenciar viagens, dados de viagem, caminhões, motoristas, rotas e precificação.

**Funcionalidades Principais**

- **Viagens**: Inclusão, listagem, atualização e remoção de viagens.
- **Dados de Viagem**: Detalhes como origem, destino, data e hora.
- **Caminhões**: CRUD para caminhões, incluindo tipo, capacidade, etc.
- **Motoristas**: Cadastro e gerenciamento de motoristas.
- **Rotas**: Definição e gestão de rotas para as viagens.
- **Precificação**: Cálculo de custos baseado em critérios específicos.

**Tecnologias Utilizadas**

- **C#** e **ASP.NET**: Linguagem e framework para o backend da API.
- **RESTful**: Implementação dos princípios REST para arquitetura da API.
- **SQL Server**: Banco de dados utilizado para armazenamento de dados relacionais.

**Pré-requisitos**

- Visual Studio 2022 ou superior
- .NET Core SDK 3 ou superior
- SQL Server Management Studio (opcional para gerenciamento do SQL Server)

**Instalação e Uso**

1. Clone o repositório: `git clone https://github.com/devrogeralbuquerque/transportes.git`
2. Abra o projeto no Visual Studio.
3. Configure a string de conexão com o banco de dados no arquivo `appsettings.json`. Ficará em: "ConnectionStrings": {
  "Transportes": "connectionstring"
}
4. Execute o projeto.

**Documentação da API**

Para informações detalhadas sobre os endpoints e como utilizá-los, consulte a documentação da API disponível em `/docs` ou `/swagger` após iniciar a aplicação.
