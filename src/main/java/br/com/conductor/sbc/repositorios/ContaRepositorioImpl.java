
package br.com.conductor.sbc.repositorios;

import org.springframework.beans.factory.annotation.Autowired;

public class ContaRepositorioImpl implements ContaRepositorioCustom{

     @Autowired
     private CartaoRepositorio cartaoRepositorio;

     @Autowired
     private ContaRepositorio contaRepositorio;

     @Autowired
     private CreditoRepositorio creditoRepositorio;

     @Autowired
     private TransacaoRepositorio transacaoRepositorio;

     public void deleteCascadeAll(Long idConta) {


     }

}
