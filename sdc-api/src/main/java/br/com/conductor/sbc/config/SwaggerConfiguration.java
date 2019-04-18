
package br.com.conductor.sbc.config;

import static com.google.common.collect.Lists.newArrayList;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Date;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.core.env.Environment;
import org.springframework.http.ResponseEntity;
import org.springframework.util.StopWatch;

import com.github.thiagonego.alfred.object.Objeto;
import com.google.common.base.Predicate;
import com.google.common.collect.Lists;

import br.com.conductor.sbc.util.Constantes;
import br.com.conductor.sbc.util.dto.Response;
import springfox.documentation.builders.PathSelectors;
import springfox.documentation.service.ApiInfo;
import springfox.documentation.service.ApiKey;
import springfox.documentation.service.AuthorizationScope;
import springfox.documentation.service.Contact;
import springfox.documentation.service.SecurityReference;
import springfox.documentation.spi.DocumentationType;
import springfox.documentation.spi.service.contexts.SecurityContext;
import springfox.documentation.spring.web.plugins.Docket;
import springfox.documentation.swagger.web.ApiKeyVehicle;
import springfox.documentation.swagger.web.SecurityConfiguration;
import springfox.documentation.swagger2.annotations.EnableSwagger2;

@EnableSwagger2
public class SwaggerConfiguration{

     public static final String DEFAULT_INCLUDE_PATTERN = Constantes.API_PATH + "/.*";
     
     @Autowired
     private Environment env;

     @Bean
     public Docket swaggerSpringfoxDocket() {

          StopWatch watch = new StopWatch();
          watch.start();
          Docket docket = new Docket(DocumentationType.SWAGGER_2)
               .apiInfo(apiInfo())
               .genericModelSubstitutes(ResponseEntity.class)
               .directModelSubstitute(ResponseEntity.class, Response.class)
               .ignoredParameterTypes(java.sql.Date.class)
               .directModelSubstitute(java.time.LocalDate.class, java.sql.Date.class)
               .directModelSubstitute(java.time.ZonedDateTime.class, Date.class)
               .directModelSubstitute(java.time.LocalDateTime.class, Date.class)
               .forCodeGeneration(true)
               .securitySchemes(apiKeys())
               .securityContexts(newArrayList(securityContext()))
               .select()
                    .paths(new Predicate<String>(){

                         public boolean apply(String input) {

                              return apiIncludePattern(input);
                              
                         }
                    })
                    .build();
          watch.stop();
          
          return docket;

     }
     
     private boolean apiIncludePattern(String input){
          
          List<String> profiles = Arrays.asList(env.getActiveProfiles());
          if(Objeto.isBlank(profiles)){
               return input.matches(DEFAULT_INCLUDE_PATTERN);
          }else{
               return !input.matches(Constantes.API_PATH + Constantes.PATH_CARTAO + "/.*") && input.matches(DEFAULT_INCLUDE_PATTERN);
          }
          
     }

     @Bean
     SecurityConfiguration security() {

          return new SecurityConfiguration("client_id", null, null, "sdc", "access_token", ApiKeyVehicle.HEADER, "access_token", "," );
          
     }

     private ArrayList<ApiKey> apiKeys() {
          
          return Lists.newArrayList( new ApiKey("access_token", "access_token", "header"), new ApiKey("client_id", "client_id", "header"));
          
     }

     private SecurityContext securityContext() {

          return SecurityContext.builder().securityReferences(defaultAuth()).forPaths(PathSelectors.regex(DEFAULT_INCLUDE_PATTERN)).build();
     }

     List<SecurityReference> defaultAuth() {

          AuthorizationScope authorizationScope = new AuthorizationScope("global", "accessEverything");
          AuthorizationScope[] authorizationScopes = new AuthorizationScope[1];
          authorizationScopes[0] = authorizationScope;

          return newArrayList(new SecurityReference("access_token", authorizationScopes));
     }

     public ApiInfo apiInfo() {

          return new ApiInfo("API SDC 2016", 
                    "API desenvolvida para a 15ª semanda da computação da UFPB em 2016", 
                    "1.0.0", 
                    "http://pierlabs.io/terms/", 
                    new Contact("PIER Labs", "http://pierlabs.io", "pierlabs@conductor.com.br"), 
                    "Apache 2.0", 
                    "http://www.apache.org/licenses/LICENSE-2.0.html");
          
     }

}
