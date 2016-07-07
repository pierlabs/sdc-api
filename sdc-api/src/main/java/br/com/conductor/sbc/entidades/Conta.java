
package br.com.conductor.sbc.entidades;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import org.hibernate.annotations.DynamicInsert;
import org.hibernate.annotations.DynamicUpdate;

import com.fasterxml.jackson.annotation.JsonIgnore;

import lombok.Data;

@Table(name = "CONTAS")
@Entity
@Data
@DynamicInsert
@DynamicUpdate
public class Conta implements GenericEntity{

     @Id
     @GeneratedValue(strategy = GenerationType.IDENTITY)
     @Column(name = "ID")
     private Long id;
     
     @Column(name = "NOME")
     private String nome;
     
     @JsonIgnore
     @OneToMany(mappedBy = "conta")
     private Set<Cartao> cartoes;

}
