# SDC-API
![Heroku](https://heroku-badge.herokuapp.com/?app=heroku-badge)  ![travis](https://travis-ci.org/pierlabs/sdc-api.svg?branch=master)
![jitpack](https://jitpack.io/v/pierlabs/sdc-api.svg)

### API desenvolvida para a 15ª semanda da computação da UFPB em 2016

Essa API tem como objetivo simular os métodos básicos de uma administradora de cartão de crédito. Resolvemos escrever uma API que fosse de fácil entendimento e simples para desenvolver. Nesse projeto não só temos a API como vários SDKs para consumo. 

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
Para utilizar algum SDK basta fazer o clone do projeto, ir até a pasta `sdc-sdks` e escolher qual linguagem deseja utilizar. Temos os seguintes SDKs desenvolvidos:

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

## Utilização

Para que você consiga consumir a API é necessário ter em mãos um `TOKEN` de acesso. Esse token pode ser obtido fazendo o seu cadastro no portal do [PIER Labs](htttp://pierlabs.io). Abaixo segue os passos que você deve seguir para obter o seu token.

Entre no portal do [PIER Labs](htttp://pierlabs.io), clique em [Cadastre-se](http://pierlabs.io/api-portal/user/register), preencha os dados e clique em `Criar nova conta`, depois do cadastro efetuado no menu clique em `Desenvolvedor` -> `Minhas Aplicações`, em seguida clique em [Criar Aplicação](http://pierlabs.io/api-portal/myapps/new). Depois da aplicação cadastrada basta clicar no nome da aplicação que você acabou de cadastrar, em seguida clique em `Details` para ver o token que foi criado para você. Essa será a sua chave de acesso a nossa API.

Subimos a API em [https://api.conductor.com.br/sdc/](https://api.conductor.com.br/sdc/) para que você possa utilizar. 

## Exemplos

A forma de consumo mais fácil da nossa API é utilizando os nossos SDKs. Todos os SDK estão em um submodulo desse projeto. No exemplo abaixo vamos utilizar o `sdc-sdk-java`. Para adicionar o mesmo em seu projeto primeiro crie um projeto `maven` e em seguida adicione as seguintes configurações em seu `pom.xml`.

## Consumo em Java

### Maven 

#### Repositórios
```xml
	<repositories>
		<repository>
		    <id>jitpack.io</id>
		    <url>https://jitpack.io</url>
		</repository>
	</repositories>
```

#### Dependência
```xml
	<dependency>
	    <groupId>com.github.pierlabs.sdc-api</groupId>
	    <artifactId>sdc-sdk-java</artifactId>
	    <version>1.0.1</version>
	</dependency>
```

### Gradle

#### Repositórios
```groovy
	allprojects {
		repositories {
			...
			maven { url "https://jitpack.io" }
		}
	}
```

#### Dependência
```groovy
	dependencies {
	        compile 'com.github.pierlabs.sdc-api:sdc-sdk-java:1.0.1'
	}
```


Abaixo segue uma classe Java consumindo as principais funcionalidades da API. Antes de tudo lembre de se cadastrar no [PIER Labs](htttp://pierlabs.io) para pegar seu acess_token e client_id, depois basta seguir o exemplo abaixo.

```java

import br.com.conductor.sdc.api.v1.CartaoApi;
import br.com.conductor.sdc.api.v1.ContaApi;
import br.com.conductor.sdc.api.v1.invoker.ApiClient;
import br.com.conductor.sdc.api.v1.invoker.ApiException;
import br.com.conductor.sdc.api.v1.invoker.auth.ApiKeyAuth;
import br.com.conductor.sdc.api.v1.model.Cartao;
import br.com.conductor.sdc.api.v1.model.Conta;
import br.com.conductor.sdc.api.v1.model.Extrato;
import br.com.conductor.sdc.api.v1.model.Limite;

public class Main{
     
     public static void main(String[] args) throws ApiException {

          /**
           * Configurando a api
           */
          ApiClient api = new ApiClient();
          api.setBasePath("https://api.conductor.com.br/sdc");
          
          /**
           * Setando o access_token e client_id de acesso. Você pode conseguir os seus se cadastrando em http://pierlabs.io
           */
          ((ApiKeyAuth) api.getAuthentication("access_token")).setApiKey("ACCESS_TOKEN");
          ((ApiKeyAuth) api.getAuthentication("client_id")).setApiKey("CLIENTE_ID");
          
          CartaoApi cartaoApi = new CartaoApi(api);
          ContaApi contaApi = new ContaApi(api);
          
          /**
           * Criando conta 01
           */
          Conta conta1 = new Conta();
          conta1.setNome("NOME CONTA 1");
          conta1 = contaApi.createUsingPOST1(conta1);
          
          /**
           * Criando o cartão 01 da conta 01
           */
          Cartao cartao1 = new Cartao();
          cartao1.setNome("NOME DO CARTAO");
          cartao1.setSenha("123123098asd@");
          cartao1.setCvv("cvv");
          cartao1 = cartaoApi.createUsingPOST(conta1.getId(), cartao1);
          
          /**
           * Creditando R$ 100.00 no cartao1 
           */
          cartaoApi.creditarUsingPUT(conta1.getId(), cartao1.getId(), 100.00);
          
          /**
           * Transacionando R$ 0.10 do cartao1
           */
          cartaoApi.transacionarUsingPUT(conta1.getId(), cartao1.getId(), 0.10);
          
          /**
           * Verificando se o limite é de 99.90
           */
          Limite limite = cartaoApi.limiteUsingGET(conta1.getId(), cartao1.getId());
          System.out.println(limite);
          
          /**
           * Imprimindo os extratos. Deverá aparecer duas transações:
           * 1ª - Credito de 100.00
           * 2ª - Débito de 0.10
           */
          List<Extrato> extratos = cartaoApi.extratosUsingPOST(conta1.getId(), cartao1.getId());
          extratos.stream().forEach(e -> System.out.println(e));
          
          /**
           * Criando o cartão 02 da conta 01
           */
          Cartao cartao2 = new Cartao();
          cartao2.setNome("NOME DO CARTAO");
          cartao2.setSenha("123123098asd@");
          cartao2.setCvv("cvv");
          cartao2 = cartaoApi.createUsingPOST(conta1.getId(), cartao2);
          
          /**
           * Consultando os cartões da conta 01. Deverá retorna dois cartões
           */
          cartaoApi.getAllUsingGET(conta1.getId()).stream().forEach(c -> System.out.println(c));
          
          /**
           * Transferindo 10.10 do cartão 1 para o cartão 2
           */
          cartaoApi.transferirUsingPOST(conta1.getId(), cartao1.getId(), cartao2.getId(), 10.10);
          
          /**
           * Verificando se o limite do cartoa 1 é de 89.80
           */
          limite = cartaoApi.limiteUsingGET(conta1.getId(), cartao1.getId());
          System.out.println(limite);
          
          /**
           * Verificando o limite do cartão 2 que deverá ser de 10.10
           */
          limite = cartaoApi.limiteUsingGET(conta1.getId(), cartao2.getId());
          System.out.println(limite);          
     }
}
```

## Consumo em Android

### Maven

#### Repositórios
```xml
	<repositories>
		<repository>
		    <id>jitpack.io</id>
		    <url>https://jitpack.io</url>
		</repository>
	</repositories>
```

#### Dependência
```xml
	<dependency>
	    <groupId>com.github.pierlabs.sdc-api</groupId>
	    <artifactId>sdc-sdk-android</artifactId>
	    <version>1.0.1</version>
	</dependency>
```

### Gradle

#### Repositórios
```groovy
	allprojects {
		repositories {
			...
			maven { url "https://jitpack.io" }
		}
	}
```

#### Dependência
```groovy
	dependencies {
	        compile 'com.github.pierlabs.sdc-api:sdc-sdk-android:1.0.1'
	}
```

Abaixo segue uma classe Java consumindo as principais funcionalidades da API porém utilizando do sdk Android. Antes de tudo lembre de se cadastrar no [PIER Labs](htttp://pierlabs.io) para pegar seu acess_token e client_id, depois basta seguir o exemplo abaixo.

```java
package br.com.conductor.pier;

import java.util.List;

import br.com.conductor.sdc.api.v1.CartaoApi;
import br.com.conductor.sdc.api.v1.ContaApi;
import br.com.conductor.sdc.api.v1.invoker.ApiException;
import br.com.conductor.sdc.api.v1.invoker.ApiInvoker;
import br.com.conductor.sdc.api.v1.model.Cartao;
import br.com.conductor.sdc.api.v1.model.Conta;
import br.com.conductor.sdc.api.v1.model.Extrato;
import br.com.conductor.sdc.api.v1.model.Limite;

public class Main{

     private static final String BASE_PATH = "https://api.conductor.com.br/sdc";

     public static void main(String[] args) throws ApiException {

          /**
           * Setando o access_token e client_id de acesso. Você pode conseguir os seus se cadastrando em http://pierlabs.io
           */
          ApiInvoker.getInstance().addDefaultHeader("access_token", "ACCESS_TOKEN");
          ApiInvoker.getInstance().addDefaultHeader("client_id", "CLIENT_ID");

          CartaoApi cartaoApi = new CartaoApi();
          cartaoApi.setBasePath(BASE_PATH);

          ContaApi contaApi = new ContaApi();
          contaApi.setBasePath(BASE_PATH);

          /**
           * Criando conta 01
           */
          Conta conta1 = new Conta();
          conta1.setNome("NOME CONTA 1");
          conta1 = contaApi.createUsingPOST1(conta1);

          /**
           * Criando o cartão 01 da conta 01
           */
          Cartao cartao1 = new Cartao();
          cartao1.setNome("NOME DO CARTAO");
          cartao1.setSenha("123123098asd@");
          cartao1.setCvv("cvv");
          cartao1 = cartaoApi.createUsingPOST(conta1.getId(), cartao1);

          /**
           * Creditando R$ 100.00 no cartao1
           */
          cartaoApi.creditarUsingPUT(conta1.getId(), cartao1.getId(), 100.00);

          /**
           * Transacionando R$ 0.10 do cartao1
           */
          cartaoApi.transacionarUsingPUT(conta1.getId(), cartao1.getId(), 0.10);

          /**
           * Verificando se o limite é de 99.90
           */
          Limite limite = cartaoApi.limiteUsingGET(conta1.getId(), cartao1.getId());
          System.out.println(limite);

          /**
           * Imprimindo os extratos. Deverá aparecer duas transações: 1ª - Credito de 100.00 2ª - Débito de 0.10
           */
          List<Extrato> extratos = cartaoApi.extratosUsingPOST(conta1.getId(), cartao1.getId());
          extratos.stream().forEach(e -> System.out.println(e));

          /**
           * Criando o cartão 02 da conta 01
           */
          Cartao cartao2 = new Cartao();
          cartao2.setNome("NOME DO CARTAO");
          cartao2.setSenha("123123098asd@");
          cartao2.setCvv("cvv");
          cartao2 = cartaoApi.createUsingPOST(conta1.getId(), cartao2);

          /**
           * Consultando os cartões da conta 01. Deverá retorna dois cartões
           */
          cartaoApi.getAllUsingGET(conta1.getId()).stream().forEach(c -> System.out.println(c));

          /**
           * Transferindo 10.10 do cartão 1 para o cartão 2
           */
          cartaoApi.transferirUsingPOST(conta1.getId(), cartao1.getId(), cartao2.getId(), 10.10);

          /**
           * Verificando se o limite do cartoa 1 é de 89.80
           */
          limite = cartaoApi.limiteUsingGET(conta1.getId(), cartao1.getId());
          System.out.println(limite);

          /**
           * Verificando o limite do cartão 2 que deverá ser de 10.10
           */
          limite = cartaoApi.limiteUsingGET(conta1.getId(), cartao2.getId());
          System.out.println(limite);
          
     }
}
```

## API Browser

Agora que você já possui seu cadastro, criou sua aplicação e obteve o seu token, vamos acessar o [API Browser](http://pierlabs.io/api-portal/swagger/sdc-2016) para que você consiga testar todos os endpoints. Disponibilizamos um console web feito com swagger, com todos os endpoints publicados. Com esse console você preenche o campo `AccessToken` com o token que você obteve criando sua aplicação e em seguida pode utilizar qualquer método do console. 

Para acessar esse console entre no [PIER Labs](htttp://pierlabs.io), logue com seu usuário e senha e no menu acesse `Ferramentas` -> `API Browser` que será exibido todas as APIs disponibilizadas. Procure a API `SDC 2016` e clique em seu link. Pronto, o Console Web será exibido conforme os screens abaixo.

## Screenshots

### [API Browser 01](http://pierlabs.io/api-portal/swagger/sdc-2016)

![swagger-ui-1](https://raw.githubusercontent.com/pierlabs/sdc-api/master/sdc-api/src/main/resources/static/images/swagger-ui-01.png)

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

## Server

Caso deseje rodar o servidor da API localmente em sua máquina, basta seguir os seguintes passos:

```
git clone https://github.com/pierlabs/sdc-api.git
cd sdc-api\sdc-api
```

Para levandtar o `tomcat` execute o comando abaixo. Após o comando executado, no seu browser acesse [http://localhost:8080](http://localhost:8080)
```
mvn spring-boot:run
```

**Obs.: Para a competição da 15ª SDC você deverá utilizar a API que está levantada em [https://api.conductor.com.br/sdc/](https://api.conductor.com.br/sdc/)**

...