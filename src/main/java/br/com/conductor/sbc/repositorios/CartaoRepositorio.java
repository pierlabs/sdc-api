package br.com.conductor.sbc.repositorios;

import org.springframework.data.jpa.repository.JpaRepository;

import br.com.conductor.sbc.entidades.Cartao;


public interface CartaoRepositorio extends JpaRepository<Cartao, Long>{

}
