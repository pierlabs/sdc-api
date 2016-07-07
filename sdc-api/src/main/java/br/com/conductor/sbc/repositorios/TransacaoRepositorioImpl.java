package br.com.conductor.sbc.repositorios;

import java.math.BigDecimal;
import java.util.Date;

import org.springframework.beans.factory.annotation.Autowired;

import br.com.conductor.sbc.entidades.Cartao;
import br.com.conductor.sbc.entidades.Transacao;

public class TransacaoRepositorioImpl implements TransacaoRepositorioCustom{
     
     @Autowired
     private TransacaoRepositorio transacaoRepositorio;
     
     public Transacao transacionar(Cartao cartao, BigDecimal valor){
          
          Transacao t = new Transacao();
          t.setCartao(cartao);
          t.setDataTransacao(new Date());
          t.setValor(valor);
          return transacaoRepositorio.save(t);          
          
     }

}
