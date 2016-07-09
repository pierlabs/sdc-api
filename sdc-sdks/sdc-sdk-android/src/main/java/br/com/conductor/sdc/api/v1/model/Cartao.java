package br.com.conductor.sdc.api.v1.model;


import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;


@ApiModel(description = "")
public class Cartao  {
  
  @SerializedName("cvv")
  private String cvv = null;
  @SerializedName("id")
  private Long id = null;
  @SerializedName("nome")
  private String nome = null;
  @SerializedName("numero")
  private String numero = null;
  @SerializedName("senha")
  private String senha = null;
  public enum StatusEnum {
     ATIVO,  CANCELADO,  BLOQUEADO, 
  };
  @SerializedName("status")
  private StatusEnum status = null;

  
  /**
   **/
  @ApiModelProperty(value = "")
  public String getCvv() {
    return cvv;
  }
  public void setCvv(String cvv) {
    this.cvv = cvv;
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
  public String getNome() {
    return nome;
  }
  public void setNome(String nome) {
    this.nome = nome;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  public String getNumero() {
    return numero;
  }
  public void setNumero(String numero) {
    this.numero = numero;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  public String getSenha() {
    return senha;
  }
  public void setSenha(String senha) {
    this.senha = senha;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  public StatusEnum getStatus() {
    return status;
  }
  public void setStatus(StatusEnum status) {
    this.status = status;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Cartao {\n");
    
    sb.append("  cvv: ").append(cvv).append("\n");
    sb.append("  id: ").append(id).append("\n");
    sb.append("  nome: ").append(nome).append("\n");
    sb.append("  numero: ").append(numero).append("\n");
    sb.append("  senha: ").append(senha).append("\n");
    sb.append("  status: ").append(status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
