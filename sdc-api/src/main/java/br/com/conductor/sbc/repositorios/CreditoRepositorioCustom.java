package br.com.conductor.sbc.repositorios;

import java.math.BigDecimal;

import br.com.conductor.sbc.entidades.Cartao;
import br.com.conductor.sbc.entidades.Credito;


public interface CreditoRepositorioCustom{

     Credito creditar(Cartao cartao, BigDecimal valor);
     
}
