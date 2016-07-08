
package br.com.conductor.sbc.rest;

import static br.com.conductor.sbc.util.Constantes.json;

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

import br.com.conductor.sbc.entidades.Conta;
import br.com.conductor.sbc.repositorios.ContaRepositorio;
import br.com.conductor.sbc.util.Constantes;
import br.com.conductor.sbc.util.Response;
import br.com.twsoftware.alfred.object.Objeto;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;

@RestController
@Api(value = Constantes.PATH_CONTAS, produces = MediaType.APPLICATION_JSON_VALUE, description = "Operaçoes com Contas", tags = { "Conta" })
@RequestMapping(value = Constantes.API_PATH + Constantes.PATH_CONTAS, produces = MediaType.APPLICATION_JSON_VALUE)
@SuppressWarnings("rawtypes")
public class ContaResource extends GenericResource{

     @Autowired
     private ContaRepositorio contaRepositorio;

     @Timed
     @ResponseBody
     @ApiOperation(value = "Retorna todas as contas", notes = "Retorna todas as contas", response = Conta.class, httpMethod = "GET", responseContainer = "List")
     @RequestMapping(value = "", method = RequestMethod.GET, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity getAll() {

          return super.getAll();
     }

     @Timed
     @ResponseBody
     @ApiOperation(value = "Retorna uma conta", notes = "Retorna uma conta", response = Conta.class)
     @RequestMapping(value = "/{id}", method = RequestMethod.GET, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity getOne(@PathVariable("id") Long id) {

          return super.getOne(id);

     }

     @Timed
     @ResponseBody
     @ApiOperation(value = "Cria uma conta", notes = "Cria uma conta", response = Conta.class)
     @RequestMapping(value = "", method = RequestMethod.POST, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity create(@RequestBody Conta conta) {

          return super.create(conta);

     }

     @Timed
     @ResponseBody
     @ApiOperation(value = "Atualiza uma conta", notes = "Atualiza uma conta", response = Conta.class)
     @RequestMapping(value = "", method = RequestMethod.PUT, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity update(@RequestBody Conta conta) {
          
          return super.update(conta);

     }

     @Timed
     @ResponseBody
     @ApiOperation(value = "Deleta uma conta", notes = "Deleta um cartão", response = Response.class)
     @RequestMapping(value = "/{id}", method = RequestMethod.DELETE, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity delete(@PathVariable("id") Long id) {

          ResponseEntity response = null;
          try {

               if (Objeto.isBlank(id)) {

                    response = ResponseEntity.status(HttpStatus.BAD_REQUEST).build();

               } else {
                    
                    Object tmp_ = getJpaRepository().findOne(id);
                    if(Objeto.isBlank(tmp_)){
                         response = ResponseEntity.status(HttpStatus.NOT_FOUND).body(json("Conta não encontrada"));
                    }
                         
                    contaRepositorio.deleteCascadeAll(id);
                    response = ResponseEntity.ok().build();
                    
               }

          } catch (Exception e) {
               response = ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).build();
          }

          return response;

     }

     @Override
     public ContaRepositorio getJpaRepository() {

          return contaRepositorio;

     }

}
