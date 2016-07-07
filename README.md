# SDC-API
### API desenvolvida para a 15ª semanda da computação da UFPB em 2016

Essa API tem como objetivo simular os métodos básicos de uma administradora de cartão de crédito. Resolvemos escrever uma API que fosse de fácil entendimento e simples para desenvolver. Nesse projeto não só temos ao API como vários SDKs para consumo. 

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
