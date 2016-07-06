
package br.com.conductor.sbc.repositorios;

import org.springframework.beans.factory.annotation.Autowired;

import br.com.twsoftware.alfred.object.Objeto;

public class CartaoRepositorioImpl implements CartaoRepositorioCustom{

     @Autowired
     private CartaoRepositorio cartaoRepositorio;

     public Long limite(Long idCartao) {

          Long somaCreditos = cartaoRepositorio.somaCreditos(idCartao);
          if (Objeto.isBlank(somaCreditos)) {
               somaCreditos = 0L;
          }

          Long somaTransacoes = cartaoRepositorio.somaTransacoes(idCartao);
          if (Objeto.isBlank(somaTransacoes)) {
               somaTransacoes = 0L;
          }

          return somaCreditos - somaTransacoes;

     }

     public boolean limiteDisponivel(Long idCartao, Long valor) {

          Long limite = limite(idCartao);
          return valor > limite ? false : true;

     }

}
