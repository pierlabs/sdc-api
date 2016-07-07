(function(factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['./ApiClient', './model/Cartao', './model/Conta', './model/ResponseEntity', './api/CartaoApi', './api/ContaApi'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('./ApiClient'), require('./model/Cartao'), require('./model/Conta'), require('./model/ResponseEntity'), require('./api/CartaoApi'), require('./api/ContaApi'));
  }
}(function(ApiClient, Cartao, Conta, ResponseEntity, CartaoApi, ContaApi) {
  'use strict';

  /**
   * PIER Labs - Primeiro Hach Day SBC UFPB.<br>
   * The <code>index</code> module provides access to constructors for all the classes which comprise the public API.
   * <p>
   * An AMD (recommended!) or CommonJS application will generally do something equivalent to the following:
   * <pre>
   * var SDC = require('./index'); // See note below*.
   * var xxxSvc = new SDC.XxxApi(); // Allocate the API class we're going to use.
   * var yyyModel = new SDC.Yyy(); // Construct a model instance.
   * yyyModel.someProperty = 'someValue';
   * ...
   * var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
   * ...
   * </pre>
   * <em>*NOTE: For a top-level AMD script, use require(['./index'], function(){...}) and put the application logic within the
   * callback function.</em>
   * </p>
   * <p>
   * A non-AMD browser application (discouraged) might do something like this:
   * <pre>
   * var xxxSvc = new SDC.XxxApi(); // Allocate the API class we're going to use.
   * var yyy = new SDC.Yyy(); // Construct a model instance.
   * yyyModel.someProperty = 'someValue';
   * ...
   * var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
   * ...
   * </pre>
   * </p>
   * @module index
   * @version 1.0.0
   */
  var exports = {
    /**
     * The ApiClient constructor.
     * @property {module:ApiClient}
     */
    ApiClient: ApiClient,
    /**
     * The Cartao model constructor.
     * @property {module:model/Cartao}
     */
    Cartao: Cartao,
    /**
     * The Conta model constructor.
     * @property {module:model/Conta}
     */
    Conta: Conta,
    /**
     * The ResponseEntity model constructor.
     * @property {module:model/ResponseEntity}
     */
    ResponseEntity: ResponseEntity,
    /**
     * The CartaoApi service constructor.
     * @property {module:api/CartaoApi}
     */
    CartaoApi: CartaoApi,
    /**
     * The ContaApi service constructor.
     * @property {module:api/ContaApi}
     */
    ContaApi: ContaApi
  };

  return exports;
}));
