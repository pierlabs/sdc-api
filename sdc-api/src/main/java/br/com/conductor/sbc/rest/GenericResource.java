
package br.com.conductor.sbc.rest;

import static br.com.conductor.sbc.util.Constantes.json;

import java.beans.IntrospectionException;
import java.lang.reflect.Field;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.transaction.annotation.Transactional;

import com.github.thiagonego.alfred.object.Objeto;
import com.github.thiagonego.alfred.reflexao.Reflexao;

import br.com.conductor.sbc.entidades.Cartao;
import br.com.conductor.sbc.entidades.Conta;
import br.com.conductor.sbc.entidades.GenericEntity;
import lombok.extern.slf4j.Slf4j;

@Slf4j
@SuppressWarnings("all")
public abstract class GenericResource{

     public abstract JpaRepository getJpaRepository();

     @Transactional
     public ResponseEntity getAll() {

          List<Cartao> findAll = getJpaRepository().findAll();
          if (Objeto.notBlank(findAll)) {
               return ResponseEntity.ok(findAll);
          }

          return ResponseEntity.notFound().build();

     }

     public ResponseEntity getOne(Long id) {

          if (Objeto.isBlank(id)) {
               return ResponseEntity.status(HttpStatus.BAD_REQUEST).build();
          }

          Object result = getJpaRepository().findById(id).orElse(null);
          if (Objeto.notBlank(result)) {
               return ResponseEntity.ok(result);
          } else {
               return ResponseEntity.notFound().build();
          }

     }

     public ResponseEntity create(GenericEntity entitty) {

          ResponseEntity response = null;
          try {

               if (Objeto.isBlank(entitty)) {

                    response = ResponseEntity.status(HttpStatus.BAD_REQUEST).build();

               } else {
                    
                    Object entity_ = getJpaRepository().save(entitty);
                    response = ResponseEntity.ok(entity_);

               }

          } catch (Exception e) {
               response = ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).build();
          }

          return response;
     }
     
     public ResponseEntity update(GenericEntity entitty) {
          
          ResponseEntity response = null;
          try {

               if (Objeto.isBlank(entitty)) {

                    response = ResponseEntity.status(HttpStatus.BAD_REQUEST).build();

               } else {

                    if (Objeto.isBlank(entitty.getId())) {

                         response = ResponseEntity.status(HttpStatus.NOT_FOUND).body(json("� obrigatorio informa o ID do objeto que deseja atualizar."));

                    } else if (Objeto.isBlank(getJpaRepository().findById(entitty.getId()).orElse(null))) {

                         response = ResponseEntity.status(HttpStatus.NOT_FOUND).body(json("Objeto n�o encontrado para ser atualizado."));

                    } else {

                         Object entity_ = getJpaRepository().save(entitty);
                         response = ResponseEntity.ok(entity_);

                    }

               }

          } catch (Exception e) {
               response = ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).build();
          }
          
          return response;
     }

     public ResponseEntity delete(Long id) {

          ResponseEntity response = null;
          try {

               if (Objeto.isBlank(id)) {

                    response = ResponseEntity.status(HttpStatus.BAD_REQUEST).build();

               } else {
                    
                    Object tmp_ = getJpaRepository().findById(id).orElse(null);
                    if(Objeto.isBlank(tmp_)){
                         response = ResponseEntity.status(HttpStatus.NOT_FOUND).body(json("Objeto n�o encontrado"));
                    }
                         
                    getJpaRepository().delete(id);
                    response = ResponseEntity.ok().build();
                    
               }

          } catch (Exception e) {
               response = ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).build();
          }

          return response;
     }

     public static void loadEager(List lista) {

          if(Objeto.notBlank(lista)){
               lista.forEach(l -> load(l));
          }
          
     }
     public static void load(Object o) {
          
          try {
               
               List<Field> fields = new ArrayList<Field>();
               getAllFields(fields, o.getClass());
               for (Field field : fields) {
                    if (Reflexao.existeGet(o, field.getName())) {
                         Object o_ = Reflexao.getValorDoAtributo(o, field.getName());
                         if (Objeto.notBlank(o_)) {
                              System.out.println(field.getName());
                              load(o_);
                         }
                    }
               }
               
          } catch (Exception e) {
               log.error(null, e);
          }
          
     }

     public static List<Field> getAllFields(List<Field> fields, Class<?> type) {

          fields.addAll(Arrays.asList(type.getDeclaredFields()));

          if (type.getSuperclass() != null) {
               fields = getAllFields(fields, type.getSuperclass());
          }

          return fields;
     }

     public static void main(String[] args) throws IntrospectionException {

          Cartao cartao = new Cartao();
          cartao.setId(1L);
          Conta c = new Conta();
          Set<Cartao> cartoes = new HashSet<>();
          cartoes.add(cartao);
          c.setCartoes(cartoes);
          cartao.setConta(c);
          
          load(cartao);

     }

}
