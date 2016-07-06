package br.com.conductor.sbc.repositorios;

import org.springframework.data.jpa.repository.JpaRepository;

import br.com.conductor.sbc.entidades.Credito;


public interface CreditoRepositorio extends JpaRepository<Credito, Long>{

}
