package br.com.conductor.sbc.util.dto;

import java.math.BigDecimal;

import br.com.conductor.sbc.util.Response;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class Limite extends Response{
	
	private BigDecimal valor;
	
}
