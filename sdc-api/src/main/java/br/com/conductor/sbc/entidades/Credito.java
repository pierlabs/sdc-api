package br.com.conductor.sbc.entidades;

import java.math.BigDecimal;
import java.time.LocalDateTime;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

import org.hibernate.annotations.DynamicInsert;
import org.hibernate.annotations.DynamicUpdate;

import com.fasterxml.jackson.annotation.JsonIgnore;

import lombok.Data;

@Table(name = "CREDITOS")
@Entity
@Data
@DynamicInsert
@DynamicUpdate
public class Credito implements GenericEntity{
     
     @Id
     @GeneratedValue(strategy = GenerationType.IDENTITY)
     @Column(name = "ID")
     private Long id;
     
     @Column(name = "VALOR")
     private BigDecimal valor;
     
     @Column(name = "DATA_CREDITO")
     @JsonIgnore
     private LocalDateTime dataCredito;
     
     @JsonIgnore
     @ManyToOne
     @JoinColumn(name="CARTAO_ID")
     private Cartao cartao;

}
