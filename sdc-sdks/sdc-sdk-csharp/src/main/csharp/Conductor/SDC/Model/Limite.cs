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
    public partial class Limite :  IEquatable<Limite>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Limite" /> class.
        /// Initializes a new instance of the <see cref="Limite" />class.
        /// </summary>
        /// <param name="Msg">Msg.</param>
        /// <param name="Valor">Valor.</param>

        public Limite(string Msg = null, double? Valor = null)
        {
            this.Msg = Msg;
            this.Valor = Valor;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Msg
        /// </summary>
        [DataMember(Name="msg", EmitDefaultValue=false)]
        public string Msg { get; set; }
    
        /// <summary>
        /// Gets or Sets Valor
        /// </summary>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Limite {\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            
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
            return this.Equals(obj as Limite);
        }

        /// <summary>
        /// Returns true if Limite instances are equal
        /// </summary>
        /// <param name="other">Instance of Limite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Limite other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Msg == other.Msg ||
                    this.Msg != null &&
                    this.Msg.Equals(other.Msg)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
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
                
                if (this.Msg != null)
                    hash = hash * 59 + this.Msg.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                return hash;
            }
        }

    }
}
