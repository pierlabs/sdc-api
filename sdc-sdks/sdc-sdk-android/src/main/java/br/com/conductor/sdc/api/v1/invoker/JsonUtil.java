package br.com.conductor.sdc.api.v1.invoker;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.reflect.TypeToken;
import java.lang.reflect.Type;
import java.util.List;
import br.com.conductor.sdc.api.v1.model.*;

public class JsonUtil {
  public static GsonBuilder gsonBuilder;

  static {
    gsonBuilder = new GsonBuilder();
    gsonBuilder.serializeNulls();
    gsonBuilder.setDateFormat("yyyy-MM-dd'T'HH:mm:ss.SSS'Z'");
  }

  public static Gson getGson() {
    return gsonBuilder.create();
  }

  public static String serialize(Object obj){
    return getGson().toJson(obj);
  }

  public static <T> T deserializeToList(String jsonString, Class cls){
    return getGson().fromJson(jsonString, getListTypeForDeserialization(cls));
  }

  public static <T> T deserializeToObject(String jsonString, Class cls){
    return getGson().fromJson(jsonString, getTypeForDeserialization(cls));
  }

  public static Type getListTypeForDeserialization(Class cls) {
    String className = cls.getSimpleName();
    
    if ("Cartao".equalsIgnoreCase(className)) {
      return new TypeToken<List<Cartao>>(){}.getType();
    }
    
    if ("Conta".equalsIgnoreCase(className)) {
      return new TypeToken<List<Conta>>(){}.getType();
    }
    
    if ("Extrato".equalsIgnoreCase(className)) {
      return new TypeToken<List<Extrato>>(){}.getType();
    }
    
    if ("Limite".equalsIgnoreCase(className)) {
      return new TypeToken<List<Limite>>(){}.getType();
    }
    
    if ("Response".equalsIgnoreCase(className)) {
      return new TypeToken<List<Response>>(){}.getType();
    }
    
    return new TypeToken<List<Object>>(){}.getType();
  }

  public static Type getTypeForDeserialization(Class cls) {
    String className = cls.getSimpleName();
    
    if ("Cartao".equalsIgnoreCase(className)) {
      return new TypeToken<Cartao>(){}.getType();
    }
    
    if ("Conta".equalsIgnoreCase(className)) {
      return new TypeToken<Conta>(){}.getType();
    }
    
    if ("Extrato".equalsIgnoreCase(className)) {
      return new TypeToken<Extrato>(){}.getType();
    }
    
    if ("Limite".equalsIgnoreCase(className)) {
      return new TypeToken<Limite>(){}.getType();
    }
    
    if ("Response".equalsIgnoreCase(className)) {
      return new TypeToken<Response>(){}.getType();
    }
    
    return new TypeToken<Object>(){}.getType();
  }

};
