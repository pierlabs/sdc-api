
package br.com.conductor.sbc.repositorios;

import java.math.BigDecimal;

import org.springframework.beans.factory.annotation.Autowired;

import br.com.twsoftware.alfred.object.Objeto;

public class CartaoRepositorioImpl implements CartaoRepositorioCustom{

     @Autowired
     private CartaoRepositorio cartaoRepositorio;
     
     public BigDecimal limite(Long idCartao) {

          BigDecimal somaCreditos = cartaoRepositorio.somaCreditos(idCartao);
          if (Objeto.isBlank(somaCreditos)) {
               somaCreditos = BigDecimal.ZERO;
          }

          BigDecimal somaTransacoes = cartaoRepositorio.somaTransacoes(idCartao);
          if (Objeto.isBlank(somaTransacoes)) {
               somaTransacoes = BigDecimal.ZERO;
          }

          return somaCreditos.subtract(somaTransacoes);

     }

     public boolean limiteDisponivel(Long idCartao, BigDecimal valor) {

          BigDecimal limite = limite(idCartao);
          return valor.compareTo(limite) > 0 ? false : true;

     }
     
}
