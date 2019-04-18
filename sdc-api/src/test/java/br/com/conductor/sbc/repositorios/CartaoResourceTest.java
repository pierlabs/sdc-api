
package br.com.conductor.sbc.repositorios;

import java.math.BigDecimal;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

import com.github.thiagonego.alfred.object.Objeto;

import br.com.conductor.sbc.Aplicacao;
import br.com.conductor.sbc.entidades.Cartao;
import br.com.conductor.sbc.entidades.Cartao.StatusCartao;
import br.com.conductor.sbc.entidades.Conta;
import junit.framework.TestCase;

@RunWith(SpringRunner.class)
@SpringBootTest(classes=Aplicacao.class)
public class CartaoResourceTest{

     @Autowired
     private CartaoRepositorio cartaoRepositorio;

     @Autowired
     private ContaRepositorio contaRepositorio;

     @Autowired
     private CreditoRepositorio creditoRepositorio;

     @Autowired
     private TransacaoRepositorio transacaoRepositorio;

     @Test
     public void testlimite() {

          Conta c = new Conta();
          c.setNome("NUBANK");
          c = contaRepositorio.save(c);

          Cartao cartao = new Cartao();
          cartao.setConta(c);
          cartao.setCvv("CVV");
          cartao.setNome("NOME COMPLETO");
          cartao.setNumero("1234567890123456");
          cartao.setSenha("asdas");
          cartao.setStatus(StatusCartao.ATIVO);
          cartao = cartaoRepositorio.save(cartao);

          creditoRepositorio.creditar(cartao, new BigDecimal(100));
          
          transacaoRepositorio.transacionar(cartao, new BigDecimal(10));

          BigDecimal somaCreditos = cartaoRepositorio.somaCreditos(cartao.getId());
          TestCase.assertTrue(new BigDecimal(100.00).compareTo(somaCreditos) == 0);

          BigDecimal somaDebitos = cartaoRepositorio.somaTransacoes(cartao.getId());
          TestCase.assertTrue(new BigDecimal(10.00).compareTo(somaDebitos) == 0);

          BigDecimal limite = cartaoRepositorio.limite(cartao.getId());
          TestCase.assertTrue(new BigDecimal(90.00).compareTo(limite) == 0);

          transacaoRepositorio.transacionar(cartao, new BigDecimal(90.00));

          limite = cartaoRepositorio.limite(cartao.getId());
          TestCase.assertTrue(BigDecimal.ZERO.compareTo(limite) == 0);

          creditoRepositorio.creditar(cartao, new BigDecimal(100.00));

          transacaoRepositorio.transacionar(cartao, new BigDecimal(200.00));
          limite = cartaoRepositorio.limite(cartao.getId());
          TestCase.assertTrue(new BigDecimal(-100.00).compareTo(limite) == 0);
          
          contaRepositorio.deleteCascadeAll(c.getId());
          
          TestCase.assertTrue(Objeto.isBlank(creditoRepositorio.findByContaId(c.getId())));
          TestCase.assertTrue(Objeto.isBlank(transacaoRepositorio.findByContaId(c.getId())));
          TestCase.assertTrue(Objeto.isBlank(cartaoRepositorio.findByConta(c.getId())));
          TestCase.assertTrue(Objeto.isBlank(contaRepositorio.findById(c.getId()).orElse(null)));

     }

}