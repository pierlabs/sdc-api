
package br.com.conductor.sbc.util;

import org.junit.Ignore;

@Ignore
public class Constantes{

     public static final String SPRING_PERFIL_DESENVOLVIMENTO = "desenvolvimento";

     public static final String SPRING_PERFIL_TESTE = "teste";

     public static final String SPRING_PERFIL_PRODUCAO = "producao";

     public static final String _404_EXTRATO = "Nenhum extrato conta foi encontrado.";

     public static final String API_TAG_CARTAO = "CartaoResponse";
     
     public static final String API_TAG_CONTA = "Conta";

     public static final String API_PATH = "/v1";

     public static final String PATH_CARTAO = "/cartoes";
     
     public static final String PATH_CONTAS = "/contas";
     
     public static final String PATH_CARTOES = PATH_CONTAS + "/{idConta}/cartoes";

     public static String MSG_NO_CONTENT_EXTRATO_CONTA = "Nenhum extrato da conta informada foi encontrado.";
     
     public static String json(String constante) {

          return "{\"msg\":\"" + constante + "\"}";
     }

}
