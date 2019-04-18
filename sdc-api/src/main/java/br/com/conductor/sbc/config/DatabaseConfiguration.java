
package br.com.conductor.sbc.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;

import br.com.conductor.sbc.util.FixedH2Dialect;

@Configuration
@EnableJpaRepositories(basePackages = { "br.com.conductor.sbc.repositorios" })
public class DatabaseConfiguration{

     @Bean
     public FixedH2Dialect sd() {

          return new FixedH2Dialect();
     }

}
