# SDC-API
![Heroku](https://heroku-badge.herokuapp.com/?app=heroku-badge)  ![travis](https://travis-ci.org/pierlabs/sdc-api.svg?branch=master)

### API desenvolvida para a 15ª semanda da computação da UFPB em 2016

Essa API tem como objetivo simular os métodos básicos de uma administradora de cartão de crédito. Resolvemos escrever uma API que fosse de fácil entendimento e simples para desenvolver. Nesse projeto não só temos ao API como vários SDKs para consumo. 

## API Endpoints

Temos dois principais recursos expostos na API, Contas e Cartões.

### Endpoint Contas
MÉTODO | URL | DESCRIÇAO
-------|-----|-----------
    GET | /v1/contas | Retorna todas as contas
    GET | /v1/contas/{id} | Retorna uma conta
    POST | /v1/contas | Cria uma conta
    PUT | /v1/contas | Atualiza uma conta 
    DELETE | /v1/contas/{id} | Deleta uma conta

### Endpoint Cartões 
MÉTODO | URL | DESCRIÇAO
-------|-----|-----------    
    GET | /v1/contas/{idConta}/cartoes | Retona todos os cartão de uma conta
    POST| /v1/contas/{idConta}/cartoes | Cria um cartão
    PUT | /v1/contas/{idConta}/cartoes | Atualiza um cartão
    GET | /v1/contas/{idConta}/cartoes/{idCartao} |Retorna um cartão
    PUT |/v1/contas/{idConta}/cartoes/{idCartao}/bloquear | Bloquear um cartão.
 DELETE |/v1/contas/{idConta}/cartoes/{idCartao}/cancelar|Cancelar um cartão
    PUT | /v1/contas/{idConta}/cartoes/{idCartao}/creditar | Creditar dinheiro em um cartão
    PUT | /v1/contas/{idConta}/cartoes/{idCartao}/desbloquear | Desbloquear um cartão.
    POST|/v1/contas/{idConta}/cartoes/{idCartao}/extratos | Retonar os extratos de transaçoes do cartão
    GET | /v1/contas/{idConta}/cartoes/{idCartao}/limite | Consultar o limite de um determinado cartão
    PUT | /v1/contas/{idConta}/cartoes/{idCartao}/transacionar | Transacionar valores
    POST|/v1/contas/{idConta}/cartoes/{idCartao}/transferir| Transferir valores entre dois cartões distintos



## Tecnologias Utilizadas

- Java 8
- Spring( Boot, MVC, AOP, Data, Actuator, Test e Devtools)
- Dropwizard Metrics
- Base H2
- Jackson
- Swagger
- Guava
- JUnit
- Springfox
- Lombok
- Tomcat
- Maven

## Requerimentos

- Java 8+
- Maven 3+
- Lombok 1.16+

## SDKs
Para utilizar algum SDK basta fazder o clone do projeto, ir até a pasta `sdc-sdks` e escolher qual linguagem deseja utilizar. Temos os seguintes SDKs desenvolvidos:

- [sdc-sdk-android](https://github.com/devconductor/sdc-api/tree/master/sdc-sdks/sdc-sdk-android)
- [sdc-sdk-clojure](https://github.com/devconductor/sdc-api/tree/master/sdc-sdks/sdc-sdk-clojure)
- [sdc-sdk-csharp](https://github.com/devconductor/sdc-api/tree/master/sdc-sdks/sdc-sdk-csharp)
- [sdc-sdk-java](https://github.com/devconductor/sdc-api/tree/master/sdc-sdks/sdc-sdk-java)
- [sdc-sdk-javascript](https://github.com/devconductor/sdc-api/tree/master/sdc-sdks/sdc-sdk-javascript)
- [sdc-sdk-objc](https://github.com/devconductor/sdc-api/tree/master/sdc-sdks/sdc-sdk-objc)
- [sdc-sdk-php](https://github.com/devconductor/sdc-api/tree/master/sdc-sdks/sdc-sdk-php)
- [sdc-sdk-python](https://github.com/devconductor/sdc-api/tree/master/sdc-sdks/sdc-sdk-python)
- [sdc-sdk-ruby](https://github.com/devconductor/sdc-api/tree/master/sdc-sdks/sdc-sdk-ruby)
- [sdc-sdk-swift](https://github.com/devconductor/sdc-api/tree/master/sdc-sdks/sdc-sdk-swift)

## Build
Partindo do suposto que você já tem o maven em seu classpath, basta seguir os seguintes passos para realizar o build:

1 - baixar o projeto
```
git clone https://github.com/devconductor/sdc-api.git
cd sdc-api
```

2 - Executar o empacotamento
```
  mvn clean package
```
## Demo

Subimos a API no [heroku](https://sdc-api.herokuapp.com) para que você possa utilizar. Você pode testar a API utilizando uma dessas duas interfaces, [https://sdc-api.herokuapp.com](https://sdc-api.herokuapp.com) ou [https://sdc-api.herokuapp.com/swagger-ui.html](https://sdc-api.herokuapp.com/swagger-ui.html).

## Screenshots

### [API Browser 01](https://sdc-api.herokuapp.com/swagger-ui.html)

![swagger-ui-1](https://raw.githubusercontent.com/pierlabs/sdc-api/master/sdc-api/src/main/resources/static/images/swagger-ui-01.png)

### [API Browser 02](https://sdc-api.herokuapp.com)
![swagger-ui-2](https://raw.githubusercontent.com/pierlabs/sdc-api/master/sdc-api/src/main/resources/static/images/swagger-ui-02.png)
