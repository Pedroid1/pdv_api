<h1 align="center">PDV API - Backend para Lançamento de Pedidos</h1>

<p align="center">
  <a href="https://wa.me/+5574999637391"><img alt="WhatsApp" src="https://img.shields.io/badge/WhatsApp-25D366?style=for-the-badge&logo=whatsapp&logoColor=white"/></a>
  <a href="https://www.linkedin.com/in/pedro-henrique-de-souza-araujo/"><img alt="Linkedin" src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white"/></a>
  <a href="mailto:pedro.steam2016@hotmail.com"><img alt="Gmail" src="https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white"/></a>
</p>
<p align="center">  
⭐ API desenvolvida em .NET Core para comunicação com o aplicativo Android PDV APP. A API permite a criação, listagem e exclusão de pedidos, armazenando os dados temporariamente em memória.

### A API possui dois endpoints principais:
- #### POST /api/pedidos
  - Recebe um JSON com os dados do pedido e retorna uma mensagem de sucesso ou erro.
 
- #### GET /api/pedidos
  - Retorna uma lista de todos os pedidos cadastrados no formato JSON.
</p>

## Tecnologias usadas e bibliotecas
- .NET Core / .NET 6+
- ASP.NET Core Web API
- C#
- Dependency Injection

## Como rodar o projeto
- Clone o repositório
  - git clone https://github.com/Pedroid1/pdv_api.git
  - cd pdv_api
- Instale o .NET SDK (caso ainda não tenha instalado)
  - [Download do SDK .NET](https://dotnet.microsoft.com/en-us/download/dotnet/6.0
- Execute o projeto
  - dotnet run

## Melhorias futuras
- Adicionar persistência com banco de dados.
- Implementar autenticação e autorização.
- Criar testes unitários para o backend.

