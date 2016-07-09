(ns sdc-sdk-clojure.api.conta
  (:require [sdc-sdk-clojure.core :refer [call-api check-required-params with-collection-format]])
  (:import (java.io File)))

(defn create-using-post1-with-http-info
  "Cria uma conta
  Cria uma conta"
  [conta ]
  (call-api "/v1/contas" :post
            {:path-params   {}
             :header-params {}
             :query-params  {}
             :form-params   {}
             :body-param    conta
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn create-using-post1
  "Cria uma conta
  Cria uma conta"
  [conta ]
  (:data (create-using-post1-with-http-info conta)))

(defn delete-using-delete-with-http-info
  "Deleta uma conta
  Deleta um cartÃ£o"
  [id ]
  (call-api "/v1/contas/{id}" :delete
            {:path-params   {"id" id }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn delete-using-delete
  "Deleta uma conta
  Deleta um cartÃ£o"
  [id ]
  (:data (delete-using-delete-with-http-info id)))

(defn get-all-using-get1-with-http-info
  "Retorna todas as contas
  Retorna todas as contas"
  []
  (call-api "/v1/contas" :get
            {:path-params   {}
             :header-params {}
             :query-params  {}
             :form-params   {}
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn get-all-using-get1
  "Retorna todas as contas
  Retorna todas as contas"
  []
  (:data (get-all-using-get1-with-http-info)))

(defn get-one-using-get1-with-http-info
  "Retorna uma conta
  Retorna uma conta"
  [id ]
  (call-api "/v1/contas/{id}" :get
            {:path-params   {"id" id }
             :header-params {}
             :query-params  {}
             :form-params   {}
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn get-one-using-get1
  "Retorna uma conta
  Retorna uma conta"
  [id ]
  (:data (get-one-using-get1-with-http-info id)))

(defn update-using-put1-with-http-info
  "Atualiza uma conta
  Atualiza uma conta"
  [conta ]
  (call-api "/v1/contas" :put
            {:path-params   {}
             :header-params {}
             :query-params  {}
             :form-params   {}
             :body-param    conta
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["access_token"]}))

(defn update-using-put1
  "Atualiza uma conta
  Atualiza uma conta"
  [conta ]
  (:data (update-using-put1-with-http-info conta)))
