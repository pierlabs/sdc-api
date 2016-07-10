# br.com.conductor.sdc.api.v1.invoker\ContaApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createUsingPOST1**](ContaApi.md#createUsingPOST1) | **POST** /v1/contas | Cria uma conta
[**deleteUsingDELETE**](ContaApi.md#deleteUsingDELETE) | **DELETE** /v1/contas/{id} | Deleta uma conta
[**getAllUsingGET1**](ContaApi.md#getAllUsingGET1) | **GET** /v1/contas | Retorna todas as contas
[**getOneUsingGET1**](ContaApi.md#getOneUsingGET1) | **GET** /v1/contas/{id} | Retorna uma conta
[**updateUsingPUT1**](ContaApi.md#updateUsingPUT1) | **PUT** /v1/contas | Atualiza uma conta


# **createUsingPOST1**
> \br.com.conductor.sdc.api.v1.model\Conta createUsingPOST1($conta)

Cria uma conta

Cria uma conta

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\ContaApi();
$conta = new \br.com.conductor.sdc.api.v1.model\Conta(); // \br.com.conductor.sdc.api.v1.model\Conta | conta

try { 
    $result = $api_instance->createUsingPOST1($conta);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ContaApi->createUsingPOST1: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conta** | [**\br.com.conductor.sdc.api.v1.model\Conta**](\br.com.conductor.sdc.api.v1.model\Conta.md)| conta | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\Conta**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deleteUsingDELETE**
> \br.com.conductor.sdc.api.v1.model\Response deleteUsingDELETE($id)

Deleta uma conta

Deleta uma conta

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\ContaApi();
$id = 789; // int | id

try { 
    $result = $api_instance->deleteUsingDELETE($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ContaApi->deleteUsingDELETE: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| id | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getAllUsingGET1**
> \br.com.conductor.sdc.api.v1.model\Conta[] getAllUsingGET1()

Retorna todas as contas

Retorna todas as contas

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\ContaApi();

try { 
    $result = $api_instance->getAllUsingGET1();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ContaApi->getAllUsingGET1: ', $e->getMessage(), "\n";
}
?>
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**\br.com.conductor.sdc.api.v1.model\Conta[]**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getOneUsingGET1**
> \br.com.conductor.sdc.api.v1.model\Conta getOneUsingGET1($id)

Retorna uma conta

Retorna uma conta

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\ContaApi();
$id = 789; // int | id

try { 
    $result = $api_instance->getOneUsingGET1($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ContaApi->getOneUsingGET1: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| id | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\Conta**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **updateUsingPUT1**
> \br.com.conductor.sdc.api.v1.model\Conta updateUsingPUT1($conta)

Atualiza uma conta

Atualiza uma conta

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\ContaApi();
$conta = new \br.com.conductor.sdc.api.v1.model\Conta(); // \br.com.conductor.sdc.api.v1.model\Conta | conta

try { 
    $result = $api_instance->updateUsingPUT1($conta);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ContaApi->updateUsingPUT1: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conta** | [**\br.com.conductor.sdc.api.v1.model\Conta**](\br.com.conductor.sdc.api.v1.model\Conta.md)| conta | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\Conta**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

