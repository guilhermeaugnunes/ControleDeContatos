# Controle de Contatos

## Sobre o Projeto
Este sistema de gerenciamento de contatos foi desenvolvido em ASP.NET Core MVC como parte de estudos avançados em arquitetura de software e persistência de dados. A aplicação permite o controle centralizado de informações de contatos, garantindo a integridade dos dados através de validações rigorosas e tratamento de exceções.

O projeto implementa as operações fundamentais de um CRUD (Create, Read, Update e Delete), assegurando que a manipulação dos registros no banco de dados ocorra de forma segura e organizada.

## Funcionalidades
- Gerenciamento completo de registros de contatos (Inserção, Leitura, Atualização e Exclusão).
- Validação de dados de entrada via Data Annotations (E-mail, Telefone e campos obrigatórios).
- Tratamento de exceções e programação defensiva para evitar falhas críticas durante a execução.
- Sistema de mensagens temporárias (TempData) para feedback de operações ao usuário.

## Tecnologias Utilizadas
- **Linguagem:** C#
- **Framework:** ASP.NET Core MVC
- **ORM:** Entity Framework Core
- **Banco de Dados:** SQL Server (instância SQLEXPRESS)
- **Frontend:** Bootstrap e Razor Pages
- **Versionamento:** Git e GitHub

## Arquitetura de Software
A aplicação foi estruturada seguindo o padrão arquitetural **MVC (Model-View-Controller)** para garantir a separação de responsabilidades:

- **Model (Modelo):** Responsável pelo gerenciamento dos dados, lógica de negócio e regras de validação.
- **View (Visão):** Camada de interface responsável pela exibição das informações ao usuário.
- **Controller (Controlador):** Atua como o coordenador do fluxo, processando requisições e vinculando os modelos às visões.

Adicionalmente, foi aplicado o **Repository Pattern** em conjunto com a **Injeção de Dependência**, promovendo um código mais limpo, testável e de fácil manutenção.

## Configuração do Ambiente

### Pré-requisitos
- .NET SDK (6.0 ou superior)
- SQL Server Management Studio (SSMS) / SQL Express
- Visual Studio 2022

### Instalação e Execução
1. Clone este repositório para sua máquina local.
2. No arquivo `appsettings.json`, configure a string de conexão para apontar para o seu servidor local:
   ```json
   "ConnectionStrings": {
     "DataBase": "Server=.\\SQLEXPRESS;Database=DB_SistemaContatos;Integrated Security=True;TrustServerCertificate=True"
   }
3. Abra o **Console do Gerenciador de Pacotes** no Visual Studio e execute as migrações para criar a estrutura do banco de dados:
   ```powershell
   Update-Database
4. Execute a aplicação (F5).
