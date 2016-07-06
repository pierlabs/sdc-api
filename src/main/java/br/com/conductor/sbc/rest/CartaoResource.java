
package br.com.conductor.sbc.rest;

import static br.com.conductor.sbc.util.Constantes.json;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import com.codahale.metrics.annotation.Timed;

import br.com.conductor.sbc.entidades.Cartao;
import br.com.conductor.sbc.entidades.Cartao.StatusCartao;
import br.com.conductor.sbc.entidades.Conta;
import br.com.conductor.sbc.repositorios.CartaoRepositorio;
import br.com.conductor.sbc.repositorios.ContaRepositorio;
import br.com.conductor.sbc.util.Constantes;
import br.com.conductor.sbc.util.CreditCardNumberGenerator;
import br.com.twsoftware.alfred.object.Objeto;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import io.swagger.annotations.ApiParam;

@RestController
@Api(value = Constantes.PATH_CARTOES, produces = MediaType.APPLICATION_JSON_VALUE, description = "Operaçoes com Cartões", tags = { "Cartao" })
@RequestMapping(value = Constantes.API_PATH + Constantes.PATH_CARTOES, produces = MediaType.APPLICATION_JSON_VALUE)
@SuppressWarnings("rawtypes")
public class CartaoResource extends GenericResource{

     @Autowired
     private CartaoRepositorio cartaoRepositorio;

     @Autowired
     private ContaRepositorio contaRepositorio;
     
     @Timed
     @ResponseBody
     @ApiOperation(value = Constantes.PATH_CARTOES, notes = "Retorna todos os cartões", response = Cartao.class, httpMethod = "GET", responseContainer = "List")
     @RequestMapping(value = "", method = RequestMethod.GET, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity getAll(@ApiParam(value = "ID da Conta", required = true) @PathVariable("idConta") Long idConta) {
          
          List<Cartao> findAll = cartaoRepositorio.findByConta(idConta);
          if (Objeto.notBlank(findAll)) {
               return ResponseEntity.ok(findAll);
          }

          return ResponseEntity.notFound().build();
          
     }

     @Timed
     @ResponseBody
     @ApiOperation(value = Constantes.PATH_CARTOES + "/{id}", notes = "Retorna um cartão", response = Cartao.class)
     @RequestMapping(value = "/{id}", method = RequestMethod.GET, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity getOne(
               @ApiParam(value = "ID da Conta", required = true) @PathVariable("idConta") Long idConta,
               @ApiParam(value = "ID do Cartão", required = true) @PathVariable("id") Long id) {

          Cartao cartao = cartaoRepositorio.findOneByIdAndContaId(id, idConta);
          if (Objeto.notBlank(cartao)) {
               return ResponseEntity.ok(cartao);
          } else {
               return ResponseEntity.notFound().build();
          }

     }

     @Timed
     @ResponseBody
     @ApiOperation(value = Constantes.PATH_CARTOES, notes = "Cria um cartão", response = Cartao.class)
     @RequestMapping(value = "", method = RequestMethod.POST, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity create(
               @ApiParam(value = "ID da Conta", required = true) @PathVariable("idConta") Long idConta,
               @ApiParam(value = "Cartão a ser criado", required = true) @RequestBody Cartao cartao) {

          Conta conta = contaRepositorio.findOne(idConta);
          if (Objeto.isBlank(conta)) {
               return ResponseEntity.status(HttpStatus.NOT_FOUND).body(json("Conta não encontrada"));
          }
          
          cartao.setConta(conta);
          
          CreditCardNumberGenerator c = new CreditCardNumberGenerator();
          cartao.setNumero(c.generate("9999", 16));
          
          if (Objeto.isBlank(cartao.getId())) {
               cartao.setStatus(StatusCartao.ATIVO);
          }

          return super.create(cartao);

     }

     @Timed
     @ResponseBody
     @ApiOperation(value = Constantes.PATH_CARTOES, notes = "Atualiza um cartão", response = Cartao.class)
     @RequestMapping(value = "", method = RequestMethod.PUT, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity update(
               @ApiParam(value = "ID da Conta", required = true) @PathVariable("idConta") Long idConta,
               @ApiParam(value = "Cartão a ser atualizado", required = true) @RequestBody Cartao cartao) {

          Conta conta = contaRepositorio.findOne(idConta);
          if (Objeto.isBlank(conta)) {
               return ResponseEntity.status(HttpStatus.NOT_FOUND).body(json("Conta não encontrada"));
          }
          
          Cartao cartao_ = cartaoRepositorio.findOneByIdAndContaId(cartao.getId(), idConta);
          if(Objeto.isBlank(cartao_)){
               return ResponseEntity.status(HttpStatus.NOT_FOUND).body(json("Cartão não encontrado ou não pertence a conta informada"));
          }
          
          cartao.setConta(conta);
          
          if (Objeto.isBlank(cartao.getId())) {
               cartao.setStatus(StatusCartao.ATIVO);
          }

          return super.update(cartao);

     }

     @Timed
     @ResponseBody
     @ApiOperation(value = Constantes.PATH_CARTOES + "/{id}/cancelar", notes = "Cancelar um cartão")
     @RequestMapping(value = "/{id}/cancelar", method = RequestMethod.DELETE, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity cancelar(
               @ApiParam(value = "ID da Conta", required = true) @PathVariable("idConta") Long idConta,
               @ApiParam(value = "Cartão a ser cancelado", required = true) @PathVariable("id") Long id) {
          
          return atualizarStatus(idConta, id, StatusCartao.CANCELADO, "Cartão cancelado com sucesso");

     }

     @Timed
     @ResponseBody
     @ApiOperation(value = Constantes.PATH_CARTOES + "/{id}/bloquear", notes = "Bloquear um cartão.")
     @RequestMapping(value = "/{id}/bloquear", method = RequestMethod.PUT, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity bloquear(
               @ApiParam(value = "ID da Conta", required = true) @PathVariable("idConta") Long idConta,
               @ApiParam(value = "Cartão a ser bloqueado", required = true) @PathVariable("id") Long id) {
          
          
          return atualizarStatus(idConta, id, StatusCartao.BLOQUEADO, "Cartão bloqueado com sucesso");
          
     }
     
     @Timed
     @ResponseBody
     @ApiOperation(value = Constantes.PATH_CARTOES + "/{id}/desbloquear", notes = "Desbloquear um cartão.")
     @RequestMapping(value = "/{id}/desbloquear", method = RequestMethod.PUT, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity desbloquear(
               @ApiParam(value = "ID da Conta", required = true) @PathVariable("idConta") Long idConta,
               @ApiParam(value = "Cartão a ser desbloqueado", required = true) @PathVariable("id") Long id) {
          
          return atualizarStatus(idConta, id, StatusCartao.ATIVO, "Cartão desbloqueado com sucesso");
          
     }

     @Override
     public CartaoRepositorio getJpaRepository() {

          return cartaoRepositorio;

     }

     private ResponseEntity atualizarStatus(Long idConta, Long id, StatusCartao status, String msg) {

          ResponseEntity response = null;
          try {
               
               if (Objeto.isBlank(idConta) || Objeto.isBlank(id)) {
                    return ResponseEntity.status(HttpStatus.BAD_REQUEST).build();
               }

               Cartao cartao = cartaoRepositorio.findOneByIdAndContaId(id, idConta);
               if (Objeto.notBlank(cartao)) {

                    cartao.setStatus(status);
                    cartaoRepositorio.save(cartao);
                    response = ResponseEntity.ok().body(json(msg));

               } else {

                    response = ResponseEntity.status(HttpStatus.NOT_FOUND).body(json("Cartão não encontrado"));

               }

          } catch (Exception e) {
               response = ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).build();
          }

          return response;
     }     
}
