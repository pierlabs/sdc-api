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
    root.SDC.Transacao = factory(root.SDC.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The Transacao model module.
   * @module model/Transacao
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>Transacao</code>.
   * @alias module:model/Transacao
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>Transacao</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Transacao} obj Optional instance to populate.
   * @return {module:model/Transacao} The populated <code>Transacao</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('dataTransacao')) {
        obj['dataTransacao'] = ApiClient.convertToType(data['dataTransacao'], 'Date');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'Integer');
      }
      if (data.hasOwnProperty('msg')) {
        obj['msg'] = ApiClient.convertToType(data['msg'], 'String');
      }
      if (data.hasOwnProperty('valor')) {
        obj['valor'] = ApiClient.convertToType(data['valor'], 'Number');
      }
    }
    return obj;
  }


  /**
   * @member {Date} dataTransacao
   */
  exports.prototype['dataTransacao'] = undefined;

  /**
   * @member {Integer} id
   */
  exports.prototype['id'] = undefined;

  /**
   * @member {String} msg
   */
  exports.prototype['msg'] = undefined;

  /**
   * @member {Number} valor
   */
  exports.prototype['valor'] = undefined;




  return exports;
}));
