package br.com.conductor.sdc.api.v1.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;





@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen")
public class Cartao   {
  
  private String cvv = null;
  private Long id = null;
  private String nome = null;
  private String numero = null;
  private String senha = null;


  public enum StatusEnum {
    ATIVO("ATIVO"),
    CANCELADO("CANCELADO"),
    BLOQUEADO("BLOQUEADO");

    private String value;

    StatusEnum(String value) {
      this.value = value;
    }

    @Override
    @JsonValue
    public String toString() {
      return value;
    }
  }

  private StatusEnum status = null;

  
  /**
   **/
  public Cartao cvv(String cvv) {
    this.cvv = cvv;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("cvv")
  public String getCvv() {
    return cvv;
  }
  public void setCvv(String cvv) {
    this.cvv = cvv;
  }

  
  /**
   **/
  public Cartao id(Long id) {
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
  public Cartao nome(String nome) {
    this.nome = nome;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("nome")
  public String getNome() {
    return nome;
  }
  public void setNome(String nome) {
    this.nome = nome;
  }

  
  /**
   **/
  public Cartao numero(String numero) {
    this.numero = numero;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("numero")
  public String getNumero() {
    return numero;
  }
  public void setNumero(String numero) {
    this.numero = numero;
  }

  
  /**
   **/
  public Cartao senha(String senha) {
    this.senha = senha;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("senha")
  public String getSenha() {
    return senha;
  }
  public void setSenha(String senha) {
    this.senha = senha;
  }

  
  /**
   **/
  public Cartao status(StatusEnum status) {
    this.status = status;
    return this;
  }
  
  @ApiModelProperty(example = "null", value = "")
  @JsonProperty("status")
  public StatusEnum getStatus() {
    return status;
  }
  public void setStatus(StatusEnum status) {
    this.status = status;
  }

  

  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Cartao cartao = (Cartao) o;
    return Objects.equals(this.cvv, cartao.cvv) &&
        Objects.equals(this.id, cartao.id) &&
        Objects.equals(this.nome, cartao.nome) &&
        Objects.equals(this.numero, cartao.numero) &&
        Objects.equals(this.senha, cartao.senha) &&
        Objects.equals(this.status, cartao.status);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cvv, id, nome, numero, senha, status);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Cartao {\n");
    
    sb.append("    cvv: ").append(toIndentedString(cvv)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    nome: ").append(toIndentedString(nome)).append("\n");
    sb.append("    numero: ").append(toIndentedString(numero)).append("\n");
    sb.append("    senha: ").append(toIndentedString(senha)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
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

