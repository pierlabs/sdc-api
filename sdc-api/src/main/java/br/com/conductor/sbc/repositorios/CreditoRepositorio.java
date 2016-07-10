package br.com.conductor.sbc.repositorios;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import br.com.conductor.sbc.entidades.Credito;


public interface CreditoRepositorio extends JpaRepository<Credito, Long>, CreditoRepositorioCustom{
     
     @Query("select c from Credito c where c.cartao.conta.id = :idConta")
     List<Credito> findByContaId(@Param("idConta") Long idConta);
     
     @Query("select c from Credito c where c.cartao.id = :idCartao")
     List<Credito> findByCartaoId(@Param("idCartao") Long idCartao);
     
}
