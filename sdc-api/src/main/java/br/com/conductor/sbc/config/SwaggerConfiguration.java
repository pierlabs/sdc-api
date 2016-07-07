
package br.com.conductor.sbc.config;

import static com.google.common.collect.Lists.newArrayList;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import org.springframework.boot.bind.RelaxedPropertyResolver;
import org.springframework.context.EnvironmentAware;
import org.springframework.context.annotation.Bean;
import org.springframework.core.env.Environment;
import org.springframework.http.ResponseEntity;
import org.springframework.util.StopWatch;

import com.google.common.base.Predicate;
import com.google.common.collect.Lists;

import br.com.conductor.sbc.util.Constantes;
import br.com.twsoftware.alfred.object.Objeto;
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
public class SwaggerConfiguration implements EnvironmentAware{

     public static final String DEFAULT_INCLUDE_PATTERN = Constantes.API_PATH + "/.*";

     private RelaxedPropertyResolver propertyResolver;
     
     private Environment env;

     @Override
     public void setEnvironment(Environment env) {
          this.env = env;
          this.propertyResolver = new RelaxedPropertyResolver(env, "swagger.");
     }

     @Bean
     public Docket swaggerSpringfoxDocket() {

          StopWatch watch = new StopWatch();
          watch.start();
          Docket docket = new Docket(DocumentationType.SWAGGER_2)
                    .apiInfo(apiInfo())
                    .genericModelSubstitutes(ResponseEntity.class)
                    .forCodeGeneration(true)
                    .genericModelSubstitutes(ResponseEntity.class)
                    .securitySchemes(apiKeys())
                    .securityContexts(newArrayList(securityContext()))
                    .select()
                         .paths(new Predicate<String>(){
                              @Override
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

          return new SecurityConfiguration(null, null, null, "sdc", "access_token", ApiKeyVehicle.HEADER, "access_token", "," );
          
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

          return new ApiInfo(propertyResolver.getProperty("title"), 
                    propertyResolver.getProperty("description"), 
                    propertyResolver.getProperty("version"), 
                    propertyResolver.getProperty("termsOfServiceUrl"), 
                    new Contact("PIER Labs", "http://pierlabs.io", "pierlabs@conductor.com.br"), 
                    propertyResolver.getProperty("license"), 
                    propertyResolver.getProperty("licenseUrl"));
          
     }

}
