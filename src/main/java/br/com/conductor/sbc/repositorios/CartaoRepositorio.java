package br.com.conductor.sbc.repositorios;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import br.com.conductor.sbc.entidades.Cartao;


public interface CartaoRepositorio extends JpaRepository<Cartao, Long>{
     
     @Query("select c from Cartao c where c.conta.id = :idConta")
     List<Cartao> findByConta(@Param("idConta") Long idConta);
     
     Cartao findOneByIdAndContaId(Long id, Long idConta);

}
