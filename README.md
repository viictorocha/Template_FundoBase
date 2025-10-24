# 📝 FundoBase - Guia de Instalação e Uso do Template

## 1. Conceitos

* **FundoBase** é um **template de projeto** padrão para novos fundos da empresa, baseado em **Clean Architecture** simplificado.
* Estrutura padrão do template:

```
FundoBase.sln
├── FundoBase.Api
├── FundoBase.Blazor
├── FundoBase.ConsoleApp
├── FundoBase.Data
├── FundoBase.Domain
├── FundoBase.Infra
├── FundoBase.Service
├── FundoBase.Tests
└── FundoBase.Worker
```

* Cada projeto possui responsabilidades isoladas seguindo **padrão de camadas**: `Domain → Data → Infra → Service → Api/Blazor/Worker`.

---

## 2. Pré-requisitos

* **.NET 9 SDK** ou superior instalado
* Visual Studio 2022 ou 2023 (opcional, mas recomendado)
* Powershell ou terminal para executar comandos `dotnet`
* Nenhum arquivo `.vs` dentro da pasta do template (remova se houver)

---

## 3. Instalação do Template FundoBase

1. Abra o terminal no diretório do template:

```powershell
cd D:\Desenvolvimento\Templates\FundoBase
```

2. Instale o template localmente:

```powershell
dotnet new install D:\Desenvolvimento\Templates\FundoBase
```

> ⚠️ Se já tiver instalado e quiser atualizar, use:

```powershell
dotnet new install D:\Desenvolvimento\Templates\FundoBase --force
```

3. Confirme se o template foi instalado:

```powershell
dotnet new list | findstr fundobase
```

Saída esperada:

```
Template de Projeto Fundo (Clean Architecture)  fundobase   [C#]    CleanArchitecture/Fundo/CSharp
```

---

## 4. Criando um Novo Projeto a partir do Template

1. Crie uma pasta separada para o novo fundo (não use a pasta do template):

```powershell
mkdir D:\Desenvolvimento\Projetos\FundoDebenture
cd D:\Desenvolvimento\Projetos
```

2. Execute o comando para gerar o projeto:

```powershell
dotnet new fundobase -n FundoDebenture
```

3. Estrutura gerada:

```
FundoDebenture/
├── FundoDebenture.Api
├── FundoDebenture.Blazor
├── FundoDebenture.ConsoleApp
├── FundoDebenture.Data
├── FundoDebenture.Domain
├── FundoDebenture.Infra
├── FundoDebenture.Service
├── FundoDebenture.Tests
└── FundoDebenture.Worker
```

4. Abra a solution no Visual Studio:

```powershell
start FundoDebenture.sln
```

---

## 5. Observações

* Sempre crie **novos fundos em pastas separadas**; nunca dentro da pasta do template.
* Remova qualquer `.vs` dentro do template antes da instalação.
* Todas as referências entre projetos já estão configuradas no template.
* As camadas seguem o padrão:

```
Domain → Data → Infra → Service → Api/Blazor/Worker
```

* Para testes, utilize `FundoDebenture.Tests` referenciando Service, Infra e Domain.

---

## 6. Responsabilidade de Cada Projeto

* **FundoDebenture.Domain**: Contém todas as entidades do negócio, objetos de valor, enums e regras de validação que representam o núcleo do domínio. Não depende de nenhuma outra camada e deve permanecer independente.

* **FundoDebenture.Data**: Implementa o `DbContext` do Entity Framework, repositórios e consultas de dados. Responsável por mapear as entidades do Domain para o banco e fornecer abstrações de acesso a dados.

* **FundoDebenture.Infra**: Implementa serviços de infraestrutura, como integração com APIs externas, filas, serviços de email, armazenamento em nuvem ou outros sistemas de terceiros. Deve fornecer interfaces que podem ser consumidas pela camada Service.

* **FundoDebenture.Service**: Orquestra casos de uso e lógica de negócio. Recebe dados da camada Domain e Infra, aplica regras do negócio e expõe métodos para APIs, Workers ou Blazor. Centraliza a lógica reutilizável para todas as aplicações do fundo.

* **FundoDebenture.Api**: Exposição de endpoints REST para consumo externo. Deve receber requisições, chamar a camada Service e retornar respostas padronizadas. Inclui autenticação, autorização e validação de entrada.

* **FundoDebenture.Blazor**: Interface web interativa para usuários finais usando Blazor WebAssembly. Consome a camada Service via APIs ou injeção de dependências local para apresentar dados e interagir com o usuário.

* **FundoDebenture.ConsoleApp**: Aplicações pontuais ou utilitários de linha de comando para execução de tarefas específicas, como importação de arquivos, migração de dados ou execução de rotinas manuais.

* **FundoDebenture.Worker**: Processos em background, rotinas agendadas ou tarefas recorrentes, como cálculos diários, envio de notificações ou sincronização de dados. Pode consumir Service e Infra.

* **FundoDebenture.Tests**: Contém testes unitários e de integração das camadas Domain, Service e Infra. Responsável por validar regras de negócio, consistência d
