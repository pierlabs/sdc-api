(ns sdc-sdk-clojure.api.cartao
  (:require [sdc-sdk-clojure.core :refer [call-api check-required-params with-collection-format]])
  (:import (java.io File)))

(defn bloquear-using-put-with-http-info
  "Bloquear um cartÃ£o.
  Bloquear um cartÃ£o."
  [id-conta id-cartao ]
  (call-api "/v1/contas/{idConta}/cartoes/{idCartao}/bloquear" :put
            {:path-params   {"idConta" id-conta "idCartao" id-cartao }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn bloquear-using-put
  "Bloquear um cartÃ£o.
  Bloquear um cartÃ£o."
  [id-conta id-cartao ]
  (:data (bloquear-using-put-with-http-info id-conta id-cartao)))

(defn cancelar-using-delete-with-http-info
  "Cancelar um cartÃ£o
  Cancelar um determinado cartÃ£o"
  [id-conta id-cartao ]
  (call-api "/v1/contas/{idConta}/cartoes/{idCartao}/cancelar" :delete
            {:path-params   {"idConta" id-conta "idCartao" id-cartao }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn cancelar-using-delete
  "Cancelar um cartÃ£o
  Cancelar um determinado cartÃ£o"
  [id-conta id-cartao ]
  (:data (cancelar-using-delete-with-http-info id-conta id-cartao)))

(defn create-using-post-with-http-info
  "Cria um cartÃ£o
  VocÃª pode criar um cartÃ£o ligado hÃ¡ uma determinada conta."
  [id-conta cartao ]
  (call-api "/v1/contas/{idConta}/cartoes" :post
            {:path-params   {"idConta" id-conta }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :body-param    cartao
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn create-using-post
  "Cria um cartÃ£o
  VocÃª pode criar um cartÃ£o ligado hÃ¡ uma determinada conta."
  [id-conta cartao ]
  (:data (create-using-post-with-http-info id-conta cartao)))

(defn creditar-using-put-with-http-info
  "Creditar dinheiro em um cartÃ£o
  Com esse mÃ©todo Ã© possivel creditar qualquer valor em um cartÃ£o."
  [id-conta id-cartao valor ]
  (call-api "/v1/contas/{idConta}/cartoes/{idCartao}/creditar" :put
            {:path-params   {"idConta" id-conta "idCartao" id-cartao }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :body-param    valor
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn creditar-using-put
  "Creditar dinheiro em um cartÃ£o
  Com esse mÃ©todo Ã© possivel creditar qualquer valor em um cartÃ£o."
  [id-conta id-cartao valor ]
  (:data (creditar-using-put-with-http-info id-conta id-cartao valor)))

(defn desbloquear-using-put-with-http-info
  "Desbloquear um cartÃ£o.
  Desbloquear um determinado cartÃ£o."
  [id-conta id-cartao ]
  (call-api "/v1/contas/{idConta}/cartoes/{idCartao}/desbloquear" :put
            {:path-params   {"idConta" id-conta "idCartao" id-cartao }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn desbloquear-using-put
  "Desbloquear um cartÃ£o.
  Desbloquear um determinado cartÃ£o."
  [id-conta id-cartao ]
  (:data (desbloquear-using-put-with-http-info id-conta id-cartao)))

(defn extratos-using-post-with-http-info
  "Retonar os extratos de transaÃ§oes do cartÃ£o
  Retorna os extratos de todas as transaÃ§oes de um determinado cartÃ£o"
  [id-conta id-cartao ]
  (call-api "/v1/contas/{idConta}/cartoes/{idCartao}/extratos" :post
            {:path-params   {"idConta" id-conta "idCartao" id-cartao }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn extratos-using-post
  "Retonar os extratos de transaÃ§oes do cartÃ£o
  Retorna os extratos de todas as transaÃ§oes de um determinado cartÃ£o"
  [id-conta id-cartao ]
  (:data (extratos-using-post-with-http-info id-conta id-cartao)))

(defn get-all-using-get-with-http-info
  "Retona todos os cartÃ£o de uma conta
  Consulte todos os carteos de uma determinada conta."
  [id-conta ]
  (call-api "/v1/contas/{idConta}/cartoes" :get
            {:path-params   {"idConta" id-conta }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn get-all-using-get
  "Retona todos os cartÃ£o de uma conta
  Consulte todos os carteos de uma determinada conta."
  [id-conta ]
  (:data (get-all-using-get-with-http-info id-conta)))

(defn get-one-using-get-with-http-info
  "Retorna um cartÃ£o
  Consulte um determinado cartÃ£o"
  [id-conta id-cartao ]
  (call-api "/v1/contas/{idConta}/cartoes/{idCartao}" :get
            {:path-params   {"idConta" id-conta "idCartao" id-cartao }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn get-one-using-get
  "Retorna um cartÃ£o
  Consulte um determinado cartÃ£o"
  [id-conta id-cartao ]
  (:data (get-one-using-get-with-http-info id-conta id-cartao)))

(defn limite-using-get-with-http-info
  "Retorna o limite do cartÃ£o
  Consultar o limite de um determinado cartÃ£o"
  [id-conta id-cartao ]
  (call-api "/v1/contas/{idConta}/cartoes/{idCartao}/limite" :get
            {:path-params   {"idConta" id-conta "idCartao" id-cartao }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn limite-using-get
  "Retorna o limite do cartÃ£o
  Consultar o limite de um determinado cartÃ£o"
  [id-conta id-cartao ]
  (:data (limite-using-get-with-http-info id-conta id-cartao)))

(defn transacionar-using-put-with-http-info
  "Transacionar valores
  Transacionar algum valor utilizando um determinado cartÃ£o"
  [id-conta id-cartao valor ]
  (call-api "/v1/contas/{idConta}/cartoes/{idCartao}/transacionar" :put
            {:path-params   {"idConta" id-conta "idCartao" id-cartao }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :body-param    valor
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn transacionar-using-put
  "Transacionar valores
  Transacionar algum valor utilizando um determinado cartÃ£o"
  [id-conta id-cartao valor ]
  (:data (transacionar-using-put-with-http-info id-conta id-cartao valor)))

(defn transferir-using-post-with-http-info
  "Transferir valores entre dois cartÃµes distintos
  Com esse mÃ©todo Ã© permitido transferir qualquer valores entre dois cartÃµes. Basta o cartÃ£o possuir limite e estar desbloqueado."
  [id-conta id-cartao id-cartao-destino valor ]
  (call-api "/v1/contas/{idConta}/cartoes/{idCartao}/transferir" :post
            {:path-params   {"idConta" id-conta "idCartao" id-cartao }
             :header-params {}
             :query-params  {"idCartaoDestino" id-cartao-destino }
             :form-params   {}
             :body-param    valor
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn transferir-using-post
  "Transferir valores entre dois cartÃµes distintos
  Com esse mÃ©todo Ã© permitido transferir qualquer valores entre dois cartÃµes. Basta o cartÃ£o possuir limite e estar desbloqueado."
  [id-conta id-cartao id-cartao-destino valor ]
  (:data (transferir-using-post-with-http-info id-conta id-cartao id-cartao-destino valor)))

(defn update-using-put-with-http-info
  "Atualiza um cartÃ£o
  Atualiza um determinado cartÃ£o"
  [id-conta cartao ]
  (call-api "/v1/contas/{idConta}/cartoes" :put
            {:path-params   {"idConta" id-conta }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :body-param    cartao
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn update-using-put
  "Atualiza um cartÃ£o
  Atualiza um determinado cartÃ£o"
  [id-conta cartao ]
  (:data (update-using-put-with-http-info id-conta cartao)))
