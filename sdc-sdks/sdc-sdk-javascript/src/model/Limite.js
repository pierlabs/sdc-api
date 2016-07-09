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
    root.SDC.Limite = factory(root.SDC.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The Limite model module.
   * @module model/Limite
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>Limite</code>.
   * @alias module:model/Limite
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>Limite</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Limite} obj Optional instance to populate.
   * @return {module:model/Limite} The populated <code>Limite</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

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
   * @member {String} msg
   */
  exports.prototype['msg'] = undefined;

  /**
   * @member {Number} valor
   */
  exports.prototype['valor'] = undefined;




  return exports;
}));
