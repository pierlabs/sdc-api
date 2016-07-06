package br.com.conductor.sbc;

import java.net.UnknownHostException;

import org.springframework.boot.Banner.Mode;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.actuate.system.ApplicationPidFileWriter;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.builder.SpringApplicationBuilder;
import org.springframework.boot.context.properties.EnableConfigurationProperties;
import org.springframework.boot.context.web.SpringBootServletInitializer;
import org.springframework.cache.annotation.EnableCaching;
import org.springframework.context.annotation.Import;
import org.springframework.scheduling.annotation.EnableScheduling;

import br.com.conductor.sbc.config.SwaggerConfiguration;
import br.com.conductor.sbc.util.SbcProperties;
import lombok.NoArgsConstructor;

@SpringBootApplication
@EnableCaching
@EnableScheduling
@EnableConfigurationProperties({ SbcProperties.class })
@Import(SwaggerConfiguration.class)
@NoArgsConstructor
public class Aplicacao extends SpringBootServletInitializer{

     @Override
     protected SpringApplicationBuilder configure(SpringApplicationBuilder application) {

          return application.sources(Aplicacao.class);
     }

     public static void main(String[] args) throws UnknownHostException {

          SpringApplication s = new SpringApplication(Aplicacao.class);
          s.addListeners(new ApplicationPidFileWriter());
          s.setBannerMode(Mode.CONSOLE);
          s.run(args);

     }

}
