# 🔗 SimpleApi

APIs mínimas são arquitetadas para criar APIs HTTP com dependências mínimas. Eles são ideais para microsserviços e aplicativos 
que desejam incluir apenas os arquivos, recursos e dependências mínimos no ASP.NET Core.

Este projeto implementa os conceitos básicos de construção de uma API Web mínima com ASP.NET Core integradas a um banco de dados PostgreSQL com Docker.


<p align="center">
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/HendricksSumeck/SimpleApi?color=%2304D361">

  <img alt="Repository size" src="https://img.shields.io/github/repo-size/HendricksSumeck/SimpleApi">

  <a href="https://github.com/HendricksSumeck/MinimalApi">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/HendricksSumeck/SimpleApi">
  </a>

  <a href="https://github.com/HendricksSumeck/MinimalApi/stargazers">
    <img alt="Stargazers" src="https://img.shields.io/github/stars/HendricksSumeck/SimpleApi?style=social">
  </a>
</p>

## 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

![NET Badge](https://img.shields.io/badge/.NET-5C2D91?style=flat-square&logo=.net&logoColor=white)
![C# Badge](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)
![PostgreSQL Badge](https://img.shields.io/badge/PostgreSQL-316192?style=flat-square&logo=postgresql&logoColor=white)
![Docker Badge](https://img.shields.io/badge/Docker-2496ED?style=flat-square&logo=docker&logoColor=white)
![windows Badge](https://img.shields.io/badge/Windows-017AD7?style=flat-square&logo=windows&logoColor=white)
![Git Badge](https://img.shields.io/badge/Git-E34F26?style=flat-square&logo=git&logoColor=white)

## Rodando localmente

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com), [.NET 6.0](https://dotnet.microsoft.com/en-us/download) e [Docker](https://docs.docker.com/desktop/windows/install/).

Além disto é bom ter uma IDE para trabalhar com o código como [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/) 
é uma ferramenta de administração de banco de dados como [DBeaver](https://dbeaver.io/download/).

### 🎲 Rodando o Back End (servidor)

```bash
# Clone este repositório
$ git clone git@github.com:HendricksSumeck/SimpleApi.git

# Acesse a pasta do projeto no terminal/cmd
$ cd SimpleApi

# Vá para a pasta MinimalApi
$ cd SimpleApi.Api

# Execute a aplicação
$ dotnet run

# O servidor inciará na porta:5000 - acesse https://localhost:5000/swagger/index.html
```

### <img src="https://img.icons8.com/color/26/000000/docker.png"/> Inicializando Docker do projeto

```bash
# Clone este repositório
$ git clone git@github.com:HendricksSumeck/SimpleApi.git

# Acesse a pasta do projeto no terminal/cmd
$ cd SimpleApi

# Execute o comando
$ docker-compose -p pgslq -d
```

### <img src="https://img.icons8.com/fluency/26/000000/database.png"/> Rodando as migrações do projeto

```bash
# Clone este repositório
$ git clone git@github.com:HendricksSumeck/SimpleApi.git

# Acesse a pasta do projeto no terminal/cmd
$ cd SimpleApi

# Criar as migrações do banco de dados
$ dotnet ef --startup-project SimpleApi.Infra.Data/ migrations add Inicial --context SimpleApiContext

# Executar para criar o banco
$ dotnet ef database update --startup-project SimpleApi.Infra.Data/ --context SimpleApiContext

# Ou

# Entrar no projeto SimpleApi.Migrator
$ cd SimpleApi.Migrator

# Executar o projeto
$ dotnet run
```

## 🚀 Autor

<img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/33631655?v=4" width="100px;" alt=""/>

[![GitHub Badge](https://img.shields.io/badge/Hendrick-100000?style=flat-square&logo=github&logoColor=white)](https://github.com/HendricksSumeck)
[![Linkedin Badge](https://img.shields.io/badge/-Hendrick-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/hendrick-sumeck-45a41918a/)](https://www.linkedin.com/in/hendrick-sumeck-45a41918a/) 
[![Gmail Badge](https://img.shields.io/badge/-hsumeck@gmail.com-c14438?style=flat-square&logo=Gmail&logoColor=white&link=hsumeck@gmail.com)](mailto:hsumeck@gmail.com)
