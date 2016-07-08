
package br.com.conductor.sbc.entidades;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.EnumType;
import javax.persistence.Enumerated;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import org.hibernate.annotations.DynamicInsert;
import org.hibernate.annotations.DynamicUpdate;

import com.fasterxml.jackson.annotation.JsonIgnore;

import lombok.Data;

@Table(name = "CARTOES")
@Entity
@Data
@DynamicInsert
@DynamicUpdate
public class Cartao implements GenericEntity{
     
     public enum StatusCartao{
          ATIVO, CANCELADO, BLOQUEADO;
     }

     @Id
     @GeneratedValue(strategy = GenerationType.IDENTITY)
     @Column(name = "ID")
     private Long id;

     @Column(name = "NOME")
     private String nome;
     
     @Column(name = "NUMERO")
     private String numero;

     @Column(name = "SENHA")
     private String senha;

     @Column(name = "CVV")
     private String cvv;

     @ManyToOne
     @JoinColumn(name="CONTA_ID")
     @JsonIgnore
     private Conta conta;
     
     @OneToMany(mappedBy = "cartao")
     @JsonIgnore
     private Set<Credito> creditos;
     
     @OneToMany(mappedBy = "cartao")
     @JsonIgnore
     private Set<Transacao> transacoes;
     
     @Enumerated(EnumType.STRING)
     @Column(name = "STATUS")
     private StatusCartao status;     

}
