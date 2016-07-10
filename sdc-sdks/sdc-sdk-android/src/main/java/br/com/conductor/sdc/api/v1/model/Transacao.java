package br.com.conductor.sdc.api.v1.model;

import java.util.Date;

import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;


@ApiModel(description = "")
public class Transacao  {
  
  @SerializedName("dataTransacao")
  private Date dataTransacao = null;
  @SerializedName("id")
  private Long id = null;
  @SerializedName("msg")
  private String msg = null;
  @SerializedName("valor")
  private Double valor = null;

  
  /**
   **/
  @ApiModelProperty(value = "")
  public Date getDataTransacao() {
    return dataTransacao;
  }
  public void setDataTransacao(Date dataTransacao) {
    this.dataTransacao = dataTransacao;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  public Long getId() {
    return id;
  }
  public void setId(Long id) {
    this.id = id;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  public String getMsg() {
    return msg;
  }
  public void setMsg(String msg) {
    this.msg = msg;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  public Double getValor() {
    return valor;
  }
  public void setValor(Double valor) {
    this.valor = valor;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Transacao {\n");
    
    sb.append("  dataTransacao: ").append(dataTransacao).append("\n");
    sb.append("  id: ").append(id).append("\n");
    sb.append("  msg: ").append(msg).append("\n");
    sb.append("  valor: ").append(valor).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
