
package br.com.conductor.sbc.repositorios;

import java.math.BigDecimal;

import br.com.conductor.sbc.entidades.Cartao;
import br.com.conductor.sbc.entidades.Transacao;

public interface TransacaoRepositorioCustom{

     Transacao transacionar(Cartao cartao, BigDecimal valor);
     
}
