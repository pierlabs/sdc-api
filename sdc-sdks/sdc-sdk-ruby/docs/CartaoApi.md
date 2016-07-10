# SDC::CartaoApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bloquear_using_put**](CartaoApi.md#bloquear_using_put) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/bloquear | Bloquear um cart\u00C3\u00A3o.
[**cancelar_using_delete**](CartaoApi.md#cancelar_using_delete) | **DELETE** /v1/contas/{idConta}/cartoes/{idCartao}/cancelar | Cancelar um cart\u00C3\u00A3o
[**create_using_post**](CartaoApi.md#create_using_post) | **POST** /v1/contas/{idConta}/cartoes | Cria um cart\u00C3\u00A3o
[**creditar_using_put**](CartaoApi.md#creditar_using_put) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/creditar | Creditar dinheiro em um cart\u00C3\u00A3o
[**desbloquear_using_put**](CartaoApi.md#desbloquear_using_put) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/desbloquear | Desbloquear um cart\u00C3\u00A3o.
[**extratos_using_post**](CartaoApi.md#extratos_using_post) | **POST** /v1/contas/{idConta}/cartoes/{idCartao}/extratos | Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o
[**get_all_using_get**](CartaoApi.md#get_all_using_get) | **GET** /v1/contas/{idConta}/cartoes | Retona todos os cart\u00C3\u00A3o de uma conta
[**get_one_using_get**](CartaoApi.md#get_one_using_get) | **GET** /v1/contas/{idConta}/cartoes/{idCartao} | Retorna um cart\u00C3\u00A3o
[**limite_using_get**](CartaoApi.md#limite_using_get) | **GET** /v1/contas/{idConta}/cartoes/{idCartao}/limite | Retorna o limite do cart\u00C3\u00A3o
[**transacionar_using_put**](CartaoApi.md#transacionar_using_put) | **PUT** /v1/contas/{idConta}/cartoes/{idCartao}/transacionar | Transacionar valores
[**transferir_using_post**](CartaoApi.md#transferir_using_post) | **POST** /v1/contas/{idConta}/cartoes/{idCartao}/transferir | Transferir valores entre dois cart\u00C3\u00B5es distintos
[**update_using_put**](CartaoApi.md#update_using_put) | **PUT** /v1/contas/{idConta}/cartoes | Atualiza um cart\u00C3\u00A3o


# **bloquear_using_put**
> Response bloquear_using_put(id_conta, id_cartao)

Bloquear um cart\u00C3\u00A3o.

Bloquear um cart\u00C3\u00A3o.

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

id_cartao = 789 # Integer | Cart\u00C3\u00A3o a ser bloqueado


begin
  #Bloquear um cart\u00C3\u00A3o.
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
 **id_cartao** | **Integer**| Cart\u00C3\u00A3o a ser bloqueado | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **cancelar_using_delete**
> Response cancelar_using_delete(id_conta, id_cartao)

Cancelar um cart\u00C3\u00A3o

Cancelar um determinado cart\u00C3\u00A3o

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

id_cartao = 789 # Integer | Cart\u00C3\u00A3o a ser cancelado


begin
  #Cancelar um cart\u00C3\u00A3o
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
 **id_cartao** | **Integer**| Cart\u00C3\u00A3o a ser cancelado | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **create_using_post**
> Cartao create_using_post(id_conta, cartao)

Cria um cart\u00C3\u00A3o

Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.

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

cartao = SDC::Cartao.new # Cartao | Cart\u00C3\u00A3o a ser criado


begin
  #Cria um cart\u00C3\u00A3o
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
 **cartao** | [**Cartao**](Cartao.md)| Cart\u00C3\u00A3o a ser criado | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **creditar_using_put**
> Response creditar_using_put(id_conta, id_cartao, valor)

Creditar dinheiro em um cart\u00C3\u00A3o

Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.

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
  #Creditar dinheiro em um cart\u00C3\u00A3o
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

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **desbloquear_using_put**
> Response desbloquear_using_put(id_conta, id_cartao)

Desbloquear um cart\u00C3\u00A3o.

Desbloquear um determinado cart\u00C3\u00A3o.

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

id_cartao = 789 # Integer | Cart\u00C3\u00A3o a ser desbloqueado


begin
  #Desbloquear um cart\u00C3\u00A3o.
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
 **id_cartao** | **Integer**| Cart\u00C3\u00A3o a ser desbloqueado | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **extratos_using_post**
> Array&lt;Transacao&gt; extratos_using_post(id_conta, id_cartao)

Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o

Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o

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

id_cartao = 789 # Integer | ID do cart\u00C3\u00A3o


begin
  #Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o
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
 **id_cartao** | **Integer**| ID do cart\u00C3\u00A3o | 

### Return type

[**Array&lt;Transacao&gt;**](Transacao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **get_all_using_get**
> Array&lt;Cartao&gt; get_all_using_get(id_conta)

Retona todos os cart\u00C3\u00A3o de uma conta

Consulte todos os carteos de uma determinada conta.

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
  #Retona todos os cart\u00C3\u00A3o de uma conta
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

Retorna um cart\u00C3\u00A3o

Consulte um determinado cart\u00C3\u00A3o

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

id_cartao = 789 # Integer | ID do Cart\u00C3\u00A3o


begin
  #Retorna um cart\u00C3\u00A3o
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
 **id_cartao** | **Integer**| ID do Cart\u00C3\u00A3o | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **limite_using_get**
> Limite limite_using_get(id_conta, id_cartao)

Retorna o limite do cart\u00C3\u00A3o

Consultar o limite de um determinado cart\u00C3\u00A3o

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
  #Retorna o limite do cart\u00C3\u00A3o
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

[**Limite**](Limite.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **transacionar_using_put**
> Response transacionar_using_put(id_conta, id_cartao, valor)

Transacionar valores

Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o

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

valor = 1.2 # Float | Valor da transa\u00C3\u00A7\u00C3\u00A3o


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
 **valor** | **Float**| Valor da transa\u00C3\u00A7\u00C3\u00A3o | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **transferir_using_post**
> Response transferir_using_post(id_conta, id_cartao, id_cartao_destino, valor)

Transferir valores entre dois cart\u00C3\u00B5es distintos

Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.

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

id_conta = 789 # Integer | ID da Conta do cart\u00C3\u00A3o de origem

id_cartao = 789 # Integer | ID do cart\u00C3\u00A3o de origem

id_cartao_destino = 789 # Integer | ID do cart\u00C3\u00A3o de destino

valor = 1.2 # Float | Valor a ser transferido


begin
  #Transferir valores entre dois cart\u00C3\u00B5es distintos
  result = api_instance.transferir_using_post(id_conta, id_cartao, id_cartao_destino, valor)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling CartaoApi->transferir_using_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id_conta** | **Integer**| ID da Conta do cart\u00C3\u00A3o de origem | 
 **id_cartao** | **Integer**| ID do cart\u00C3\u00A3o de origem | 
 **id_cartao_destino** | **Integer**| ID do cart\u00C3\u00A3o de destino | 
 **valor** | **Float**| Valor a ser transferido | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **update_using_put**
> Cartao update_using_put(id_conta, cartao)

Atualiza um cart\u00C3\u00A3o

Atualiza um determinado cart\u00C3\u00A3o

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

cartao = SDC::Cartao.new # Cartao | Cart\u00C3\u00A3o a ser atualizado


begin
  #Atualiza um cart\u00C3\u00A3o
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
 **cartao** | [**Cartao**](Cartao.md)| Cart\u00C3\u00A3o a ser atualizado | 

### Return type

[**Cartao**](Cartao.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



