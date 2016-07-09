# sdc-sdk-java

## Requerimentos

É necessário você empacotar o códido com o [Maven](https://maven.apache.org/) para que possa ser utilizado. 

## Instalação e Utilização

Para instalar o sdc-sdk-java em seu repositorio local do maven simplesmente execute:

```shell
mvn install
```

Para fazer depoly do artefato gerado em algum repositório maven configure o arquivo pom.xml com as informações do seu Artifactory ou Nexus e execute o comando abaixo. Caso não possua nenhum repositório para suas bibliotecas maven nós recomendamos a utilização do [Jitpack](https://jitpack.io/). Essa ferramenta simplifica muito a utilização de bibliotecas maven hospedadas no [Github](https://github.com).

```shell
mvn deploy
```

Depois da biblioteca Maven instalada você pode utilizar em seus projetos Java adicionando no seu arquivo pom.xml

```xml
<dependency>
    <groupId>br.com.conductor.sdc</groupId>
    <artifactId>sdc-sdk-java</artifactId>
    <version>1.0.0</version>
    <scope>compile</scope>
</dependency>

```

## Criando um API Client

Antes de utilizar as APIs, é necessÃ¡rio a criaçao de um client com as configuraçoes de _base path_ e também as credenciais para acesso.

Abaixo segue o código de exemplo:

```java
ApiClient apiClient = new ApiClient();
apiClient.setBasePath("https://sandbox.conductor.com.br/pier/v1");

// Alterar a chave informada com o valor de client_id disponível para sua APP
((ApiKeyAuth)apiClient.getAuthentication("client_id")).setApiKey("ll0s@$AS$Ssasds");

// Alterar a chave informada com o valor de access_token disponível para sua APP
((ApiKeyAuth)apiClient.getAuthentication("access_token")).setApiKey("nsswllKgtXTMv0G");
```

## Exemplo: Consultando um determinado cartão

No exemplo abaixo vamos consultar um determinado cartão de crédito de uma determinada conta. Para isso utilize o método `consultarCartaoUsingGET` da classe `CartaoApi`.
Todas as classes de recursos da API recebem no seu construtor o ApiClient gerando no método acima:

```java
Integer idCartao = 1;
Integer idConta = 1;

//Opcional
String numerodoCartao = null;

CartaoApi cartaoApi = new CartaoApi(apiClient);
ConsultarCartaoResponse cartaoResponse = cartaoApi.consultarCartaoUsingGET(idConta, idCartao, numerodoCartao);
      
System.out.println(cartaoResponse);
```

## Author

pierlabs@conductor.com.br


