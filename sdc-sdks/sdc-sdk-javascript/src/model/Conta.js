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
    root.SDC.Conta = factory(root.SDC.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The Conta model module.
   * @module model/Conta
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>Conta</code>.
   * @alias module:model/Conta
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>Conta</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Conta} obj Optional instance to populate.
   * @return {module:model/Conta} The populated <code>Conta</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'Integer');
      }
      if (data.hasOwnProperty('nome')) {
        obj['nome'] = ApiClient.convertToType(data['nome'], 'String');
      }
    }
    return obj;
  }


  /**
   * @member {Integer} id
   */
  exports.prototype['id'] = undefined;

  /**
   * @member {String} nome
   */
  exports.prototype['nome'] = undefined;




  return exports;
}));
