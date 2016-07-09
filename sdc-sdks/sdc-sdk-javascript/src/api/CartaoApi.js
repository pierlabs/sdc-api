(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', '../model/Response', '../model/Cartao', '../model/Limite'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/Response'), require('../model/Cartao'), require('../model/Limite'));
  } else {
    // Browser globals (root is window)
    if (!root.SDC) {
      root.SDC = {};
    }
    root.SDC.CartaoApi = factory(root.SDC.ApiClient, root.SDC.Response, root.SDC.Cartao, root.SDC.Limite);
  }
}(this, function(ApiClient, Response, Cartao, Limite) {
  'use strict';

  /**
   * Cartao service.
   * @module api/CartaoApi
   * @version 1.0.0
   */

  /**
   * Constructs a new CartaoApi. 
   * @alias module:api/CartaoApi
   * @class
   * @param {module:ApiClient} apiClient Optional API client implementation to use, default to {@link module:ApiClient#instance}
   * if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the bloquearUsingPUT operation.
     * @callback module:api/CartaoApi~bloquearUsingPUTCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Response} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Bloquear um cart\u00C3\u00A3o.
     * Bloquear um cart\u00C3\u00A3o.
     * @param {Integer} idConta ID da Conta
     * @param {Integer} idCartao Cart\u00C3\u00A3o a ser bloqueado
     * @param {module:api/CartaoApi~bloquearUsingPUTCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Response}
     */
    this.bloquearUsingPUT = function(idConta, idCartao, callback) {
      var postBody = null;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling bloquearUsingPUT";
      }

      // verify the required parameter 'idCartao' is set
      if (idCartao == undefined || idCartao == null) {
        throw "Missing the required parameter 'idCartao' when calling bloquearUsingPUT";
      }


      var pathParams = {
        'idConta': idConta,
        'idCartao': idCartao
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Response;

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes/{idCartao}/bloquear', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the cancelarUsingDELETE operation.
     * @callback module:api/CartaoApi~cancelarUsingDELETECallback
     * @param {String} error Error message, if any.
     * @param {module:model/Response} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Cancelar um cart\u00C3\u00A3o
     * Cancelar um determinado cart\u00C3\u00A3o
     * @param {Integer} idConta ID da Conta
     * @param {Integer} idCartao Cart\u00C3\u00A3o a ser cancelado
     * @param {module:api/CartaoApi~cancelarUsingDELETECallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Response}
     */
    this.cancelarUsingDELETE = function(idConta, idCartao, callback) {
      var postBody = null;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling cancelarUsingDELETE";
      }

      // verify the required parameter 'idCartao' is set
      if (idCartao == undefined || idCartao == null) {
        throw "Missing the required parameter 'idCartao' when calling cancelarUsingDELETE";
      }


      var pathParams = {
        'idConta': idConta,
        'idCartao': idCartao
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Response;

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes/{idCartao}/cancelar', 'DELETE',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the createUsingPOST operation.
     * @callback module:api/CartaoApi~createUsingPOSTCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Cartao} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Cria um cart\u00C3\u00A3o
     * Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
     * @param {Integer} idConta ID da Conta
     * @param {module:model/Cartao} cartao Cart\u00C3\u00A3o a ser criado
     * @param {module:api/CartaoApi~createUsingPOSTCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Cartao}
     */
    this.createUsingPOST = function(idConta, cartao, callback) {
      var postBody = cartao;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling createUsingPOST";
      }

      // verify the required parameter 'cartao' is set
      if (cartao == undefined || cartao == null) {
        throw "Missing the required parameter 'cartao' when calling createUsingPOST";
      }


      var pathParams = {
        'idConta': idConta
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Cartao;

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the creditarUsingPUT operation.
     * @callback module:api/CartaoApi~creditarUsingPUTCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Response} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Creditar dinheiro em um cart\u00C3\u00A3o
     * Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
     * @param {Integer} idConta ID da Conta
     * @param {Integer} idCartao ID do Cartao a ser creditado
     * @param {Number} valor Valor a ser creditado
     * @param {module:api/CartaoApi~creditarUsingPUTCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Response}
     */
    this.creditarUsingPUT = function(idConta, idCartao, valor, callback) {
      var postBody = valor;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling creditarUsingPUT";
      }

      // verify the required parameter 'idCartao' is set
      if (idCartao == undefined || idCartao == null) {
        throw "Missing the required parameter 'idCartao' when calling creditarUsingPUT";
      }

      // verify the required parameter 'valor' is set
      if (valor == undefined || valor == null) {
        throw "Missing the required parameter 'valor' when calling creditarUsingPUT";
      }


      var pathParams = {
        'idConta': idConta,
        'idCartao': idCartao
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Response;

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes/{idCartao}/creditar', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the desbloquearUsingPUT operation.
     * @callback module:api/CartaoApi~desbloquearUsingPUTCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Response} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Desbloquear um cart\u00C3\u00A3o.
     * Desbloquear um determinado cart\u00C3\u00A3o.
     * @param {Integer} idConta ID da Conta
     * @param {Integer} idCartao Cart\u00C3\u00A3o a ser desbloqueado
     * @param {module:api/CartaoApi~desbloquearUsingPUTCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Response}
     */
    this.desbloquearUsingPUT = function(idConta, idCartao, callback) {
      var postBody = null;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling desbloquearUsingPUT";
      }

      // verify the required parameter 'idCartao' is set
      if (idCartao == undefined || idCartao == null) {
        throw "Missing the required parameter 'idCartao' when calling desbloquearUsingPUT";
      }


      var pathParams = {
        'idConta': idConta,
        'idCartao': idCartao
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Response;

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes/{idCartao}/desbloquear', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the extratosUsingPOST operation.
     * @callback module:api/CartaoApi~extratosUsingPOSTCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Response} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o
     * Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
     * @param {Integer} idConta ID da Conta
     * @param {Integer} idCartao ID do cart\u00C3\u00A3o
     * @param {module:api/CartaoApi~extratosUsingPOSTCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Response}
     */
    this.extratosUsingPOST = function(idConta, idCartao, callback) {
      var postBody = null;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling extratosUsingPOST";
      }

      // verify the required parameter 'idCartao' is set
      if (idCartao == undefined || idCartao == null) {
        throw "Missing the required parameter 'idCartao' when calling extratosUsingPOST";
      }


      var pathParams = {
        'idConta': idConta,
        'idCartao': idCartao
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Response;

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes/{idCartao}/extratos', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getAllUsingGET operation.
     * @callback module:api/CartaoApi~getAllUsingGETCallback
     * @param {String} error Error message, if any.
     * @param {Array.<module:model/Cartao>} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Retona todos os cart\u00C3\u00A3o de uma conta
     * Consulte todos os carteos de uma determinada conta.
     * @param {Integer} idConta ID da Conta
     * @param {module:api/CartaoApi~getAllUsingGETCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {Array.<module:model/Cartao>}
     */
    this.getAllUsingGET = function(idConta, callback) {
      var postBody = null;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling getAllUsingGET";
      }


      var pathParams = {
        'idConta': idConta
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = [Cartao];

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getOneUsingGET operation.
     * @callback module:api/CartaoApi~getOneUsingGETCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Cartao} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Retorna um cart\u00C3\u00A3o
     * Consulte um determinado cart\u00C3\u00A3o
     * @param {Integer} idConta ID da Conta
     * @param {Integer} idCartao ID do Cart\u00C3\u00A3o
     * @param {module:api/CartaoApi~getOneUsingGETCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Cartao}
     */
    this.getOneUsingGET = function(idConta, idCartao, callback) {
      var postBody = null;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling getOneUsingGET";
      }

      // verify the required parameter 'idCartao' is set
      if (idCartao == undefined || idCartao == null) {
        throw "Missing the required parameter 'idCartao' when calling getOneUsingGET";
      }


      var pathParams = {
        'idConta': idConta,
        'idCartao': idCartao
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Cartao;

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes/{idCartao}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the limiteUsingGET operation.
     * @callback module:api/CartaoApi~limiteUsingGETCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Limite} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Retorna o limite do cart\u00C3\u00A3o
     * Consultar o limite de um determinado cart\u00C3\u00A3o
     * @param {Integer} idConta ID da Conta
     * @param {Integer} idCartao ID do Cartao a ser creditado
     * @param {module:api/CartaoApi~limiteUsingGETCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Limite}
     */
    this.limiteUsingGET = function(idConta, idCartao, callback) {
      var postBody = null;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling limiteUsingGET";
      }

      // verify the required parameter 'idCartao' is set
      if (idCartao == undefined || idCartao == null) {
        throw "Missing the required parameter 'idCartao' when calling limiteUsingGET";
      }


      var pathParams = {
        'idConta': idConta,
        'idCartao': idCartao
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Limite;

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes/{idCartao}/limite', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the transacionarUsingPUT operation.
     * @callback module:api/CartaoApi~transacionarUsingPUTCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Response} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Transacionar valores
     * Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
     * @param {Integer} idConta ID da Conta
     * @param {Integer} idCartao ID do Cartao a ser creditado
     * @param {Number} valor Valor da transa\u00C3\u00A7\u00C3\u00A3o
     * @param {module:api/CartaoApi~transacionarUsingPUTCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Response}
     */
    this.transacionarUsingPUT = function(idConta, idCartao, valor, callback) {
      var postBody = valor;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling transacionarUsingPUT";
      }

      // verify the required parameter 'idCartao' is set
      if (idCartao == undefined || idCartao == null) {
        throw "Missing the required parameter 'idCartao' when calling transacionarUsingPUT";
      }

      // verify the required parameter 'valor' is set
      if (valor == undefined || valor == null) {
        throw "Missing the required parameter 'valor' when calling transacionarUsingPUT";
      }


      var pathParams = {
        'idConta': idConta,
        'idCartao': idCartao
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Response;

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes/{idCartao}/transacionar', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the transferirUsingPOST operation.
     * @callback module:api/CartaoApi~transferirUsingPOSTCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Response} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Transferir valores entre dois cart\u00C3\u00B5es distintos
     * Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
     * @param {Integer} idConta ID da Conta do cart\u00C3\u00A3o de origem
     * @param {Integer} idCartao ID do cart\u00C3\u00A3o de origem
     * @param {Integer} idCartaoDestino ID do cart\u00C3\u00A3o de destino
     * @param {Number} valor Valor a ser transferido
     * @param {module:api/CartaoApi~transferirUsingPOSTCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Response}
     */
    this.transferirUsingPOST = function(idConta, idCartao, idCartaoDestino, valor, callback) {
      var postBody = valor;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling transferirUsingPOST";
      }

      // verify the required parameter 'idCartao' is set
      if (idCartao == undefined || idCartao == null) {
        throw "Missing the required parameter 'idCartao' when calling transferirUsingPOST";
      }

      // verify the required parameter 'idCartaoDestino' is set
      if (idCartaoDestino == undefined || idCartaoDestino == null) {
        throw "Missing the required parameter 'idCartaoDestino' when calling transferirUsingPOST";
      }

      // verify the required parameter 'valor' is set
      if (valor == undefined || valor == null) {
        throw "Missing the required parameter 'valor' when calling transferirUsingPOST";
      }


      var pathParams = {
        'idConta': idConta,
        'idCartao': idCartao
      };
      var queryParams = {
        'idCartaoDestino': idCartaoDestino
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Response;

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes/{idCartao}/transferir', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the updateUsingPUT operation.
     * @callback module:api/CartaoApi~updateUsingPUTCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Cartao} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Atualiza um cart\u00C3\u00A3o
     * Atualiza um determinado cart\u00C3\u00A3o
     * @param {Integer} idConta ID da Conta
     * @param {module:model/Cartao} cartao Cart\u00C3\u00A3o a ser atualizado
     * @param {module:api/CartaoApi~updateUsingPUTCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Cartao}
     */
    this.updateUsingPUT = function(idConta, cartao, callback) {
      var postBody = cartao;

      // verify the required parameter 'idConta' is set
      if (idConta == undefined || idConta == null) {
        throw "Missing the required parameter 'idConta' when calling updateUsingPUT";
      }

      // verify the required parameter 'cartao' is set
      if (cartao == undefined || cartao == null) {
        throw "Missing the required parameter 'cartao' when calling updateUsingPUT";
      }


      var pathParams = {
        'idConta': idConta
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Cartao;

      return this.apiClient.callApi(
        '/v1/contas/{idConta}/cartoes', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
