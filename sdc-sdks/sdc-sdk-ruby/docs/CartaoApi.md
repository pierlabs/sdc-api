# SDC::CartaoApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bloquear_using_put**](CartaoApi.md#bloquear_using_put) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/bloquear | Bloquear um cart\u00EF\u00BF\u00BDo.
[**cancelar_using_delete**](CartaoApi.md#cancelar_using_delete) | **DELETE** /v1/contas/{idConta}/cartoes/{idCartao}/cancelar | Cancelar um cart\u00EF\u00BF\u00BDo
[**create_using_post**](CartaoApi.md#create_using_post) | **POST** /v1/contas/{idConta}/cartoes | Cria um cart\u00EF\u00BF\u00BDo
[**creditar_using_put**](CartaoApi.md#creditar_using_put) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/creditar | Creditar dinheiro em um cart\u00EF\u00BF\u00BDo
[**desbloquear_using_put**](CartaoApi.md#desbloquear_using_put) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/desbloquear | Desbloquear um cart\u00EF\u00BF\u00BDo.
[**extratos_using_post**](CartaoApi.md#extratos_using_post) | **POST** /v1/contas/{idConta}/cartoes/{idCartao}/extratos | Retonar os extratos de transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes do cart\u00EF\u00BF\u00BDo
[**get_all_using_get**](CartaoApi.md#get_all_using_get) | **GET** /v1/contas/{idConta}/cartoes | Retona todos os cart\u00EF\u00BF\u00BDo de uma conta
[**get_one_using_get**](CartaoApi.md#get_one_using_get) | **GET** /v1/contas/{idConta}/cartoes/{idCartao} | Retorna um cart\u00EF\u00BF\u00BDo
[**limite_using_get**](CartaoApi.md#limite_using_get) | **GET** /v1/contas/{idConta}/cartoes/{idCartao}/limite | Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo
[**transacionar_using_put**](CartaoApi.md#transacionar_using_put) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/transacionar | Transacionar valores
[**transferir_using_post**](CartaoApi.md#transferir_using_post) | **POST** /v1/contas/{idConta}/cartoes/{idCartao}/transferir | Transferir valores entre dois cart\u00EF\u00BF\u00BDes distintos
[**update_using_put**](CartaoApi.md#update_using_put) | **PUT** /v1/contas/{idConta}/cartoes | Atualiza um cart\u00EF\u00BF\u00BDo


# **bloquear_using_put**
> ResponseEntity bloquear_using_put(id_conta, id_cartao)

Bloquear um cart\u00EF\u00BF\u00BDo.

Bloquear um cart\u00EF\u00BF\u00BDo.

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta

id_cartao = 789 # Integer | Cart\u00EF\u00BF\u00BDo a ser bloqueado


begin
  #Bloquear um cart\u00EF\u00BF\u00BDo.
  result = api_instance.bloquear_using_put(id_conta, id_cartao)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->bloquear_using_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta | 
 **id_cartao** | **Integer**| Cart\u00EF\u00BF\u00BDo a ser bloqueado | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **cancelar_using_delete**
> ResponseEntity cancelar_using_delete(id_conta, id_cartao)

Cancelar um cart\u00EF\u00BF\u00BDo

Cancelar um cart\u00EF\u00BF\u00BDo

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta

id_cartao = 789 # Integer | Cart\u00EF\u00BF\u00BDo a ser cancelado


begin
  #Cancelar um cart\u00EF\u00BF\u00BDo
  result = api_instance.cancelar_using_delete(id_conta, id_cartao)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->cancelar_using_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta | 
 **id_cartao** | **Integer**| Cart\u00EF\u00BF\u00BDo a ser cancelado | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **create_using_post**
> Cartao create_using_post(id_conta, cartao)

Cria um cart\u00EF\u00BF\u00BDo

Cria um cart\u00EF\u00BF\u00BDo

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta

cartao = SDC::Cartao.new # Cartao | Cart\u00EF\u00BF\u00BDo a ser criado


begin
  #Cria um cart\u00EF\u00BF\u00BDo
  result = api_instance.create_using_post(id_conta, cartao)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->create_using_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta | 
 **cartao** | [**Cartao**](Cartao.md)| Cart\u00EF\u00BF\u00BDo a ser criado | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **creditar_using_put**
> ResponseEntity creditar_using_put(id_conta, id_cartao, valor)

Creditar dinheiro em um cart\u00EF\u00BF\u00BDo

Creditar dinheiro em um cart\u00EF\u00BF\u00BDo

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta

id_cartao = 789 # Integer | ID do Cartao a ser creditado

valor = 1.2 # Float | Valor a ser creditado


begin
  #Creditar dinheiro em um cart\u00EF\u00BF\u00BDo
  result = api_instance.creditar_using_put(id_conta, id_cartao, valor)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->creditar_using_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta | 
 **id_cartao** | **Integer**| ID do Cartao a ser creditado | 
 **valor** | **Float**| Valor a ser creditado | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **desbloquear_using_put**
> ResponseEntity desbloquear_using_put(id_conta, id_cartao)

Desbloquear um cart\u00EF\u00BF\u00BDo.

Desbloquear um cart\u00EF\u00BF\u00BDo.

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta

id_cartao = 789 # Integer | Cart\u00EF\u00BF\u00BDo a ser desbloqueado


begin
  #Desbloquear um cart\u00EF\u00BF\u00BDo.
  result = api_instance.desbloquear_using_put(id_conta, id_cartao)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->desbloquear_using_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta | 
 **id_cartao** | **Integer**| Cart\u00EF\u00BF\u00BDo a ser desbloqueado | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **extratos_using_post**
> ResponseEntity extratos_using_post(id_conta, id_cartao)

Retonar os extratos de transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes do cart\u00EF\u00BF\u00BDo

Retorna os extratos de todas as transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes de um determinado cart\u00EF\u00BF\u00BDo

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta

id_cartao = 789 # Integer | ID do cart\u00EF\u00BF\u00BDo


begin
  #Retonar os extratos de transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes do cart\u00EF\u00BF\u00BDo
  result = api_instance.extratos_using_post(id_conta, id_cartao)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->extratos_using_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta | 
 **id_cartao** | **Integer**| ID do cart\u00EF\u00BF\u00BDo | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **get_all_using_get**
> Array&lt;Cartao&gt; get_all_using_get(id_conta)

Retona todos os cart\u00EF\u00BF\u00BDo de uma conta

Retona todos os cart\u00EF\u00BF\u00BDo de uma conta

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta


begin
  #Retona todos os cart\u00EF\u00BF\u00BDo de uma conta
  result = api_instance.get_all_using_get(id_conta)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->get_all_using_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta | 

### Return type

[**Array&lt;Cartao&gt;**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **get_one_using_get**
> Cartao get_one_using_get(id_conta, id_cartao)

Retorna um cart\u00EF\u00BF\u00BDo

Retorna um cart\u00EF\u00BF\u00BDo

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta

id_cartao = 789 # Integer | ID do Cart\u00EF\u00BF\u00BDo


begin
  #Retorna um cart\u00EF\u00BF\u00BDo
  result = api_instance.get_one_using_get(id_conta, id_cartao)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->get_one_using_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta | 
 **id_cartao** | **Integer**| ID do Cart\u00EF\u00BF\u00BDo | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **limite_using_get**
> ResponseEntity limite_using_get(id_conta, id_cartao)

Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo

Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta

id_cartao = 789 # Integer | ID do Cartao a ser creditado


begin
  #Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo
  result = api_instance.limite_using_get(id_conta, id_cartao)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->limite_using_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta | 
 **id_cartao** | **Integer**| ID do Cartao a ser creditado | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **transacionar_using_put**
> ResponseEntity transacionar_using_put(id_conta, id_cartao, valor)

Transacionar valores

Transacionar algum valor utilizando um determinado cart\u00EF\u00BF\u00BDo

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta

id_cartao = 789 # Integer | ID do Cartao a ser creditado

valor = 1.2 # Float | Valor da transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDo


begin
  #Transacionar valores
  result = api_instance.transacionar_using_put(id_conta, id_cartao, valor)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->transacionar_using_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta | 
 **id_cartao** | **Integer**| ID do Cartao a ser creditado | 
 **valor** | **Float**| Valor da transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDo | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **transferir_using_post**
> ResponseEntity transferir_using_post(id_conta, id_cartao, id_cartao_destino, valor)

Transferir valores entre dois cart\u00EF\u00BF\u00BDes distintos

Transferir valores entre dois cart\u00EF\u00BF\u00BDes

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta do cart\u00EF\u00BF\u00BDo de origem

id_cartao = 789 # Integer | ID do cart\u00EF\u00BF\u00BDo de origem

id_cartao_destino = 789 # Integer | ID do cart\u00EF\u00BF\u00BDo de destino

valor = 1.2 # Float | Valor a ser transferido


begin
  #Transferir valores entre dois cart\u00EF\u00BF\u00BDes distintos
  result = api_instance.transferir_using_post(id_conta, id_cartao, id_cartao_destino, valor)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->transferir_using_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta do cart\u00EF\u00BF\u00BDo de origem | 
 **id_cartao** | **Integer**| ID do cart\u00EF\u00BF\u00BDo de origem | 
 **id_cartao_destino** | **Integer**| ID do cart\u00EF\u00BF\u00BDo de destino | 
 **valor** | **Float**| Valor a ser transferido | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **update_using_put**
> Cartao update_using_put(id_conta, cartao)

Atualiza um cart\u00EF\u00BF\u00BDo

Atualiza um cart\u00EF\u00BF\u00BDo

### Example
```ruby
# load the gem
require 'sdc-sdk-ruby'
# setup authorization 
SDC.configure do |config|
  # Configure API key authorization: access_token
  config.api_key['access_token'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'BEARER' (defaults to nil)
  #config.api_key_prefix['access_token'] = 'BEARER'
end

api_instance = SDC::CartaoApi.new

id_conta = 789 # Integer | ID da Conta

cartao = SDC::Cartao.new # Cartao | Cart\u00EF\u00BF\u00BDo a ser atualizado


begin
  #Atualiza um cart\u00EF\u00BF\u00BDo
  result = api_instance.update_using_put(id_conta, cartao)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->update_using_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta | 
 **cartao** | [**Cartao**](Cartao.md)| Cart\u00EF\u00BF\u00BDo a ser atualizado | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



