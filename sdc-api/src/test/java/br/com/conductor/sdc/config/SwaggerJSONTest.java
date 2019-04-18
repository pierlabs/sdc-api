
package br.com.conductor.sdc.config;

import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.status;

import java.io.File;
import java.io.IOException;

import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.core.io.ClassPathResource;
import org.springframework.http.MediaType;
import org.springframework.mock.web.MockHttpServletResponse;
import org.springframework.test.context.junit4.SpringRunner;
import org.springframework.test.web.servlet.MockMvc;
import org.springframework.test.web.servlet.MvcResult;
import org.springframework.test.web.servlet.ResultHandler;
import org.springframework.test.web.servlet.request.MockMvcRequestBuilders;
import org.springframework.test.web.servlet.setup.MockMvcBuilders;
import org.springframework.web.context.WebApplicationContext;

import com.google.common.base.Charsets;
import com.google.common.io.Files;

import br.com.conductor.sbc.Aplicacao;
import lombok.extern.slf4j.Slf4j;

@RunWith(SpringRunner.class)
@SpringBootTest(classes=Aplicacao.class)
@Slf4j
public class SwaggerJSONTest{

     @Autowired
     private WebApplicationContext context;

     private MockMvc mockMvc;

     private File projectDir;

     private String apiDocPath;

     @Before
     public void setup() throws IOException {

          this.apiDocPath = "/v1/docs";
          this.mockMvc = MockMvcBuilders.webAppContextSetup(this.context).build();

          ClassPathResource pathfileRes = new ClassPathResource("config/application.yml");
          projectDir = pathfileRes.getFile().getParentFile().getParentFile().getParentFile().getParentFile();

     }

     @Test
     public void convertSwaggerToJSON() throws Exception {

          mockMvc.perform(MockMvcRequestBuilders.get(apiDocPath).accept(MediaType.APPLICATION_JSON)).andDo(new ResultHandler(){

               @Override
               public void handle(MvcResult result) throws Exception {

                    MockHttpServletResponse response = result.getResponse();
                    String swaggerJson = response.getContentAsString();

                    File file = new File(outputDirForFormat("json"));
                    if (file != null && !file.exists()) {
                         file.mkdirs();
                    }

                    log.info("Salvando o swagger.json");
                    Files.write(swaggerJson, new File(outputDirForFormat("json"), "swagger.json"), Charsets.UTF_8);

               }

          }).andExpect(status().isOk());

     }

     private String outputDirForFormat(String format) throws IOException {
          File dir = new File(projectDir, "src/main/resources/" + format);
          
          if(!dir.exists()){
               dir.mkdirs();
          }
          
          return dir.getAbsolutePath();
     }

}