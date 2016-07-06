package br.com.conductor.sbc.repositorios;

public interface CartaoRepositorioCustom {

     boolean limiteDisponivel(Long idCartao, Long valor);

     Long limite(Long idCartao);

}
