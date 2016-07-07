# br.com.conductor.sdc.api.v1.invoker\CartaoApi

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


# **bloquearUsingPUT**
> \br.com.conductor.sdc.api.v1.model\ResponseEntity bloquearUsingPUT($id_conta, $id_cartao)

Bloquear um cart\u00EF\u00BF\u00BDo.

Bloquear um cart\u00EF\u00BF\u00BDo.

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta
$id_cartao = 789; // int | Cart\u00EF\u00BF\u00BDo a ser bloqueado

try { 
    $result = $api_instance->bloquearUsingPUT($id_conta, $id_cartao);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->bloquearUsingPUT: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta | 
 **id_cartao** | **int**| Cart\u00EF\u00BF\u00BDo a ser bloqueado | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **cancelarUsingDELETE**
> \br.com.conductor.sdc.api.v1.model\ResponseEntity cancelarUsingDELETE($id_conta, $id_cartao)

Cancelar um cart\u00EF\u00BF\u00BDo

Cancelar um cart\u00EF\u00BF\u00BDo

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta
$id_cartao = 789; // int | Cart\u00EF\u00BF\u00BDo a ser cancelado

try { 
    $result = $api_instance->cancelarUsingDELETE($id_conta, $id_cartao);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->cancelarUsingDELETE: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta | 
 **id_cartao** | **int**| Cart\u00EF\u00BF\u00BDo a ser cancelado | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **createUsingPOST**
> \br.com.conductor.sdc.api.v1.model\Cartao createUsingPOST($id_conta, $cartao)

Cria um cart\u00EF\u00BF\u00BDo

Cria um cart\u00EF\u00BF\u00BDo

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta
$cartao = new \br.com.conductor.sdc.api.v1.model\Cartao(); // \br.com.conductor.sdc.api.v1.model\Cartao | Cart\u00EF\u00BF\u00BDo a ser criado

try { 
    $result = $api_instance->createUsingPOST($id_conta, $cartao);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->createUsingPOST: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta | 
 **cartao** | [**\br.com.conductor.sdc.api.v1.model\Cartao**](\br.com.conductor.sdc.api.v1.model\Cartao.md)| Cart\u00EF\u00BF\u00BDo a ser criado | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **creditarUsingPUT**
> \br.com.conductor.sdc.api.v1.model\ResponseEntity creditarUsingPUT($id_conta, $id_cartao, $valor)

Creditar dinheiro em um cart\u00EF\u00BF\u00BDo

Creditar dinheiro em um cart\u00EF\u00BF\u00BDo

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta
$id_cartao = 789; // int | ID do Cartao a ser creditado
$valor = 1.2; // double | Valor a ser creditado

try { 
    $result = $api_instance->creditarUsingPUT($id_conta, $id_cartao, $valor);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->creditarUsingPUT: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta | 
 **id_cartao** | **int**| ID do Cartao a ser creditado | 
 **valor** | **double**| Valor a ser creditado | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **desbloquearUsingPUT**
> \br.com.conductor.sdc.api.v1.model\ResponseEntity desbloquearUsingPUT($id_conta, $id_cartao)

Desbloquear um cart\u00EF\u00BF\u00BDo.

Desbloquear um cart\u00EF\u00BF\u00BDo.

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta
$id_cartao = 789; // int | Cart\u00EF\u00BF\u00BDo a ser desbloqueado

try { 
    $result = $api_instance->desbloquearUsingPUT($id_conta, $id_cartao);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->desbloquearUsingPUT: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta | 
 **id_cartao** | **int**| Cart\u00EF\u00BF\u00BDo a ser desbloqueado | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **extratosUsingPOST**
> \br.com.conductor.sdc.api.v1.model\ResponseEntity extratosUsingPOST($id_conta, $id_cartao)

Retonar os extratos de transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes do cart\u00EF\u00BF\u00BDo

Retorna os extratos de todas as transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes de um determinado cart\u00EF\u00BF\u00BDo

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta
$id_cartao = 789; // int | ID do cart\u00EF\u00BF\u00BDo

try { 
    $result = $api_instance->extratosUsingPOST($id_conta, $id_cartao);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->extratosUsingPOST: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta | 
 **id_cartao** | **int**| ID do cart\u00EF\u00BF\u00BDo | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getAllUsingGET**
> \br.com.conductor.sdc.api.v1.model\Cartao[] getAllUsingGET($id_conta)

Retona todos os cart\u00EF\u00BF\u00BDo de uma conta

Retona todos os cart\u00EF\u00BF\u00BDo de uma conta

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta

try { 
    $result = $api_instance->getAllUsingGET($id_conta);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->getAllUsingGET: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\Cartao[]**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **getOneUsingGET**
> \br.com.conductor.sdc.api.v1.model\Cartao getOneUsingGET($id_conta, $id_cartao)

Retorna um cart\u00EF\u00BF\u00BDo

Retorna um cart\u00EF\u00BF\u00BDo

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta
$id_cartao = 789; // int | ID do Cart\u00EF\u00BF\u00BDo

try { 
    $result = $api_instance->getOneUsingGET($id_conta, $id_cartao);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->getOneUsingGET: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta | 
 **id_cartao** | **int**| ID do Cart\u00EF\u00BF\u00BDo | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **limiteUsingGET**
> \br.com.conductor.sdc.api.v1.model\ResponseEntity limiteUsingGET($id_conta, $id_cartao)

Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo

Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta
$id_cartao = 789; // int | ID do Cartao a ser creditado

try { 
    $result = $api_instance->limiteUsingGET($id_conta, $id_cartao);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->limiteUsingGET: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta | 
 **id_cartao** | **int**| ID do Cartao a ser creditado | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **transacionarUsingPUT**
> \br.com.conductor.sdc.api.v1.model\ResponseEntity transacionarUsingPUT($id_conta, $id_cartao, $valor)

Transacionar valores

Transacionar algum valor utilizando um determinado cart\u00EF\u00BF\u00BDo

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta
$id_cartao = 789; // int | ID do Cartao a ser creditado
$valor = 1.2; // double | Valor da transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDo

try { 
    $result = $api_instance->transacionarUsingPUT($id_conta, $id_cartao, $valor);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->transacionarUsingPUT: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta | 
 **id_cartao** | **int**| ID do Cartao a ser creditado | 
 **valor** | **double**| Valor da transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDo | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **transferirUsingPOST**
> \br.com.conductor.sdc.api.v1.model\ResponseEntity transferirUsingPOST($id_conta, $id_cartao, $id_cartao_destino, $valor)

Transferir valores entre dois cart\u00EF\u00BF\u00BDes distintos

Transferir valores entre dois cart\u00EF\u00BF\u00BDes

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta do cart\u00EF\u00BF\u00BDo de origem
$id_cartao = 789; // int | ID do cart\u00EF\u00BF\u00BDo de origem
$id_cartao_destino = 789; // int | ID do cart\u00EF\u00BF\u00BDo de destino
$valor = 1.2; // double | Valor a ser transferido

try { 
    $result = $api_instance->transferirUsingPOST($id_conta, $id_cartao, $id_cartao_destino, $valor);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->transferirUsingPOST: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta do cart\u00EF\u00BF\u00BDo de origem | 
 **id_cartao** | **int**| ID do cart\u00EF\u00BF\u00BDo de origem | 
 **id_cartao_destino** | **int**| ID do cart\u00EF\u00BF\u00BDo de destino | 
 **valor** | **double**| Valor a ser transferido | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **updateUsingPUT**
> \br.com.conductor.sdc.api.v1.model\Cartao updateUsingPUT($id_conta, $cartao)

Atualiza um cart\u00EF\u00BF\u00BDo

Atualiza um cart\u00EF\u00BF\u00BDo

### Example 
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. BEARER) for API key, if needed
// br.com.conductor.sdc.api.v1.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'BEARER');

$api_instance = new br.com.conductor.sdc.api.v1.invoker\Api\CartaoApi();
$id_conta = 789; // int | ID da Conta
$cartao = new \br.com.conductor.sdc.api.v1.model\Cartao(); // \br.com.conductor.sdc.api.v1.model\Cartao | Cart\u00EF\u00BF\u00BDo a ser atualizado

try { 
    $result = $api_instance->updateUsingPUT($id_conta, $cartao);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CartaoApi->updateUsingPUT: ', $e->getMessage(), "\n";
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **int**| ID da Conta | 
 **cartao** | [**\br.com.conductor.sdc.api.v1.model\Cartao**](\br.com.conductor.sdc.api.v1.model\Cartao.md)| Cart\u00EF\u00BF\u00BDo a ser atualizado | 

### Return type

[**\br.com.conductor.sdc.api.v1.model\Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP reuqest headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

