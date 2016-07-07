
package br.com.conductor.sbc.repositorios;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import br.com.conductor.sbc.entidades.Transacao;

public interface TransacaoRepositorio extends JpaRepository<Transacao, Long>, TransacaoRepositorioCustom{
     
     List<Transacao> findByCartaoId(Long idCartao);

}
