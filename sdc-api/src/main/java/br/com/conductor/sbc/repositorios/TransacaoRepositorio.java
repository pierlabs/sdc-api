
package br.com.conductor.sbc.repositorios;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import br.com.conductor.sbc.entidades.Transacao;

public interface TransacaoRepositorio extends JpaRepository<Transacao, Long>, TransacaoRepositorioCustom{
     
     List<Transacao> findByCartaoId(Long idCartao);
     
     @Query("select t from Transacao t where t.cartao.conta.id = :idConta")
     List<Transacao> findByContaId(@Param("idConta") Long idConta);

}
