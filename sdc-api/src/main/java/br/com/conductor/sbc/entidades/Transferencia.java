package br.com.conductor.sbc.entidades;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

import org.hibernate.annotations.DynamicInsert;
import org.hibernate.annotations.DynamicUpdate;

import lombok.Data;

@Table(name = "TRANSFERENCIAS")
@Entity
@Data
@DynamicInsert
@DynamicUpdate
public class Transferencia implements GenericEntity{
     
     @Id
     @GeneratedValue(strategy = GenerationType.IDENTITY)
     @Column(name = "ID")
     private Long id;   

}
