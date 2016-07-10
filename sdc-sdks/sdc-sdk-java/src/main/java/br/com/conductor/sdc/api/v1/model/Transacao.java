package br.com.conductor.sdc.api.v1.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.Date;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen")
public class Transacao   {
  
  private Date dataTransacao = null;
  private Long id = null;
  private String msg = null;
  private Double valor = null;

  
  /**
   **/
  public Transacao dataTransacao(Date dataTransacao) {
    this.dataTransacao = dataTransacao;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("dataTransacao")
  public Date getDataTransacao() {
    return dataTransacao;
  }
  public void setDataTransacao(Date dataTransacao) {
    this.dataTransacao = dataTransacao;
  }

  
  /**
   **/
  public Transacao id(Long id) {
    this.id = id;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("id")
  public Long getId() {
    return id;
  }
  public void setId(Long id) {
    this.id = id;
  }

  
  /**
   **/
  public Transacao msg(String msg) {
    this.msg = msg;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("msg")
  public String getMsg() {
    return msg;
  }
  public void setMsg(String msg) {
    this.msg = msg;
  }

  
  /**
   **/
  public Transacao valor(Double valor) {
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
    Transacao transacao = (Transacao) o;
    return Objects.equals(this.dataTransacao, transacao.dataTransacao) &&
        Objects.equals(this.id, transacao.id) &&
        Objects.equals(this.msg, transacao.msg) &&
        Objects.equals(this.valor, transacao.valor);
  }

  @Override
  public int hashCode() {
    return Objects.hash(dataTransacao, id, msg, valor);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Transacao {\n");
    
    sb.append("    dataTransacao: ").append(toIndentedString(dataTransacao)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    msg: ").append(toIndentedString(msg)).append("\n");
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

