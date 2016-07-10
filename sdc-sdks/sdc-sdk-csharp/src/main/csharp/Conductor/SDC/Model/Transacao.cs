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
    public partial class Transacao :  IEquatable<Transacao>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Transacao" /> class.
        /// Initializes a new instance of the <see cref="Transacao" />class.
        /// </summary>
        /// <param name="DataTransacao">DataTransacao.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Msg">Msg.</param>
        /// <param name="Valor">Valor.</param>

        public Transacao(DateTime? DataTransacao = null, long? Id = null, string Msg = null, double? Valor = null)
        {
            this.DataTransacao = DataTransacao;
            this.Id = Id;
            this.Msg = Msg;
            this.Valor = Valor;
            
        }
        
    
        /// <summary>
        /// Gets or Sets DataTransacao
        /// </summary>
        [DataMember(Name="dataTransacao", EmitDefaultValue=false)]
        public DateTime? DataTransacao { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
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
            sb.Append("class Transacao {\n");
            sb.Append("  DataTransacao: ").Append(DataTransacao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as Transacao);
        }

        /// <summary>
        /// Returns true if Transacao instances are equal
        /// </summary>
        /// <param name="other">Instance of Transacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transacao other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataTransacao == other.DataTransacao ||
                    this.DataTransacao != null &&
                    this.DataTransacao.Equals(other.DataTransacao)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
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
                
                if (this.DataTransacao != null)
                    hash = hash * 59 + this.DataTransacao.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Msg != null)
                    hash = hash * 59 + this.Msg.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                return hash;
            }
        }

    }
}
