
package br.com.conductor.sbc.util.dto;

import java.math.BigDecimal;
import java.time.LocalDateTime;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class Extrato extends Response{

     public enum TipoTransacao {
          CREDITO, DEBITO;
     }
     
     private BigDecimal valor;

     private LocalDateTime data;
     
     private TipoTransacao tipo;

}
