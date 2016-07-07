package br.com.conductor.sbc.repositorios;

import java.math.BigDecimal;

public interface CartaoRepositorioCustom {

     boolean limiteDisponivel(Long idCartao, BigDecimal valor);

     BigDecimal limite(Long idCartao);

}
