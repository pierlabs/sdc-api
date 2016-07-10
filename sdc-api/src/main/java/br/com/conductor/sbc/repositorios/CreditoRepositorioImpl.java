package br.com.conductor.sbc.repositorios;

import java.math.BigDecimal;
import java.time.LocalDateTime;

import org.springframework.beans.factory.annotation.Autowired;

import br.com.conductor.sbc.entidades.Cartao;
import br.com.conductor.sbc.entidades.Credito;

public class CreditoRepositorioImpl implements CreditoRepositorioCustom{
     
     @Autowired
     private CreditoRepositorio creditoRepositorio;
     
     public Credito creditar(Cartao cartao, BigDecimal valor){
          
          Credito credito = new Credito();
          credito.setCartao(cartao);
          credito.setDataCredito(LocalDateTime.now());
          credito.setValor(valor);
          return creditoRepositorio.save(credito);          
          
     }
     
}
