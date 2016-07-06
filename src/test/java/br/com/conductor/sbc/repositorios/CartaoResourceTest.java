
package br.com.conductor.sbc.repositorios;

import java.math.BigDecimal;
import java.util.List;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.boot.test.IntegrationTest;
import org.springframework.boot.test.SpringApplicationConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.test.context.web.WebAppConfiguration;

import br.com.conductor.sbc.Aplicacao;
import br.com.conductor.sbc.entidades.Cartao;
import br.com.conductor.sbc.entidades.Cartao.StatusCartao;
import junit.framework.TestCase;
import br.com.conductor.sbc.entidades.Conta;
import br.com.conductor.sbc.entidades.Credito;
import br.com.conductor.sbc.entidades.Transacao;

@RunWith(SpringJUnit4ClassRunner.class)
@SpringApplicationConfiguration(Aplicacao.class)
@WebAppConfiguration
@IntegrationTest
@EnableAutoConfiguration
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

          Credito credito = new Credito();
          credito.setCartao(cartao);
          credito.setValor(100L);
          credito = creditoRepositorio.save(credito);

          Transacao t = new Transacao();
          t.setCartao(cartao);
          t.setValor(10L);
          t = transacaoRepositorio.save(t);

          Long somaCreditos = cartaoRepositorio.somaCreditos(cartao.getId());
          TestCase.assertTrue(100L == somaCreditos);

          Long somaDebitos = cartaoRepositorio.somaTransacoes(cartao.getId());
          TestCase.assertTrue(10L == somaDebitos);

          Long limite = cartaoRepositorio.limite(cartao.getId());
          TestCase.assertTrue(90L == limite);

          t = new Transacao();
          t.setCartao(cartao);
          t.setValor(90L);
          t = transacaoRepositorio.save(t);

          limite = cartaoRepositorio.limite(cartao.getId());
          TestCase.assertTrue(0L == limite);

          credito = new Credito();
          credito.setCartao(cartao);
          credito.setValor(100L);
          credito = creditoRepositorio.save(credito);

          t = new Transacao();
          t.setCartao(cartao);
          t.setValor(200L);
          t = transacaoRepositorio.save(t);

          limite = cartaoRepositorio.limite(cartao.getId());
          TestCase.assertTrue(-100L == limite );
          
          contaRepositorio.deleteCascadeAll(c.getId());

     }

}