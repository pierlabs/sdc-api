package br.com.conductor.sbc.repositorios;

import org.springframework.data.jpa.repository.JpaRepository;

import br.com.conductor.sbc.entidades.Conta;


public interface ContaRepositorio extends JpaRepository<Conta, Long>{

}
