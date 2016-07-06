
package br.com.conductor.sbc;

import org.junit.Ignore;
import org.springframework.boot.context.properties.ConfigurationProperties;

import lombok.Getter;
import lombok.Setter;

@ConfigurationProperties(prefix = "sbc", ignoreUnknownFields = true)
@Ignore
public class SbcProperties{

     @Getter
     @Setter
     private String dataBaseType;

     @Getter
     @Setter
     private String dataSourceClassName;

     @Getter
     @Setter
     private int port;

     @Getter
     @Setter
     private String connectionTestQuery;

     @Getter
     @Setter
     private String databaseName;

     @Getter
     @Setter
     private String serverName;

     @Getter
     @Setter
     private String domain;

     @Getter
     @Setter
     private String username;

     @Getter
     @Setter
     private String password;

     @Getter
     @Setter
     private String url;
     
     
}
