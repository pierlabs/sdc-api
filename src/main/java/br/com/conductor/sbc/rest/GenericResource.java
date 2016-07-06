
package br.com.conductor.sbc.rest;

import java.beans.IntrospectionException;
import java.lang.reflect.Field;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import javax.persistence.Column;

import org.reflections.Reflections;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.transaction.annotation.Transactional;

import com.google.common.collect.Lists;

import br.com.conductor.sbc.entidades.Cartao;
import br.com.conductor.sbc.entidades.Conta;
import br.com.twsoftware.alfred.object.Objeto;
import br.com.twsoftware.alfred.reflexao.Reflexao;
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

          Object result = getJpaRepository().findOne(id);
          if (Objeto.notBlank(result)) {
               return ResponseEntity.ok(result);
          } else {
               return ResponseEntity.notFound().build();
          }

     }

     public ResponseEntity createOrUpdate(Object entitty) {

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

     public ResponseEntity delete(Long id) {

          ResponseEntity response = null;
          try {

               if (Objeto.isBlank(id)) {

                    response = ResponseEntity.status(HttpStatus.BAD_REQUEST).build();

               } else {

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
