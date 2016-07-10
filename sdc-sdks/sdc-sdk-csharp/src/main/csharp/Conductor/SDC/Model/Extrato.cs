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
    public partial class Extrato :  IEquatable<Extrato>
    { 
    
        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoEnum {
            
            [EnumMember(Value = "CREDITO")]
            Credito,
            
            [EnumMember(Value = "DEBITO")]
            Debito
        }

    
        /// <summary>
        /// Gets or Sets Tipo
        /// </summary>
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public TipoEnum? Tipo { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Extrato" /> class.
        /// Initializes a new instance of the <see cref="Extrato" />class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Tipo">Tipo.</param>
        /// <param name="Valor">Valor.</param>

        public Extrato(DateTime? Data = null, TipoEnum? Tipo = null, double? Valor = null)
        {
            this.Data = Data;
            this.Tipo = Tipo;
            this.Valor = Valor;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public DateTime? Data { get; set; }
    
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
            sb.Append("class Extrato {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
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
            return this.Equals(obj as Extrato);
        }

        /// <summary>
        /// Returns true if Extrato instances are equal
        /// </summary>
        /// <param name="other">Instance of Extrato to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Extrato other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.Tipo == other.Tipo ||
                    this.Tipo != null &&
                    this.Tipo.Equals(other.Tipo)
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
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                if (this.Tipo != null)
                    hash = hash * 59 + this.Tipo.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                return hash;
            }
        }

    }
}
