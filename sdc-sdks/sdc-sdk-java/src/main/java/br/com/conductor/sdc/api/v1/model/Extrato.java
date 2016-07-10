package br.com.conductor.sdc.api.v1.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.Date;







@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen")
public class Extrato   {
  
  private Date data = null;


  public enum TipoEnum {
    CREDITO("CREDITO"),
    DEBITO("DEBITO");

    private String value;

    TipoEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private TipoEnum tipo = null;
  private Double valor = null;

  
  /**
   **/
  public Extrato data(Date data) {
    this.data = data;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("data")
  public Date getData() {
    return data;
  }
  public void setData(Date data) {
    this.data = data;
  }

  
  /**
   **/
  public Extrato tipo(TipoEnum tipo) {
    this.tipo = tipo;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("tipo")
  public TipoEnum getTipo() {
    return tipo;
  }
  public void setTipo(TipoEnum tipo) {
    this.tipo = tipo;
  }

  
  /**
   **/
  public Extrato valor(Double valor) {
    this.valor = valor;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("valor")
  public Double getValor() {
    return valor;
  }
  public void setValor(Double valor) {
    this.valor = valor;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Extrato extrato = (Extrato) o;
    return Objects.equals(this.data, extrato.data) &&
        Objects.equals(this.tipo, extrato.tipo) &&
        Objects.equals(this.valor, extrato.valor);
  }

  @Override
  public int hashCode() {
    return Objects.hash(data, tipo, valor);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Extrato {\n");
    
    sb.append("    data: ").append(toIndentedString(data)).append("\n");
    sb.append("    tipo: ").append(toIndentedString(tipo)).append("\n");
    sb.append("    valor: ").append(toIndentedString(valor)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}



