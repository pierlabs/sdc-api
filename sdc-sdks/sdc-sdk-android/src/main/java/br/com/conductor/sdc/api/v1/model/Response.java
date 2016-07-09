package br.com.conductor.sdc.api.v1.model;


import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;


@ApiModel(description = "")
public class Response  {
  
  @SerializedName("msg")
  private String msg = null;

  
  /**
   **/
  @ApiModelProperty(value = "")
  public String getMsg() {
    return msg;
  }
  public void setMsg(String msg) {
    this.msg = msg;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Response {\n");
    
    sb.append("  msg: ").append(msg).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
