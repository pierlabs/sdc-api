# SDC.ContaApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createUsingPOST1**](ContaApi.md#createUsingPOST1) | **POST** /v1/contas | Cria uma conta
[**deleteUsingDELETE**](ContaApi.md#deleteUsingDELETE) | **DELETE** /v1/contas/{id} | Deleta uma conta
[**getAllUsingGET1**](ContaApi.md#getAllUsingGET1) | **GET** /v1/contas | Retorna todas as contas
[**getOneUsingGET1**](ContaApi.md#getOneUsingGET1) | **GET** /v1/contas/{id} | Retorna uma conta
[**updateUsingPUT1**](ContaApi.md#updateUsingPUT1) | **PUT** /v1/contas | Atualiza uma conta


<a name="createUsingPOST1"></a>
# **createUsingPOST1**
> Conta createUsingPOST1(conta)

Cria uma conta

Cria uma conta

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.ContaApi()

var conta = new SDC.Conta(); // {Conta} conta


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.createUsingPOST1(conta, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conta** | [**Conta**](Conta.md)| conta | 

### Return type

[**Conta**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deleteUsingDELETE"></a>
# **deleteUsingDELETE**
> Response deleteUsingDELETE(id)

Deleta uma conta

Deleta um cart\u00C3\u00A3o

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.ContaApi()

var id = 789; // {Integer} id


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.deleteUsingDELETE(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Integer**| id | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getAllUsingGET1"></a>
# **getAllUsingGET1**
> [Conta] getAllUsingGET1

Retorna todas as contas

Retorna todas as contas

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.ContaApi()

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.getAllUsingGET1(callback);
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**[Conta]**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getOneUsingGET1"></a>
# **getOneUsingGET1**
> Conta getOneUsingGET1(id)

Retorna uma conta

Retorna uma conta

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.ContaApi()

var id = 789; // {Integer} id


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.getOneUsingGET1(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Integer**| id | 

### Return type

[**Conta**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateUsingPUT1"></a>
# **updateUsingPUT1**
> Conta updateUsingPUT1(conta)

Atualiza uma conta

Atualiza uma conta

### Example
```javascript
var SDC = require('SDC');
var defaultClient = SDC.ApiClient.default;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = "YOUR API KEY"
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix['access_token'] = "Token"

var apiInstance = new SDC.ContaApi()

var conta = new SDC.Conta(); // {Conta} conta


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
api.updateUsingPUT1(conta, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conta** | [**Conta**](Conta.md)| conta | 

### Return type

[**Conta**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

