(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.SDC) {
      root.SDC = {};
    }
    root.SDC.Extrato = factory(root.SDC.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The Extrato model module.
   * @module model/Extrato
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>Extrato</code>.
   * @alias module:model/Extrato
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>Extrato</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Extrato} obj Optional instance to populate.
   * @return {module:model/Extrato} The populated <code>Extrato</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('data')) {
        obj['data'] = ApiClient.convertToType(data['data'], 'Date');
      }
      if (data.hasOwnProperty('tipo')) {
        obj['tipo'] = ApiClient.convertToType(data['tipo'], 'String');
      }
      if (data.hasOwnProperty('valor')) {
        obj['valor'] = ApiClient.convertToType(data['valor'], 'Number');
      }
    }
    return obj;
  }


  /**
   * @member {Date} data
   */
  exports.prototype['data'] = undefined;

  /**
   * @member {module:model/Extrato.TipoEnum} tipo
   */
  exports.prototype['tipo'] = undefined;

  /**
   * @member {Number} valor
   */
  exports.prototype['valor'] = undefined;


  /**
   * Allowed values for the <code>tipo</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TipoEnum = { 
    /**
     * value: CREDITO
     * @const
     */
    CREDITO: "CREDITO",
    
    /**
     * value: DEBITO
     * @const
     */
    DEBITO: "DEBITO"
  };

  return exports;
}));
