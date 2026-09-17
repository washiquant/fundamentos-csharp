# 💻 Desenvolvimento Back-End — SENAI

> Repositório de estudos, exercícios e projetos do curso **presencial** de Desenvolvimento Back-End do SENAI.
> Stack: **C# / .NET** e ecossistema Microsoft.
> Mantido durante minha graduação em **Análise e Desenvolvimento de Sistemas (ADS)**.

![Status](https://img.shields.io/badge/status-em%20andamento-yellow)
![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)
![Instituição](https://img.shields.io/badge/institui%C3%A7%C3%A3o-SENAI-blue)
![Modalidade](https://img.shields.io/badge/modalidade-presencial-lightgrey)

---

## 📖 Sobre o repositório

Aqui ficam registrados todos os materiais produzidos ao longo do curso: anotações de aula, exercícios de fixação, algoritmos, scripts SQL, APIs e projetos práticos — todos desenvolvidos em **C#** sobre a plataforma **.NET**.

O objetivo é duplo:

- **Consolidar o aprendizado** — escrever e versionar o código força a revisão do conteúdo.
- **Construir portfólio** — cada módulo entrega algo demonstrável.

---

## 🛠️ Stack e ferramentas

| Categoria | Ferramentas |
|---|---|
| Linguagem | C# |
| Plataforma | .NET (SDK 8 LTS / 9) |
| API | ASP.NET Core Web API (Minimal APIs e Controllers) |
| ORM / Dados | Entity Framework Core, ADO.NET |
| Banco de dados | SQL Server (SSMS) |
| Documentação de API | Swagger / OpenAPI |
| Testes | xUnit, Postman |
| IDE | Visual Studio 2022 / VS Code |
| Versionamento | Git + GitHub |
| Publicação | IIS / Azure App Service |

---

## 📂 Estrutura do repositório

```
.
├── 01-ambiente-desenvolvimento/
├── 02-levantamento-requisitos/
├── 03-metodologias/
├── 04-logica-algoritmos/
├── 05-fundamentos-csharp/
├── 06-poo/
├── 07-protocolo-http/
├── 08-frameworks/
├── 09-banco-de-dados/
├── 10-sql/
├── 11-persistencia-dados/
├── 12-apis/
├── 13-seguranca-informacao/
├── 14-validacao-sistemas/
├── 15-implantacao/
├── 16-melhoria-continua/
├── 17-publicacao/
└── projetos/
```

Cada pasta segue o mesmo padrão interno:

```
NN-modulo/
├── README.md        # resumo teórico do módulo
├── anotacoes/       # material de aula
├── exercicios/      # atividades propostas (projetos console)
└── projeto/         # entrega prática, quando houver
```

---

## 🧭 Ementa do curso

Conteúdo programático oficial, usado como roteiro de estudo e checklist de progresso.

<details open>
<summary><strong>1. Ambiente de desenvolvimento web</strong></summary>

- [ ] Definição, histórico e características
- [ ] Ambiente de desenvolvimento
  - [ ] Instalação e configuração do .NET SDK e da IDE
  - [ ] Recursos e interfaces
  - [ ] Gerenciamento de dependências (NuGet)

</details>

<details>
<summary><strong>2. Levantamento de requisitos</strong></summary>

- [ ] Brainstorm
- [ ] Questionário
- [ ] Entrevista
- [ ] Etnografia
- [ ] Workshop
- [ ] Prototipagem

</details>

<details>
<summary><strong>3. Metodologias de desenvolvimento</strong></summary>

- [ ] Metodologias clássicas
- [ ] Metodologias ágeis

</details>

<details>
<summary><strong>4. Lógica de programação e algoritmos</strong></summary>

- [ ] Algoritmos: descritivo, fluxogramas, decisões, repetições, estruturas de dados
- [ ] Lógica proposicional
- [ ] Operadores aritméticos, lógicos e relacionais

</details>

<details>
<summary><strong>5. Linguagem de programação (C#)</strong></summary>

- [ ] Variáveis e constantes
- [ ] Operadores
- [ ] Laços de repetição (`for`, `while`, `foreach`) e condicionais (`if`, `switch`)
- [ ] Classes e métodos
- [ ] Bibliotecas: manipulação e conversão de arquivos (`System.IO`)
- [ ] Documentação de software (comentários XML)

</details>

<details>
<summary><strong>6. Programação orientada a objetos</strong></summary>

- [ ] Definição e namespaces
- [ ] Classes (abstratas, aninhadas, anônimas)
- [ ] Atributos, propriedades e métodos
- [ ] Modificadores de acesso (encapsulamento)
- [ ] Objetos e interfaces
- [ ] Polimorfismo e enumerações (`enum`)
- [ ] Relacionamentos: herança, agregação e composição

</details>

<details>
<summary><strong>7. Protocolo HTTP</strong></summary>

- [ ] Definição do protocolo
- [ ] Métodos: `GET`, `POST`, `PUT`, `DELETE`, `PATCH`, `OPTIONS`
- [ ] Passagem de parâmetros: query e body
- [ ] Cabeçalhos: `Host`, `Accept`, `User-Agent`, `Accept-Language`, `Content-Type`, `Authorization`
- [ ] Media types: application, text, video, image, vnd
- [ ] Códigos de status:
  - `1xx` informacionais
  - `2xx` sucesso
  - `3xx` redirecionamento
  - `4xx` erros do cliente
  - `5xx` erros do servidor

</details>

<details>
<summary><strong>8. Frameworks</strong></summary>

- [ ] Modelagem e padrões de interface
- [ ] Classes de elementos gráficos e propriedades dos objetos
- [ ] Tipos de aplicação (Console, Web API, Blazor, WinForms)
- [ ] IDE, depuração e configurações
- [ ] Versionamento e documentação

</details>

<details>
<summary><strong>9. Banco de dados</strong></summary>

- [ ] Gerenciadores: características e requisitos
- [ ] Preparação do ambiente: instalação e configuração do SQL Server

</details>

<details>
<summary><strong>10. Linguagem de consulta (SQL)</strong></summary>

- [ ] DDL — tabelas, campos e relações
- [ ] DML — consulta, atualização, inserção e exclusão
- [ ] Procedimentos armazenados
- [ ] Triggers

</details>

<details>
<summary><strong>11. Persistência de dados</strong></summary>

- [ ] Conexão com a base de dados (ADO.NET / EF Core)
- [ ] CRUD
- [ ] Transferência de arquivos locais para o servidor
- [ ] Geração de relatórios
- [ ] Manipulação de dados com XML e JSON

</details>

<details>
<summary><strong>12. Linguagem de programação para APIs</strong></summary>

- [ ] Definição, formatos e aplicação
- [ ] Protocolo de comunicação
- [ ] Metodologias ágeis aplicadas a APIs
- [ ] Segurança da informação
- [ ] Funcionalidades e técnicas de depuração
- [ ] Documentação do sistema (Swagger/OpenAPI)
- [ ] Técnicas de programação e controle
- [ ] Frameworks (ASP.NET Core)
- [ ] Status de respostas e tratamento de exceções
- [ ] Formatos de comunicação e requisição (XML e JSON)

</details>

<details>
<summary><strong>13. Segurança da informação</strong></summary>

- [ ] Políticas de segurança
- [ ] Criptografia
- [ ] Perfis de usuários e controle de acesso (JWT / Identity)
- [ ] Proteção de dados pessoais (LGPD)
- [ ] Auditoria de acesso

</details>

<details>
<summary><strong>14. Validação de sistemas</strong></summary>

- [ ] Testes server-side: motivação, objetivos e posição no processo
- [ ] Escolha da estratégia de validação
- [ ] Aspectos funcionais e não funcionais

</details>

<details>
<summary><strong>15. Implantação de sistemas</strong></summary>

- [ ] Características de hardware e software
- [ ] Configuração de servidores
- [ ] Parametrização de protocolos
- [ ] Documentação de implantação

</details>

<details>
<summary><strong>16. Melhoria contínua</strong></summary>

- [ ] Ferramentas de análise
- [ ] Redução de desperdício
- [ ] Aumento de rendimento

</details>

<details>
<summary><strong>17. Publicação da aplicação</strong></summary>

- [ ] Publish, deploy e disponibilização do sistema

</details>

---

## 📈 Progresso

| Módulos | Concluídos |
|---|---|
| 17 | 3 |

`▱▱▱▱▱▱▱▱▱▱` 20%

---

## 🚀 Como executar

Pré-requisitos: [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```bash
# clonar o repositório
git clone https://github.com/washiquant/<nome-do-repo>.git

# entrar na pasta do projeto desejado
cd <nome-do-repo>/05-fundamentos-csharp

# restaurar dependências e executar
dotnet restore
dotnet run
```

Verificar a versão instalada do SDK:

```bash
dotnet --version
```

Cada projeto possui um `README.md` próprio com as instruções específicas.

---

## 🤝 Contribuições

Este é um repositório de estudos pessoais, mas sugestões, correções e feedbacks são muito bem-vindos — abra uma *issue* ou envie um *pull request*.

---

## 👤 Autor

**Washington Willian** — Estudante de Análise e Desenvolvimento de Sistemas

[![GitHub](https://img.shields.io/badge/GitHub-181717?style=flat&logo=github&logoColor=white)](https://github.com/washiquant)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/<seu-perfil>)

---

<p align="center">Feito durante o curso de Desenvolvimento Back-End do SENAI 🏭</p>
