# SDC.CartaoApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bloquearUsingPUT**](CartaoApi.md#bloquearUsingPUT) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/bloquear | Bloquear um cart\u00C3\u00A3o.
[**cancelarUsingDELETE**](CartaoApi.md#cancelarUsingDELETE) | **DELETE** /v1/contas/{idConta}/cartoes/{idCartao}/cancelar | Cancelar um cart\u00C3\u00A3o
[**createUsingPOST**](CartaoApi.md#createUsingPOST) | **POST** /v1/contas/{idConta}/cartoes | Cria um cart\u00C3\u00A3o
[**creditarUsingPUT**](CartaoApi.md#creditarUsingPUT) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/creditar | Creditar dinheiro em um cart\u00C3\u00A3o
[**desbloquearUsingPUT**](CartaoApi.md#desbloquearUsingPUT) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/desbloquear | Desbloquear um cart\u00C3\u00A3o.
[**extratosUsingPOST**](CartaoApi.md#extratosUsingPOST) | **POST** /v1/contas/{idConta}/cartoes/{idCartao}/extratos | Extratos de transa\u00C3\u00A7oes
[**getAllUsingGET**](CartaoApi.md#getAllUsingGET) | **GET** /v1/contas/{idConta}/cartoes | Retona todos os cart\u00C3\u00A3o de uma conta
[**getOneUsingGET**](CartaoApi.md#getOneUsingGET) | **GET** /v1/contas/{idConta}/cartoes/{idCartao} | Retorna um cart\u00C3\u00A3o
[**limiteUsingGET**](CartaoApi.md#limiteUsingGET) | **GET** /v1/contas/{idConta}/cartoes/{idCartao}/limite | Retorna o limite do cart\u00C3\u00A3o
[**transacionarUsingPUT**](CartaoApi.md#transacionarUsingPUT) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/transacionar | Transacionar valores
[**transferirUsingPOST**](CartaoApi.md#transferirUsingPOST) | **POST** /v1/contas/{idConta}/cartoes/{idCartao}/transferir | Transferir valores entre dois cart\u00C3\u00B5es distintos
[**updateUsingPUT**](CartaoApi.md#updateUsingPUT) | **PUT** /v1/contas/{idConta}/cartoes | Atualiza um cart\u00C3\u00A3o


<a name="bloquearUsingPUT"></a>
# **bloquearUsingPUT**
> Response bloquearUsingPUT(idConta, idCartao)

Bloquear um cart\u00C3\u00A3o.

Bloquear um cart\u00C3\u00A3o.

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta

var idCartao = 789; // {Integer} Cart\u00C3\u00A3o a ser bloqueado


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.bloquearUsingPUT(idConta, idCartao, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta | 
 **idCartao** | **Integer**| Cart\u00C3\u00A3o a ser bloqueado | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="cancelarUsingDELETE"></a>
# **cancelarUsingDELETE**
> Response cancelarUsingDELETE(idConta, idCartao)

Cancelar um cart\u00C3\u00A3o

Cancelar um determinado cart\u00C3\u00A3o

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta

var idCartao = 789; // {Integer} Cart\u00C3\u00A3o a ser cancelado


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.cancelarUsingDELETE(idConta, idCartao, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta | 
 **idCartao** | **Integer**| Cart\u00C3\u00A3o a ser cancelado | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="createUsingPOST"></a>
# **createUsingPOST**
> Cartao createUsingPOST(idConta, cartao)

Cria um cart\u00C3\u00A3o

Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta

var cartao = new SDC.Cartao(); // {Cartao} Cart\u00C3\u00A3o a ser criado


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.createUsingPOST(idConta, cartao, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta | 
 **cartao** | [**Cartao**](Cartao.md)| Cart\u00C3\u00A3o a ser criado | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="creditarUsingPUT"></a>
# **creditarUsingPUT**
> Response creditarUsingPUT(idConta, idCartao, valor)

Creditar dinheiro em um cart\u00C3\u00A3o

Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta

var idCartao = 789; // {Integer} ID do Cartao a ser creditado

var valor = 1.2; // {Number} Valor a ser creditado


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.creditarUsingPUT(idConta, idCartao, valor, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta | 
 **idCartao** | **Integer**| ID do Cartao a ser creditado | 
 **valor** | **Number**| Valor a ser creditado | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="desbloquearUsingPUT"></a>
# **desbloquearUsingPUT**
> Response desbloquearUsingPUT(idConta, idCartao)

Desbloquear um cart\u00C3\u00A3o.

Desbloquear um determinado cart\u00C3\u00A3o.

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta

var idCartao = 789; // {Integer} Cart\u00C3\u00A3o a ser desbloqueado


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.desbloquearUsingPUT(idConta, idCartao, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta | 
 **idCartao** | **Integer**| Cart\u00C3\u00A3o a ser desbloqueado | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="extratosUsingPOST"></a>
# **extratosUsingPOST**
> [Extrato] extratosUsingPOST(idConta, idCartao)

Extratos de transa\u00C3\u00A7oes

Retorna o extratos de transa\u00C3\u00A7oes de cr\u00C3\u00A9dito e d\u00C3\u00A9bito de um determinado cart\u00C3\u00A3o

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta

var idCartao = 789; // {Integer} ID do cart\u00C3\u00A3o


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.extratosUsingPOST(idConta, idCartao, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta | 
 **idCartao** | **Integer**| ID do cart\u00C3\u00A3o | 

### Return type

[**[Extrato]**](Extrato.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getAllUsingGET"></a>
# **getAllUsingGET**
> [Cartao] getAllUsingGET(idConta)

Retona todos os cart\u00C3\u00A3o de uma conta

Consulte todos os carteos de uma determinada conta.

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.getAllUsingGET(idConta, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta | 

### Return type

[**[Cartao]**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getOneUsingGET"></a>
# **getOneUsingGET**
> Cartao getOneUsingGET(idConta, idCartao)

Retorna um cart\u00C3\u00A3o

Consulte um determinado cart\u00C3\u00A3o

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta

var idCartao = 789; // {Integer} ID do Cart\u00C3\u00A3o


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.getOneUsingGET(idConta, idCartao, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta | 
 **idCartao** | **Integer**| ID do Cart\u00C3\u00A3o | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="limiteUsingGET"></a>
# **limiteUsingGET**
> Limite limiteUsingGET(idConta, idCartao)

Retorna o limite do cart\u00C3\u00A3o

Consultar o limite de um determinado cart\u00C3\u00A3o

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta

var idCartao = 789; // {Integer} ID do Cartao a ser creditado


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.limiteUsingGET(idConta, idCartao, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta | 
 **idCartao** | **Integer**| ID do Cartao a ser creditado | 

### Return type

[**Limite**](Limite.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="transacionarUsingPUT"></a>
# **transacionarUsingPUT**
> Response transacionarUsingPUT(idConta, idCartao, valor)

Transacionar valores

Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta

var idCartao = 789; // {Integer} ID do Cartao a ser creditado

var valor = 1.2; // {Number} Valor da transa\u00C3\u00A7\u00C3\u00A3o


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.transacionarUsingPUT(idConta, idCartao, valor, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta | 
 **idCartao** | **Integer**| ID do Cartao a ser creditado | 
 **valor** | **Number**| Valor da transa\u00C3\u00A7\u00C3\u00A3o | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="transferirUsingPOST"></a>
# **transferirUsingPOST**
> Response transferirUsingPOST(idConta, idCartao, idCartaoDestino, valor)

Transferir valores entre dois cart\u00C3\u00B5es distintos

Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta do cart\u00C3\u00A3o de origem

var idCartao = 789; // {Integer} ID do cart\u00C3\u00A3o de origem

var idCartaoDestino = 789; // {Integer} ID do cart\u00C3\u00A3o de destino

var valor = 1.2; // {Number} Valor a ser transferido


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.transferirUsingPOST(idConta, idCartao, idCartaoDestino, valor, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta do cart\u00C3\u00A3o de origem | 
 **idCartao** | **Integer**| ID do cart\u00C3\u00A3o de origem | 
 **idCartaoDestino** | **Integer**| ID do cart\u00C3\u00A3o de destino | 
 **valor** | **Number**| Valor a ser transferido | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateUsingPUT"></a>
# **updateUsingPUT**
> Cartao updateUsingPUT(idConta, cartao)

Atualiza um cart\u00C3\u00A3o

Atualiza um determinado cart\u00C3\u00A3o

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.CartaoApi()

var idConta = 789; // {Integer} ID da Conta

var cartao = new SDC.Cartao(); // {Cartao} Cart\u00C3\u00A3o a ser atualizado


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.updateUsingPUT(idConta, cartao, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idConta** | **Integer**| ID da Conta | 
 **cartao** | [**Cartao**](Cartao.md)| Cart\u00C3\u00A3o a ser atualizado | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

