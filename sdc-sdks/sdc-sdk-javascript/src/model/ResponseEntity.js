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
    root.SDC.ResponseEntity = factory(root.SDC.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ResponseEntity model module.
   * @module model/ResponseEntity
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>ResponseEntity</code>.
   * @alias module:model/ResponseEntity
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>ResponseEntity</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ResponseEntity} obj Optional instance to populate.
   * @return {module:model/ResponseEntity} The populated <code>ResponseEntity</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('body')) {
        obj['body'] = ApiClient.convertToType(data['body'], Object);
      }
      if (data.hasOwnProperty('statusCode')) {
        obj['statusCode'] = ApiClient.convertToType(data['statusCode'], 'String');
      }
    }
    return obj;
  }


  /**
   * @member {Object} body
   */
  exports.prototype['body'] = undefined;

  /**
   * @member {module:model/ResponseEntity.StatusCodeEnum} statusCode
   */
  exports.prototype['statusCode'] = undefined;


  /**
   * Allowed values for the <code>statusCode</code> property.
   * @enum {String}
   * @readonly
   */
  exports.StatusCodeEnum = { 
    /**
     * value: 100
     * @const
     */
    _100: "100",
    
    /**
     * value: 101
     * @const
     */
    _101: "101",
    
    /**
     * value: 102
     * @const
     */
    _102: "102",
    
    /**
     * value: 103
     * @const
     */
    _103: "103",
    
    /**
     * value: 200
     * @const
     */
    _200: "200",
    
    /**
     * value: 201
     * @const
     */
    _201: "201",
    
    /**
     * value: 202
     * @const
     */
    _202: "202",
    
    /**
     * value: 203
     * @const
     */
    _203: "203",
    
    /**
     * value: 204
     * @const
     */
    _204: "204",
    
    /**
     * value: 205
     * @const
     */
    _205: "205",
    
    /**
     * value: 206
     * @const
     */
    _206: "206",
    
    /**
     * value: 207
     * @const
     */
    _207: "207",
    
    /**
     * value: 208
     * @const
     */
    _208: "208",
    
    /**
     * value: 226
     * @const
     */
    _226: "226",
    
    /**
     * value: 300
     * @const
     */
    _300: "300",
    
    /**
     * value: 301
     * @const
     */
    _301: "301",
    
    /**
     * value: 302
     * @const
     */
    _302: "302",
    
    /**
     * value: 302
     * @const
     */
    _302: "302",
    
    /**
     * value: 303
     * @const
     */
    _303: "303",
    
    /**
     * value: 304
     * @const
     */
    _304: "304",
    
    /**
     * value: 305
     * @const
     */
    _305: "305",
    
    /**
     * value: 307
     * @const
     */
    _307: "307",
    
    /**
     * value: 308
     * @const
     */
    _308: "308",
    
    /**
     * value: 400
     * @const
     */
    _400: "400",
    
    /**
     * value: 401
     * @const
     */
    _401: "401",
    
    /**
     * value: 402
     * @const
     */
    _402: "402",
    
    /**
     * value: 403
     * @const
     */
    _403: "403",
    
    /**
     * value: 404
     * @const
     */
    _404: "404",
    
    /**
     * value: 405
     * @const
     */
    _405: "405",
    
    /**
     * value: 406
     * @const
     */
    _406: "406",
    
    /**
     * value: 407
     * @const
     */
    _407: "407",
    
    /**
     * value: 408
     * @const
     */
    _408: "408",
    
    /**
     * value: 409
     * @const
     */
    _409: "409",
    
    /**
     * value: 410
     * @const
     */
    _410: "410",
    
    /**
     * value: 411
     * @const
     */
    _411: "411",
    
    /**
     * value: 412
     * @const
     */
    _412: "412",
    
    /**
     * value: 413
     * @const
     */
    _413: "413",
    
    /**
     * value: 413
     * @const
     */
    _413: "413",
    
    /**
     * value: 414
     * @const
     */
    _414: "414",
    
    /**
     * value: 414
     * @const
     */
    _414: "414",
    
    /**
     * value: 415
     * @const
     */
    _415: "415",
    
    /**
     * value: 416
     * @const
     */
    _416: "416",
    
    /**
     * value: 417
     * @const
     */
    _417: "417",
    
    /**
     * value: 418
     * @const
     */
    _418: "418",
    
    /**
     * value: 419
     * @const
     */
    _419: "419",
    
    /**
     * value: 420
     * @const
     */
    _420: "420",
    
    /**
     * value: 421
     * @const
     */
    _421: "421",
    
    /**
     * value: 422
     * @const
     */
    _422: "422",
    
    /**
     * value: 423
     * @const
     */
    _423: "423",
    
    /**
     * value: 424
     * @const
     */
    _424: "424",
    
    /**
     * value: 426
     * @const
     */
    _426: "426",
    
    /**
     * value: 428
     * @const
     */
    _428: "428",
    
    /**
     * value: 429
     * @const
     */
    _429: "429",
    
    /**
     * value: 431
     * @const
     */
    _431: "431",
    
    /**
     * value: 500
     * @const
     */
    _500: "500",
    
    /**
     * value: 501
     * @const
     */
    _501: "501",
    
    /**
     * value: 502
     * @const
     */
    _502: "502",
    
    /**
     * value: 503
     * @const
     */
    _503: "503",
    
    /**
     * value: 504
     * @const
     */
    _504: "504",
    
    /**
     * value: 505
     * @const
     */
    _505: "505",
    
    /**
     * value: 506
     * @const
     */
    _506: "506",
    
    /**
     * value: 507
     * @const
     */
    _507: "507",
    
    /**
     * value: 508
     * @const
     */
    _508: "508",
    
    /**
     * value: 509
     * @const
     */
    _509: "509",
    
    /**
     * value: 510
     * @const
     */
    _510: "510",
    
    /**
     * value: 511
     * @const
     */
    _511: "511"
  };

  return exports;
}));
