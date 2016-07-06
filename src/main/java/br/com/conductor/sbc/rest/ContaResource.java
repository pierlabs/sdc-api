
package br.com.conductor.sbc.rest;

import org.springframework.beans.factory.annotation.Autowired;
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
     @ApiOperation(value = Constantes.PATH_CONTAS + "", notes = "", response = Conta.class, httpMethod = "GET", responseContainer = "List")
     @RequestMapping(value = "", method = RequestMethod.GET, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity getAll() {

          return super.getAll();
     }

     @Timed
     @ResponseBody
     @ApiOperation(value = Constantes.PATH_CONTAS + "/{id}", notes = "Retorna uma conta", response = Conta.class)
     @RequestMapping(value = "/{id}", method = RequestMethod.GET, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity getOne(@PathVariable("id") Long id) {

          return super.getOne(id);

     }

     @Timed
     @ResponseBody
     @ApiOperation(value = Constantes.PATH_CONTAS, notes = "Cria uma conta", response = Conta.class)
     @RequestMapping(value = "", method = RequestMethod.POST, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity create(@RequestBody Conta conta) {

          return super.createOrUpdate(conta);

     }

     @Timed
     @ResponseBody
     @ApiOperation(value = Constantes.PATH_CONTAS, notes = "Atualiza uma conta", response = Conta.class)
     @RequestMapping(value = "", method = RequestMethod.PUT, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity update(@RequestBody Conta conta) {

          return super.createOrUpdate(conta);

     }

     @Timed
     @ResponseBody
     @ApiOperation(value = Constantes.PATH_CONTAS + "/{id}", notes = "Deleta um cartão")
     @RequestMapping(value = "/{id}", method = RequestMethod.DELETE, produces = MediaType.APPLICATION_JSON_VALUE)
     public ResponseEntity delete(@PathVariable("id") Long id) {

          return super.delete(id);

     }

     @Override
     public ContaRepositorio getJpaRepository() {

          return contaRepositorio;

     }

}
