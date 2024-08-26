# API de Autenticação com JWT (OAuth2)

Este projeto é um exemplo de como implementar autenticação usando `Microsoft.AspNetCore.Authentication` e `JwtBearer` com `SecretKey` e `AccessToken`. Ele simula o acesso a métodos com diferentes roles: gerente, comprador, anônimo e autenticado.

## Funcionalidades

•  [**Login**](https://www.bing.com/search?form=SKPBOT&q=Login): Gera um token JWT para autenticação.

•  [**Acesso Anônimo**](https://www.bing.com/search?form=SKPBOT&q=Acesso%20An%C3%B4nimo): Endpoint acessível por qualquer pessoa.

•  [**Acesso Autenticado**](https://www.bing.com/search?form=SKPBOT&q=Acesso%20Autenticado): Endpoint acessível apenas por usuários autenticados.

•  [**Acesso Restrito a Gerente**](https://www.bing.com/search?form=SKPBOT&q=Acesso%20Restrito%20a%20Gerente): Endpoint acessível apenas por usuários com a role de gerente.

•  [**Acesso Restrito a Comprador e Gerente**](https://www.bing.com/search?form=SKPBOT&q=Acesso%20Restrito%20a%20Comprador%20e%20Gerente): Endpoint acessível por usuários com as roles de comprador ou gerente.


## Tecnologias Utilizadas

•  .NET 8

•  ASP.NET Core

•  JWT (JSON Web Token)

•  Swagger para documentação da API

•  Injeção de Dependência

•  Gerenciamento de Settings

•  Padrão de Design Builder


Injeção de Dependência
Este projeto utiliza injeção de dependência para gerenciar as dependências entre os componentes, facilitando a manutenção e a escalabilidade do código.

Gerenciamento de Settings
As configurações da aplicação, como a SecretKey para JWT, são gerenciadas através do arquivo appsettings.json, permitindo uma configuração centralizada e fácil de modificar.

Padrão de Design Builder
O padrão de design builder é utilizado para configurar e construir os serviços da aplicação, promovendo uma abordagem mais modular e organizada.

Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests. Sugestões e melhorias são sempre apreciadas.

Licença
Este projeto está licenciado sob a Licença MIT. Veja o arquivo LICENSE para mais detalhes.


MIT License

Copyright (c) 2024 Elizeu S Ferreira

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
