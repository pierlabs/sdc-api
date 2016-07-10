package br.com.conductor.sdc.api.v1.model;

import java.util.Date;


import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;



@ApiModel(description = "")
public class Extrato  {
  
  @SerializedName("data")
  private Date data = null;
  public enum TipoEnum {
     CREDITO,  DEBITO, 
  };
  @SerializedName("tipo")
  private TipoEnum tipo = null;
  @SerializedName("valor")
  private Double valor = null;

  
  /**
   **/
  @ApiModelProperty(value = "")
  public Date getData() {
    return data;
  }
  public void setData(Date data) {
    this.data = data;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  public TipoEnum getTipo() {
    return tipo;
  }
  public void setTipo(TipoEnum tipo) {
    this.tipo = tipo;
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
    sb.append("class Extrato {\n");
    
    sb.append("  data: ").append(data).append("\n");
    sb.append("  tipo: ").append(tipo).append("\n");
    sb.append("  valor: ").append(valor).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}


