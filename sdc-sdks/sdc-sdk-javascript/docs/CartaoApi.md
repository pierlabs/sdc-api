# SDC.CartaoApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bloquearUsingPUT**](CartaoApi.md#bloquearUsingPUT) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/bloquear | Bloquear um cart\u00EF\u00BF\u00BDo.
[**cancelarUsingDELETE**](CartaoApi.md#cancelarUsingDELETE) | **DELETE** /v1/contas/{idConta}/cartoes/{idCartao}/cancelar | Cancelar um cart\u00EF\u00BF\u00BDo
[**createUsingPOST**](CartaoApi.md#createUsingPOST) | **POST** /v1/contas/{idConta}/cartoes | Cria um cart\u00EF\u00BF\u00BDo
[**creditarUsingPUT**](CartaoApi.md#creditarUsingPUT) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/creditar | Creditar dinheiro em um cart\u00EF\u00BF\u00BDo
[**desbloquearUsingPUT**](CartaoApi.md#desbloquearUsingPUT) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/desbloquear | Desbloquear um cart\u00EF\u00BF\u00BDo.
[**extratosUsingPOST**](CartaoApi.md#extratosUsingPOST) | **POST** /v1/contas/{idConta}/cartoes/{idCartao}/extratos | Retonar os extratos de transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes do cart\u00EF\u00BF\u00BDo
[**getAllUsingGET**](CartaoApi.md#getAllUsingGET) | **GET** /v1/contas/{idConta}/cartoes | Retona todos os cart\u00EF\u00BF\u00BDo de uma conta
[**getOneUsingGET**](CartaoApi.md#getOneUsingGET) | **GET** /v1/contas/{idConta}/cartoes/{idCartao} | Retorna um cart\u00EF\u00BF\u00BDo
[**limiteUsingGET**](CartaoApi.md#limiteUsingGET) | **GET** /v1/contas/{idConta}/cartoes/{idCartao}/limite | Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo
[**transacionarUsingPUT**](CartaoApi.md#transacionarUsingPUT) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/transacionar | Transacionar valores
[**transferirUsingPOST**](CartaoApi.md#transferirUsingPOST) | **POST** /v1/contas/{idConta}/cartoes/{idCartao}/transferir | Transferir valores entre dois cart\u00EF\u00BF\u00BDes distintos
[**updateUsingPUT**](CartaoApi.md#updateUsingPUT) | **PUT** /v1/contas/{idConta}/cartoes | Atualiza um cart\u00EF\u00BF\u00BDo


<a name="bloquearUsingPUT"></a>
# **bloquearUsingPUT**
> ResponseEntity bloquearUsingPUT(idConta, idCartao)

Bloquear um cart\u00EF\u00BF\u00BDo.

Bloquear um cart\u00EF\u00BF\u00BDo.

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

var idCartao = 789; // {Integer} Cart\u00EF\u00BF\u00BDo a ser bloqueado


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
 **idCartao** | **Integer**| Cart\u00EF\u00BF\u00BDo a ser bloqueado | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="cancelarUsingDELETE"></a>
# **cancelarUsingDELETE**
> ResponseEntity cancelarUsingDELETE(idConta, idCartao)

Cancelar um cart\u00EF\u00BF\u00BDo

Cancelar um cart\u00EF\u00BF\u00BDo

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

var idCartao = 789; // {Integer} Cart\u00EF\u00BF\u00BDo a ser cancelado


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
 **idCartao** | **Integer**| Cart\u00EF\u00BF\u00BDo a ser cancelado | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="createUsingPOST"></a>
# **createUsingPOST**
> Cartao createUsingPOST(idConta, cartao)

Cria um cart\u00EF\u00BF\u00BDo

Cria um cart\u00EF\u00BF\u00BDo

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

var cartao = new SDC.Cartao(); // {Cartao} Cart\u00EF\u00BF\u00BDo a ser criado


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
 **cartao** | [**Cartao**](Cartao.md)| Cart\u00EF\u00BF\u00BDo a ser criado | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="creditarUsingPUT"></a>
# **creditarUsingPUT**
> ResponseEntity creditarUsingPUT(idConta, idCartao, valor)

Creditar dinheiro em um cart\u00EF\u00BF\u00BDo

Creditar dinheiro em um cart\u00EF\u00BF\u00BDo

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

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="desbloquearUsingPUT"></a>
# **desbloquearUsingPUT**
> ResponseEntity desbloquearUsingPUT(idConta, idCartao)

Desbloquear um cart\u00EF\u00BF\u00BDo.

Desbloquear um cart\u00EF\u00BF\u00BDo.

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

var idCartao = 789; // {Integer} Cart\u00EF\u00BF\u00BDo a ser desbloqueado


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
 **idCartao** | **Integer**| Cart\u00EF\u00BF\u00BDo a ser desbloqueado | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="extratosUsingPOST"></a>
# **extratosUsingPOST**
> ResponseEntity extratosUsingPOST(idConta, idCartao)

Retonar os extratos de transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes do cart\u00EF\u00BF\u00BDo

Retorna os extratos de todas as transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes de um determinado cart\u00EF\u00BF\u00BDo

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

var idCartao = 789; // {Integer} ID do cart\u00EF\u00BF\u00BDo


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
 **idCartao** | **Integer**| ID do cart\u00EF\u00BF\u00BDo | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getAllUsingGET"></a>
# **getAllUsingGET**
> [Cartao] getAllUsingGET(idConta)

Retona todos os cart\u00EF\u00BF\u00BDo de uma conta

Retona todos os cart\u00EF\u00BF\u00BDo de uma conta

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

Retorna um cart\u00EF\u00BF\u00BDo

Retorna um cart\u00EF\u00BF\u00BDo

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

var idCartao = 789; // {Integer} ID do Cart\u00EF\u00BF\u00BDo


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
 **idCartao** | **Integer**| ID do Cart\u00EF\u00BF\u00BDo | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="limiteUsingGET"></a>
# **limiteUsingGET**
> ResponseEntity limiteUsingGET(idConta, idCartao)

Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo

Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo

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

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="transacionarUsingPUT"></a>
# **transacionarUsingPUT**
> ResponseEntity transacionarUsingPUT(idConta, idCartao, valor)

Transacionar valores

Transacionar algum valor utilizando um determinado cart\u00EF\u00BF\u00BDo

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

var valor = 1.2; // {Number} Valor da transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDo


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
 **valor** | **Number**| Valor da transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDo | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="transferirUsingPOST"></a>
# **transferirUsingPOST**
> ResponseEntity transferirUsingPOST(idConta, idCartao, idCartaoDestino, valor)

Transferir valores entre dois cart\u00EF\u00BF\u00BDes distintos

Transferir valores entre dois cart\u00EF\u00BF\u00BDes

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

var idConta = 789; // {Integer} ID da Conta do cart\u00EF\u00BF\u00BDo de origem

var idCartao = 789; // {Integer} ID do cart\u00EF\u00BF\u00BDo de origem

var idCartaoDestino = 789; // {Integer} ID do cart\u00EF\u00BF\u00BDo de destino

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
 **idConta** | **Integer**| ID da Conta do cart\u00EF\u00BF\u00BDo de origem | 
 **idCartao** | **Integer**| ID do cart\u00EF\u00BF\u00BDo de origem | 
 **idCartaoDestino** | **Integer**| ID do cart\u00EF\u00BF\u00BDo de destino | 
 **valor** | **Number**| Valor a ser transferido | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateUsingPUT"></a>
# **updateUsingPUT**
> Cartao updateUsingPUT(idConta, cartao)

Atualiza um cart\u00EF\u00BF\u00BDo

Atualiza um cart\u00EF\u00BF\u00BDo

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

var cartao = new SDC.Cartao(); // {Cartao} Cart\u00EF\u00BF\u00BDo a ser atualizado


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
 **cartao** | [**Cartao**](Cartao.md)| Cart\u00EF\u00BF\u00BDo a ser atualizado | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

