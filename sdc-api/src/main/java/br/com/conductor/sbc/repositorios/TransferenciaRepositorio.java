package br.com.conductor.sbc.repositorios;

import org.springframework.data.jpa.repository.JpaRepository;

import br.com.conductor.sbc.entidades.Transferencia;


public interface TransferenciaRepositorio extends JpaRepository<Transferencia, Long>{

}
