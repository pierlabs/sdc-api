(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', '../model/Conta', '../model/ResponseEntity'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/Conta'), require('../model/ResponseEntity'));
  } else {
    // Browser globals (root is window)
    if (!root.SDC) {
      root.SDC = {};
    }
    root.SDC.ContaApi = factory(root.SDC.ApiClient, root.SDC.Conta, root.SDC.ResponseEntity);
  }
}(this, function(ApiClient, Conta, ResponseEntity) {
  'use strict';

  /**
   * Conta service.
   * @module api/ContaApi
   * @version 1.0.0
   */

  /**
   * Constructs a new ContaApi. 
   * @alias module:api/ContaApi
   * @class
   * @param {module:ApiClient} apiClient Optional API client implementation to use, default to {@link module:ApiClient#instance}
   * if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the createUsingPOST1 operation.
     * @callback module:api/ContaApi~createUsingPOST1Callback
     * @param {String} error Error message, if any.
     * @param {module:model/Conta} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Cria uma conta
     * Cria uma conta
     * @param {module:model/Conta} conta conta
     * @param {module:api/ContaApi~createUsingPOST1Callback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Conta}
     */
    this.createUsingPOST1 = function(conta, callback) {
      var postBody = conta;

      // verify the required parameter 'conta' is set
      if (conta == undefined || conta == null) {
        throw "Missing the required parameter 'conta' when calling createUsingPOST1";
      }


      var pathParams = {
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
      var returnType = Conta;

      return this.apiClient.callApi(
        '/v1/contas', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the deleteUsingDELETE operation.
     * @callback module:api/ContaApi~deleteUsingDELETECallback
     * @param {String} error Error message, if any.
     * @param {module:model/ResponseEntity} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Deleta uma conta
     * Deleta um cart\u00EF\u00BF\u00BDo
     * @param {Integer} id id
     * @param {module:api/ContaApi~deleteUsingDELETECallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/ResponseEntity}
     */
    this.deleteUsingDELETE = function(id, callback) {
      var postBody = null;

      // verify the required parameter 'id' is set
      if (id == undefined || id == null) {
        throw "Missing the required parameter 'id' when calling deleteUsingDELETE";
      }


      var pathParams = {
        'id': id
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
      var returnType = ResponseEntity;

      return this.apiClient.callApi(
        '/v1/contas/{id}', 'DELETE',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getAllUsingGET1 operation.
     * @callback module:api/ContaApi~getAllUsingGET1Callback
     * @param {String} error Error message, if any.
     * @param {Array.<module:model/Conta>} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Retorna todas as contas
     * Retorna todas as contas
     * @param {module:api/ContaApi~getAllUsingGET1Callback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {Array.<module:model/Conta>}
     */
    this.getAllUsingGET1 = function(callback) {
      var postBody = null;


      var pathParams = {
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
      var returnType = [Conta];

      return this.apiClient.callApi(
        '/v1/contas', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getOneUsingGET1 operation.
     * @callback module:api/ContaApi~getOneUsingGET1Callback
     * @param {String} error Error message, if any.
     * @param {module:model/Conta} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Retorna uma conta
     * Retorna uma conta
     * @param {Integer} id id
     * @param {module:api/ContaApi~getOneUsingGET1Callback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Conta}
     */
    this.getOneUsingGET1 = function(id, callback) {
      var postBody = null;

      // verify the required parameter 'id' is set
      if (id == undefined || id == null) {
        throw "Missing the required parameter 'id' when calling getOneUsingGET1";
      }


      var pathParams = {
        'id': id
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
      var returnType = Conta;

      return this.apiClient.callApi(
        '/v1/contas/{id}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the updateUsingPUT1 operation.
     * @callback module:api/ContaApi~updateUsingPUT1Callback
     * @param {String} error Error message, if any.
     * @param {module:model/Conta} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Atualiza uma conta
     * Atualiza uma conta
     * @param {module:model/Conta} conta conta
     * @param {module:api/ContaApi~updateUsingPUT1Callback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/Conta}
     */
    this.updateUsingPUT1 = function(conta, callback) {
      var postBody = conta;

      // verify the required parameter 'conta' is set
      if (conta == undefined || conta == null) {
        throw "Missing the required parameter 'conta' when calling updateUsingPUT1";
      }


      var pathParams = {
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
      var returnType = Conta;

      return this.apiClient.callApi(
        '/v1/contas', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
