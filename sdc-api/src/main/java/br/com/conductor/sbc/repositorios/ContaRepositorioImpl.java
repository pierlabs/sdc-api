
package br.com.conductor.sbc.repositorios;

import org.springframework.beans.factory.annotation.Autowired;

import br.com.conductor.sbc.util.Transacional;

public class ContaRepositorioImpl implements ContaRepositorioCustom{

     @Autowired
     private CartaoRepositorio cartaoRepositorio;

     @Autowired
     private ContaRepositorio contaRepositorio;

     @Autowired
     private CreditoRepositorio creditoRepositorio;

     @Autowired
     private TransacaoRepositorio transacaoRepositorio;

     @Transacional
     public void deleteCascadeAll(Long idConta) {
          
          creditoRepositorio.findByContaId(idConta).stream().forEach(c -> creditoRepositorio.delete(c));
          transacaoRepositorio.findByContaId(idConta).stream().forEach(t -> transacaoRepositorio.delete(t));
          cartaoRepositorio.findByConta(idConta).stream().forEach(c -> cartaoRepositorio.delete(c));
          contaRepositorio.deleteById(idConta);
          

     }

}
