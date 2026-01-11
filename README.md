🐾 PetFolio
API REST para gerenciamento de pets e seus tutores, criada durante a Formação C# da Rocketseat.
O PetFolio foi pensado para ser a base de um sistema moderno de controle de pets, fichas, agendamentos e histórico, usando boas práticas de arquitetura em .NET.
​

📋 Sobre o Projeto
O PetFolio é uma API em ASP.NET Core que centraliza informações sobre pets e seus responsáveis, permitindo o cadastro e a consulta de dados de forma simples e escalável.
​
É um ótimo ponto de partida para estudos de C#, Entity Framework Core, boas práticas de REST e organização de projetos backend.
​

Principais objetivos do projeto:

Servir como base para um backend de clínica/veterinária/petshop.
​

Exercitar conceitos da formação C# (camadas, DTOs, validação, persistência).
​

Facilitar evolução futura com autenticação, autorização, agendamentos e relatórios.
​

🚀 Funcionalidades Principais
Obs.: Ajuste esta lista conforme o que o projeto já tem hoje.

Cadastro de pets (nome, espécie, raça, data de nascimento etc.).
​

Cadastro de tutores/responsáveis.
​

Associação pet ↔ tutor.
​

Endpoints para criação, listagem, atualização e remoção (CRUD) das entidades.
​

Validações básicas de entrada (model binding/annotations).
​

🛠️ Tecnologias Utilizadas
Linguagem & Runtime

C#

.NET / ASP.NET Core Web API
​

Persistência

Entity Framework Core

Banco relacional SQLite.
​
Swagger.
​

Ferramentas de desenvolvimento: Visual Studio / VS Code, Git e GitHub.
​

📦 Estrutura do Projeto
Adapte os nomes dos diretórios conforme a estrutura real da solução.

text
PetFolio/
├── src/
│   ├── PetFolio.Api/          # Projeto Web API (controllers, endpoints)
│   ├── PetFolio.Domain/       # Entidades de domínio e regras de negócio
│   ├── PetFolio.Infrastructure/ # Persistência (EF Core, migrations, repositórios)
│   └── PetFolio.Application/  # Casos de uso, DTOs e serviços de aplicação
└── tests/
    └── PetFolio.Tests/        # Testes automatizados (quando existirem)
Essa separação facilita manutenção, testes e evolução do código ao longo do tempo.
​

🔧 Como Rodar o Projeto
1. Pré-requisitos
.NET SDK instalado (versão usada na formação Rocketseat – ex.: .NET 8).
​

Um banco de dados compatível com o provider configurado (ex.: SQL Server local ou container Docker).
​

2. Clonar o repositório
bash
git clone https://github.com/leandromarqueti/PetFolio.git
cd PetFolio
3. Configurar o banco
Ajuste a connection string no appsettings.Development.json ou em variáveis de ambiente.
​

Rode as migrations (se configuradas):

bash
dotnet ef database update
4. Executar a API
bash
dotnet run --project src/PetFolio.Api
A API deverá ficar disponível em algo como:

https://localhost:5001 ou http://localhost:5000 (ajuste conforme seu launchSettings.json).
​

Se o Swagger estiver habilitado, você pode acessar:

https://localhost:5001/swagger

📡 Endpoints atuais

GET /api/pet – Lista todos os pets.

POST /api/pets – Cadastra um novo pet.

GET /api/pet/{i} – Busca detalhes de um pet.

PUT /api/pet/{id} – Atualiza um pet.

DELETE /api/pet/{id} – Remove um pet.

🤝 Contribuição
Este projeto foi criado para estudo, mas contribuições são bem-vindas:

Faça um fork do repositório.

Crie uma branch para sua feature/ajuste:

bash
git checkout -b feature/minha-feature
Implemente as mudanças e rode os testes (quando houver).

Envie um Pull Request descrevendo o que foi alterado.

📚 Créditos
Projeto desenvolvido durante a Formação C# da Rocketseat, adaptado e evoluído para estudos de arquitetura, boas práticas e APIs REST.
​
