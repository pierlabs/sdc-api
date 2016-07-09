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
    root.SDC.Response = factory(root.SDC.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The Response model module.
   * @module model/Response
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>Response</code>.
   * @alias module:model/Response
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>Response</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Response} obj Optional instance to populate.
   * @return {module:model/Response} The populated <code>Response</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('msg')) {
        obj['msg'] = ApiClient.convertToType(data['msg'], 'String');
      }
    }
    return obj;
  }


  /**
   * @member {String} msg
   */
  exports.prototype['msg'] = undefined;




  return exports;
}));
