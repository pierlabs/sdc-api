
package br.com.conductor.sbc.repositorios;

import java.math.BigDecimal;
import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import br.com.conductor.sbc.entidades.Cartao;

public interface CartaoRepositorio extends JpaRepository<Cartao, Long>, CartaoRepositorioCustom{

     @Query("select c from Cartao c where c.conta.id = :idConta")
     List<Cartao> findByConta(@Param("idConta") Long idConta);

     Cartao findOneByIdAndContaId(Long id, Long idConta);

     @Query("select sum(c.valor) from Credito c where c.cartao.id = :idCartao")
     BigDecimal somaCreditos(@Param("idCartao") Long idCartao);

     @Query("select sum(t.valor) from Transacao t where t.cartao.id = :idCartao")
     BigDecimal somaTransacoes(@Param("idCartao") Long idCartao);
     
     @Query("select (select sum(credito.valor) from Credito credito where credito.cartao.id = :idCartao) - (select sum(t.valor) from Transacao t where t.cartao.id = :idCartao) from Cartao c where c.id = :idCartao")
     BigDecimal limite2(@Param("idCartao") Long idCartao);
     
}
