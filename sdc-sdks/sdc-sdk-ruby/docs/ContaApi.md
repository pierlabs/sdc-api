# SDC::ContaApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**create_using_post1**](ContaApi.md#create_using_post1) | **POST** /v1/contas | Cria uma conta
[**delete_using_delete**](ContaApi.md#delete_using_delete) | **DELETE** /v1/contas/{id} | Deleta uma conta
[**get_all_using_get1**](ContaApi.md#get_all_using_get1) | **GET** /v1/contas | Retorna todas as contas
[**get_one_using_get1**](ContaApi.md#get_one_using_get1) | **GET** /v1/contas/{id} | Retorna uma conta
[**update_using_put1**](ContaApi.md#update_using_put1) | **PUT** /v1/contas | Atualiza uma conta


# **create_using_post1**
> Conta create_using_post1(conta)

Cria uma conta

Cria uma conta

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

api_instance = SDC::ContaApi.new

conta = SDC::Conta.new # Conta | conta


begin
  #Cria uma conta
  result = api_instance.create_using_post1(conta)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling ContaApi->create_using_post1: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conta** | [**Conta**](Conta.md)| conta | 

### Return type

[**Conta**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **delete_using_delete**
> Response delete_using_delete(id)

Deleta uma conta

Deleta um cart\u00C3\u00A3o

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

api_instance = SDC::ContaApi.new

id = 789 # Integer | id


begin
  #Deleta uma conta
  result = api_instance.delete_using_delete(id)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling ContaApi->delete_using_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Integer**| id | 

### Return type

[**Response**](Response.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **get_all_using_get1**
> Array&lt;Conta&gt; get_all_using_get1

Retorna todas as contas

Retorna todas as contas

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

api_instance = SDC::ContaApi.new

begin
  #Retorna todas as contas
  result = api_instance.get_all_using_get1
  p result
rescue SDC::ApiError => e
  puts "Exception when calling ContaApi->get_all_using_get1: #{e}"
end
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Array&lt;Conta&gt;**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **get_one_using_get1**
> Conta get_one_using_get1(id)

Retorna uma conta

Retorna uma conta

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

api_instance = SDC::ContaApi.new

id = 789 # Integer | id


begin
  #Retorna uma conta
  result = api_instance.get_one_using_get1(id)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling ContaApi->get_one_using_get1: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Integer**| id | 

### Return type

[**Conta**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **update_using_put1**
> Conta update_using_put1(conta)

Atualiza uma conta

Atualiza uma conta

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

api_instance = SDC::ContaApi.new

conta = SDC::Conta.new # Conta | conta


begin
  #Atualiza uma conta
  result = api_instance.update_using_put1(conta)
  p result
rescue SDC::ApiError => e
  puts "Exception when calling ContaApi->update_using_put1: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conta** | [**Conta**](Conta.md)| conta | 

### Return type

[**Conta**](Conta.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



