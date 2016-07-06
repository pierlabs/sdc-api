
package br.com.conductor.sbc.entidades;

import java.util.Date;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.EnumType;
import javax.persistence.Enumerated;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import org.hibernate.annotations.DynamicInsert;
import org.hibernate.annotations.DynamicUpdate;

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

     @Column(name = "NUMERO")
     private String numero;

     @Column(name = "SENHA")
     private String senha;

     @Column(name = "CVV")
     private String cvv;

     @Column(name = "DATA_VALIDADE")
     private Date dataValidade;
     
     @ManyToOne
     @JoinColumn(name="CONTA_ID")
     private Conta conta;
     
     @OneToMany(mappedBy = "cartao", fetch=FetchType.EAGER)
     private Set<Credito> creditos;
     
     @OneToMany(mappedBy = "cartao", fetch=FetchType.EAGER)
     private Set<Compra> compras;
     
     @Enumerated(EnumType.STRING)
     @Column(name = "STATUS")
     private StatusCartao status;     

}
