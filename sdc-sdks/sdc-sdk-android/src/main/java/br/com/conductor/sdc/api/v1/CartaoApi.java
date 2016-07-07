package br.com.conductor.sdc.api.v1;

import br.com.conductor.sdc.api.v1.invoker.ApiException;
import br.com.conductor.sdc.api.v1.invoker.ApiInvoker;
import br.com.conductor.sdc.api.v1.invoker.Pair;

import br.com.conductor.sdc.api.v1.model.*;

import java.util.*;

import br.com.conductor.sdc.api.v1.model.ResponseEntity;
import br.com.conductor.sdc.api.v1.model.Cartao;


import org.apache.http.HttpEntity;
import org.apache.http.entity.mime.MultipartEntityBuilder;

import java.util.Map;
import java.util.HashMap;
import java.io.File;


public class CartaoApi {
  String basePath = "https://localhost/";
  ApiInvoker apiInvoker = ApiInvoker.getInstance();

  public void addHeader(String key, String value) {
    getInvoker().addDefaultHeader(key, value);
  }

  public ApiInvoker getInvoker() {
    return apiInvoker;
  }

  public void setBasePath(String basePath) {
    this.basePath = basePath;
  }

  public String getBasePath() {
    return basePath;
  }

  
  /**
   * Bloquear um cart\u00EF\u00BF\u00BDo.
   * Bloquear um cart\u00EF\u00BF\u00BDo.
   * @param idConta ID da Conta
   * @param idCartao Cart\u00EF\u00BF\u00BDo a ser bloqueado
   * @return ResponseEntity
   */
  public ResponseEntity  bloquearUsingPUT (Long idConta, Long idCartao) throws ApiException {
    Object postBody = null;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling bloquearUsingPUT");
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == null) {
       throw new ApiException(400, "Missing the required parameter 'idCartao' when calling bloquearUsingPUT");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/bloquear".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString())).replaceAll("\\{" + "idCartao" + "\\}", apiInvoker.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "PUT", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (ResponseEntity) ApiInvoker.deserialize(response, "", ResponseEntity.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
  /**
   * Cancelar um cart\u00EF\u00BF\u00BDo
   * Cancelar um cart\u00EF\u00BF\u00BDo
   * @param idConta ID da Conta
   * @param idCartao Cart\u00EF\u00BF\u00BDo a ser cancelado
   * @return ResponseEntity
   */
  public ResponseEntity  cancelarUsingDELETE (Long idConta, Long idCartao) throws ApiException {
    Object postBody = null;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling cancelarUsingDELETE");
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == null) {
       throw new ApiException(400, "Missing the required parameter 'idCartao' when calling cancelarUsingDELETE");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/cancelar".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString())).replaceAll("\\{" + "idCartao" + "\\}", apiInvoker.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "DELETE", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (ResponseEntity) ApiInvoker.deserialize(response, "", ResponseEntity.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
  /**
   * Cria um cart\u00EF\u00BF\u00BDo
   * Cria um cart\u00EF\u00BF\u00BDo
   * @param idConta ID da Conta
   * @param cartao Cart\u00EF\u00BF\u00BDo a ser criado
   * @return Cartao
   */
  public Cartao  createUsingPOST (Long idConta, Cartao cartao) throws ApiException {
    Object postBody = cartao;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling createUsingPOST");
    }
    
    // verify the required parameter 'cartao' is set
    if (cartao == null) {
       throw new ApiException(400, "Missing the required parameter 'cartao' when calling createUsingPOST");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (Cartao) ApiInvoker.deserialize(response, "", Cartao.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
  /**
   * Creditar dinheiro em um cart\u00EF\u00BF\u00BDo
   * Creditar dinheiro em um cart\u00EF\u00BF\u00BDo
   * @param idConta ID da Conta
   * @param idCartao ID do Cartao a ser creditado
   * @param valor Valor a ser creditado
   * @return ResponseEntity
   */
  public ResponseEntity  creditarUsingPUT (Long idConta, Long idCartao, Double valor) throws ApiException {
    Object postBody = valor;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling creditarUsingPUT");
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == null) {
       throw new ApiException(400, "Missing the required parameter 'idCartao' when calling creditarUsingPUT");
    }
    
    // verify the required parameter 'valor' is set
    if (valor == null) {
       throw new ApiException(400, "Missing the required parameter 'valor' when calling creditarUsingPUT");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/creditar".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString())).replaceAll("\\{" + "idCartao" + "\\}", apiInvoker.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "PUT", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (ResponseEntity) ApiInvoker.deserialize(response, "", ResponseEntity.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
  /**
   * Desbloquear um cart\u00EF\u00BF\u00BDo.
   * Desbloquear um cart\u00EF\u00BF\u00BDo.
   * @param idConta ID da Conta
   * @param idCartao Cart\u00EF\u00BF\u00BDo a ser desbloqueado
   * @return ResponseEntity
   */
  public ResponseEntity  desbloquearUsingPUT (Long idConta, Long idCartao) throws ApiException {
    Object postBody = null;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling desbloquearUsingPUT");
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == null) {
       throw new ApiException(400, "Missing the required parameter 'idCartao' when calling desbloquearUsingPUT");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/desbloquear".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString())).replaceAll("\\{" + "idCartao" + "\\}", apiInvoker.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "PUT", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (ResponseEntity) ApiInvoker.deserialize(response, "", ResponseEntity.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
  /**
   * Retonar os extratos de transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes do cart\u00EF\u00BF\u00BDo
   * Retorna os extratos de todas as transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDes de um determinado cart\u00EF\u00BF\u00BDo
   * @param idConta ID da Conta
   * @param idCartao ID do cart\u00EF\u00BF\u00BDo
   * @return ResponseEntity
   */
  public ResponseEntity  extratosUsingPOST (Long idConta, Long idCartao) throws ApiException {
    Object postBody = null;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling extratosUsingPOST");
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == null) {
       throw new ApiException(400, "Missing the required parameter 'idCartao' when calling extratosUsingPOST");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/extratos".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString())).replaceAll("\\{" + "idCartao" + "\\}", apiInvoker.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (ResponseEntity) ApiInvoker.deserialize(response, "", ResponseEntity.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
  /**
   * Retona todos os cart\u00EF\u00BF\u00BDo de uma conta
   * Retona todos os cart\u00EF\u00BF\u00BDo de uma conta
   * @param idConta ID da Conta
   * @return List<Cartao>
   */
  public List<Cartao>  getAllUsingGET (Long idConta) throws ApiException {
    Object postBody = null;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling getAllUsingGET");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (List<Cartao>) ApiInvoker.deserialize(response, "array", Cartao.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
  /**
   * Retorna um cart\u00EF\u00BF\u00BDo
   * Retorna um cart\u00EF\u00BF\u00BDo
   * @param idConta ID da Conta
   * @param idCartao ID do Cart\u00EF\u00BF\u00BDo
   * @return Cartao
   */
  public Cartao  getOneUsingGET (Long idConta, Long idCartao) throws ApiException {
    Object postBody = null;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling getOneUsingGET");
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == null) {
       throw new ApiException(400, "Missing the required parameter 'idCartao' when calling getOneUsingGET");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString())).replaceAll("\\{" + "idCartao" + "\\}", apiInvoker.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (Cartao) ApiInvoker.deserialize(response, "", Cartao.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
  /**
   * Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo
   * Consultar o limite de um determinado cart\u00EF\u00BF\u00BDo
   * @param idConta ID da Conta
   * @param idCartao ID do Cartao a ser creditado
   * @return ResponseEntity
   */
  public ResponseEntity  limiteUsingGET (Long idConta, Long idCartao) throws ApiException {
    Object postBody = null;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling limiteUsingGET");
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == null) {
       throw new ApiException(400, "Missing the required parameter 'idCartao' when calling limiteUsingGET");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/limite".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString())).replaceAll("\\{" + "idCartao" + "\\}", apiInvoker.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (ResponseEntity) ApiInvoker.deserialize(response, "", ResponseEntity.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
  /**
   * Transacionar valores
   * Transacionar algum valor utilizando um determinado cart\u00EF\u00BF\u00BDo
   * @param idConta ID da Conta
   * @param idCartao ID do Cartao a ser creditado
   * @param valor Valor da transa\u00EF\u00BF\u00BD\u00EF\u00BF\u00BDo
   * @return ResponseEntity
   */
  public ResponseEntity  transacionarUsingPUT (Long idConta, Long idCartao, Double valor) throws ApiException {
    Object postBody = valor;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling transacionarUsingPUT");
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == null) {
       throw new ApiException(400, "Missing the required parameter 'idCartao' when calling transacionarUsingPUT");
    }
    
    // verify the required parameter 'valor' is set
    if (valor == null) {
       throw new ApiException(400, "Missing the required parameter 'valor' when calling transacionarUsingPUT");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/transacionar".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString())).replaceAll("\\{" + "idCartao" + "\\}", apiInvoker.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "PUT", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (ResponseEntity) ApiInvoker.deserialize(response, "", ResponseEntity.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
  /**
   * Transferir valores entre dois cart\u00EF\u00BF\u00BDes distintos
   * Transferir valores entre dois cart\u00EF\u00BF\u00BDes
   * @param idConta ID da Conta do cart\u00EF\u00BF\u00BDo de origem
   * @param idCartao ID do cart\u00EF\u00BF\u00BDo de origem
   * @param idCartaoDestino ID do cart\u00EF\u00BF\u00BDo de destino
   * @param valor Valor a ser transferido
   * @return ResponseEntity
   */
  public ResponseEntity  transferirUsingPOST (Long idConta, Long idCartao, Long idCartaoDestino, Double valor) throws ApiException {
    Object postBody = valor;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling transferirUsingPOST");
    }
    
    // verify the required parameter 'idCartao' is set
    if (idCartao == null) {
       throw new ApiException(400, "Missing the required parameter 'idCartao' when calling transferirUsingPOST");
    }
    
    // verify the required parameter 'idCartaoDestino' is set
    if (idCartaoDestino == null) {
       throw new ApiException(400, "Missing the required parameter 'idCartaoDestino' when calling transferirUsingPOST");
    }
    
    // verify the required parameter 'valor' is set
    if (valor == null) {
       throw new ApiException(400, "Missing the required parameter 'valor' when calling transferirUsingPOST");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/transferir".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString())).replaceAll("\\{" + "idCartao" + "\\}", apiInvoker.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    
    queryParams.addAll(ApiInvoker.parameterToPairs("", "idCartaoDestino", idCartaoDestino));
    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (ResponseEntity) ApiInvoker.deserialize(response, "", ResponseEntity.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
  /**
   * Atualiza um cart\u00EF\u00BF\u00BDo
   * Atualiza um cart\u00EF\u00BF\u00BDo
   * @param idConta ID da Conta
   * @param cartao Cart\u00EF\u00BF\u00BDo a ser atualizado
   * @return Cartao
   */
  public Cartao  updateUsingPUT (Long idConta, Cartao cartao) throws ApiException {
    Object postBody = cartao;
    
    // verify the required parameter 'idConta' is set
    if (idConta == null) {
       throw new ApiException(400, "Missing the required parameter 'idConta' when calling updateUsingPUT");
    }
    
    // verify the required parameter 'cartao' is set
    if (cartao == null) {
       throw new ApiException(400, "Missing the required parameter 'cartao' when calling updateUsingPUT");
    }
    

    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes".replaceAll("\\{format\\}","json").replaceAll("\\{" + "idConta" + "\\}", apiInvoker.escapeString(idConta.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();

    

    

    String[] contentTypes = {
      "application/json"
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder builder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = builder.build();
      postBody = httpEntity;
    } else {
      // normal form params
      
    }

    try {
      String response = apiInvoker.invokeAPI(basePath, path, "PUT", queryParams, postBody, headerParams, formParams, contentType);
      if(response != null){
        return (Cartao) ApiInvoker.deserialize(response, "", Cartao.class);
      }
      else {
        return null;
      }
    } catch (ApiException ex) {
      throw ex;
    }
  }
  
}

