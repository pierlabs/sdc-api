package br.com.conductor.sdc.api.v1;

import com.sun.jersey.api.client.GenericType;

import br.com.conductor.sdc.api.v1.invoker.ApiException;
import br.com.conductor.sdc.api.v1.invoker.ApiClient;
import br.com.conductor.sdc.api.v1.invoker.Configuration;
import br.com.conductor.sdc.api.v1.invoker.Pair;

import br.com.conductor.sdc.api.v1.model.Response;
import br.com.conductor.sdc.api.v1.model.Cartao;
import br.com.conductor.sdc.api.v1.model.Transacao;
import br.com.conductor.sdc.api.v1.model.Limite;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen")
public class CartaoApi {
  private ApiClient apiClient;

  public CartaoApi() {
    this(Configuration.getDefaultApiClient());
  }

  public CartaoApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /**
   * Bloquear um cart\u00C3\u00A3o.
   * Bloquear um cart\u00C3\u00A3o.
   * @param idConta ID da Conta
   * @param idCartao Cart\u00C3\u00A3o a ser bloqueado
   * @return Response
   */
  public Response bloquearUsingPUT(Long idConta, Long idCartao) throws ApiException {
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
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/bloquear".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()))
      .replaceAll("\\{" + "idCartao" + "\\}", apiClient.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<Response> returnType = new GenericType<Response>() {};
    return apiClient.invokeAPI(path, "PUT", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Cancelar um cart\u00C3\u00A3o
   * Cancelar um determinado cart\u00C3\u00A3o
   * @param idConta ID da Conta
   * @param idCartao Cart\u00C3\u00A3o a ser cancelado
   * @return Response
   */
  public Response cancelarUsingDELETE(Long idConta, Long idCartao) throws ApiException {
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
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/cancelar".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()))
      .replaceAll("\\{" + "idCartao" + "\\}", apiClient.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<Response> returnType = new GenericType<Response>() {};
    return apiClient.invokeAPI(path, "DELETE", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Cria um cart\u00C3\u00A3o
   * Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
   * @param idConta ID da Conta
   * @param cartao Cart\u00C3\u00A3o a ser criado
   * @return Cartao
   */
  public Cartao createUsingPOST(Long idConta, Cartao cartao) throws ApiException {
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
    String path = "/v1/contas/{idConta}/cartoes".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<Cartao> returnType = new GenericType<Cartao>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Creditar dinheiro em um cart\u00C3\u00A3o
   * Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
   * @param idConta ID da Conta
   * @param idCartao ID do Cartao a ser creditado
   * @param valor Valor a ser creditado
   * @return Response
   */
  public Response creditarUsingPUT(Long idConta, Long idCartao, Double valor) throws ApiException {
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
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/creditar".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()))
      .replaceAll("\\{" + "idCartao" + "\\}", apiClient.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<Response> returnType = new GenericType<Response>() {};
    return apiClient.invokeAPI(path, "PUT", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Desbloquear um cart\u00C3\u00A3o.
   * Desbloquear um determinado cart\u00C3\u00A3o.
   * @param idConta ID da Conta
   * @param idCartao Cart\u00C3\u00A3o a ser desbloqueado
   * @return Response
   */
  public Response desbloquearUsingPUT(Long idConta, Long idCartao) throws ApiException {
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
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/desbloquear".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()))
      .replaceAll("\\{" + "idCartao" + "\\}", apiClient.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<Response> returnType = new GenericType<Response>() {};
    return apiClient.invokeAPI(path, "PUT", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o
   * Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
   * @param idConta ID da Conta
   * @param idCartao ID do cart\u00C3\u00A3o
   * @return List<Transacao>
   */
  public List<Transacao> extratosUsingPOST(Long idConta, Long idCartao) throws ApiException {
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
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/extratos".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()))
      .replaceAll("\\{" + "idCartao" + "\\}", apiClient.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<List<Transacao>> returnType = new GenericType<List<Transacao>>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Retona todos os cart\u00C3\u00A3o de uma conta
   * Consulte todos os carteos de uma determinada conta.
   * @param idConta ID da Conta
   * @return List<Cartao>
   */
  public List<Cartao> getAllUsingGET(Long idConta) throws ApiException {
    Object postBody = null;
    
     // verify the required parameter 'idConta' is set
     if (idConta == null) {
        throw new ApiException(400, "Missing the required parameter 'idConta' when calling getAllUsingGET");
     }
     
    // create path and map variables
    String path = "/v1/contas/{idConta}/cartoes".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<List<Cartao>> returnType = new GenericType<List<Cartao>>() {};
    return apiClient.invokeAPI(path, "GET", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Retorna um cart\u00C3\u00A3o
   * Consulte um determinado cart\u00C3\u00A3o
   * @param idConta ID da Conta
   * @param idCartao ID do Cart\u00C3\u00A3o
   * @return Cartao
   */
  public Cartao getOneUsingGET(Long idConta, Long idCartao) throws ApiException {
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
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()))
      .replaceAll("\\{" + "idCartao" + "\\}", apiClient.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<Cartao> returnType = new GenericType<Cartao>() {};
    return apiClient.invokeAPI(path, "GET", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Retorna o limite do cart\u00C3\u00A3o
   * Consultar o limite de um determinado cart\u00C3\u00A3o
   * @param idConta ID da Conta
   * @param idCartao ID do Cartao a ser creditado
   * @return Limite
   */
  public Limite limiteUsingGET(Long idConta, Long idCartao) throws ApiException {
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
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/limite".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()))
      .replaceAll("\\{" + "idCartao" + "\\}", apiClient.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<Limite> returnType = new GenericType<Limite>() {};
    return apiClient.invokeAPI(path, "GET", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Transacionar valores
   * Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
   * @param idConta ID da Conta
   * @param idCartao ID do Cartao a ser creditado
   * @param valor Valor da transa\u00C3\u00A7\u00C3\u00A3o
   * @return Response
   */
  public Response transacionarUsingPUT(Long idConta, Long idCartao, Double valor) throws ApiException {
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
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/transacionar".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()))
      .replaceAll("\\{" + "idCartao" + "\\}", apiClient.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<Response> returnType = new GenericType<Response>() {};
    return apiClient.invokeAPI(path, "PUT", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Transferir valores entre dois cart\u00C3\u00B5es distintos
   * Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
   * @param idConta ID da Conta do cart\u00C3\u00A3o de origem
   * @param idCartao ID do cart\u00C3\u00A3o de origem
   * @param idCartaoDestino ID do cart\u00C3\u00A3o de destino
   * @param valor Valor a ser transferido
   * @return Response
   */
  public Response transferirUsingPOST(Long idConta, Long idCartao, Long idCartaoDestino, Double valor) throws ApiException {
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
    String path = "/v1/contas/{idConta}/cartoes/{idCartao}/transferir".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()))
      .replaceAll("\\{" + "idCartao" + "\\}", apiClient.escapeString(idCartao.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    
    queryParams.addAll(apiClient.parameterToPairs("", "idCartaoDestino", idCartaoDestino));
    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<Response> returnType = new GenericType<Response>() {};
    return apiClient.invokeAPI(path, "POST", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
  /**
   * Atualiza um cart\u00C3\u00A3o
   * Atualiza um determinado cart\u00C3\u00A3o
   * @param idConta ID da Conta
   * @param cartao Cart\u00C3\u00A3o a ser atualizado
   * @return Cartao
   */
  public Cartao updateUsingPUT(Long idConta, Cartao cartao) throws ApiException {
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
    String path = "/v1/contas/{idConta}/cartoes".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "idConta" + "\\}", apiClient.escapeString(idConta.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    Map<String, String> headerParams = new HashMap<String, String>();
    Map<String, Object> formParams = new HashMap<String, Object>();

    

    

    

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);

    String[] authNames = new String[] {"client_id", "access_token" };

    
    GenericType<Cartao> returnType = new GenericType<Cartao>() {};
    return apiClient.invokeAPI(path, "PUT", queryParams, postBody, headerParams, formParams, accept, contentType, authNames, returnType);
    
  }
  
}
