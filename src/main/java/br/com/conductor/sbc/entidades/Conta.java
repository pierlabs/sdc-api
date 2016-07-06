
package br.com.conductor.sbc.entidades;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import org.hibernate.annotations.DynamicInsert;
import org.hibernate.annotations.DynamicUpdate;

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

     @OneToMany(mappedBy = "conta", fetch=FetchType.EAGER)
     private Set<Cartao> cartoes;

}
