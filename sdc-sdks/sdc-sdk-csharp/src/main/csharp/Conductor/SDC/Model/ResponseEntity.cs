using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conductor.SDC.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ResponseEntity :  IEquatable<ResponseEntity>
    { 
    
        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusCodeEnum {
            
            [EnumMember(Value = "100")]
            _100,
            
            [EnumMember(Value = "101")]
            _101,
            
            [EnumMember(Value = "102")]
            _102,
            
            [EnumMember(Value = "103")]
            _103,
            
            [EnumMember(Value = "200")]
            _200,
            
            [EnumMember(Value = "201")]
            _201,
            
            [EnumMember(Value = "202")]
            _202,
            
            [EnumMember(Value = "203")]
            _203,
            
            [EnumMember(Value = "204")]
            _204,
            
            [EnumMember(Value = "205")]
            _205,
            
            [EnumMember(Value = "206")]
            _206,
            
            [EnumMember(Value = "207")]
            _207,
            
            [EnumMember(Value = "208")]
            _208,
            
            [EnumMember(Value = "226")]
            _226,
            
            [EnumMember(Value = "300")]
            _300,
            
            [EnumMember(Value = "301")]
            _301,
            
            [EnumMember(Value = "302")]
            _302,
            
            [EnumMember(Value = "302")]
            _302,
            
            [EnumMember(Value = "303")]
            _303,
            
            [EnumMember(Value = "304")]
            _304,
            
            [EnumMember(Value = "305")]
            _305,
            
            [EnumMember(Value = "307")]
            _307,
            
            [EnumMember(Value = "308")]
            _308,
            
            [EnumMember(Value = "400")]
            _400,
            
            [EnumMember(Value = "401")]
            _401,
            
            [EnumMember(Value = "402")]
            _402,
            
            [EnumMember(Value = "403")]
            _403,
            
            [EnumMember(Value = "404")]
            _404,
            
            [EnumMember(Value = "405")]
            _405,
            
            [EnumMember(Value = "406")]
            _406,
            
            [EnumMember(Value = "407")]
            _407,
            
            [EnumMember(Value = "408")]
            _408,
            
            [EnumMember(Value = "409")]
            _409,
            
            [EnumMember(Value = "410")]
            _410,
            
            [EnumMember(Value = "411")]
            _411,
            
            [EnumMember(Value = "412")]
            _412,
            
            [EnumMember(Value = "413")]
            _413,
            
            [EnumMember(Value = "413")]
            _413,
            
            [EnumMember(Value = "414")]
            _414,
            
            [EnumMember(Value = "414")]
            _414,
            
            [EnumMember(Value = "415")]
            _415,
            
            [EnumMember(Value = "416")]
            _416,
            
            [EnumMember(Value = "417")]
            _417,
            
            [EnumMember(Value = "418")]
            _418,
            
            [EnumMember(Value = "419")]
            _419,
            
            [EnumMember(Value = "420")]
            _420,
            
            [EnumMember(Value = "421")]
            _421,
            
            [EnumMember(Value = "422")]
            _422,
            
            [EnumMember(Value = "423")]
            _423,
            
            [EnumMember(Value = "424")]
            _424,
            
            [EnumMember(Value = "426")]
            _426,
            
            [EnumMember(Value = "428")]
            _428,
            
            [EnumMember(Value = "429")]
            _429,
            
            [EnumMember(Value = "431")]
            _431,
            
            [EnumMember(Value = "500")]
            _500,
            
            [EnumMember(Value = "501")]
            _501,
            
            [EnumMember(Value = "502")]
            _502,
            
            [EnumMember(Value = "503")]
            _503,
            
            [EnumMember(Value = "504")]
            _504,
            
            [EnumMember(Value = "505")]
            _505,
            
            [EnumMember(Value = "506")]
            _506,
            
            [EnumMember(Value = "507")]
            _507,
            
            [EnumMember(Value = "508")]
            _508,
            
            [EnumMember(Value = "509")]
            _509,
            
            [EnumMember(Value = "510")]
            _510,
            
            [EnumMember(Value = "511")]
            _511
        }

    
        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public StatusCodeEnum? StatusCode { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEntity" /> class.
        /// Initializes a new instance of the <see cref="ResponseEntity" />class.
        /// </summary>
        /// <param name="Body">Body.</param>
        /// <param name="StatusCode">StatusCode.</param>

        public ResponseEntity(Object Body = null, StatusCodeEnum? StatusCode = null)
        {
            this.Body = Body;
            this.StatusCode = StatusCode;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public Object Body { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseEntity {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ResponseEntity);
        }

        /// <summary>
        /// Returns true if ResponseEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) && 
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                
                return hash;
            }
        }

    }
}
