using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Conductor.SDC.Client;
using Conductor.SDC.Model;

namespace Conductor.SDC.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICartaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Bloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <remarks>
        /// Bloquear um cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser bloqueado</param>
        /// <returns>Response</returns>
        Response BloquearUsingPUT (long? idConta, long? idCartao);
  
        /// <summary>
        /// Bloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <remarks>
        /// Bloquear um cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser bloqueado</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> BloquearUsingPUTWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Cancelar um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser cancelado</param>
        /// <returns>Response</returns>
        Response CancelarUsingDELETE (long? idConta, long? idCartao);
  
        /// <summary>
        /// Cancelar um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser cancelado</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> CancelarUsingDELETEWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Cria um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser criado</param>
        /// <returns>Cartao</returns>
        Cartao CreateUsingPOST (long? idConta, Cartao cartao);
  
        /// <summary>
        /// Cria um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser criado</param>
        /// <returns>ApiResponse of Cartao</returns>
        ApiResponse<Cartao> CreateUsingPOSTWithHttpInfo (long? idConta, Cartao cartao);
        
        /// <summary>
        /// Creditar dinheiro em um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor a ser creditado</param>
        /// <returns>Response</returns>
        Response CreditarUsingPUT (long? idConta, long? idCartao, double? valor);
  
        /// <summary>
        /// Creditar dinheiro em um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor a ser creditado</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> CreditarUsingPUTWithHttpInfo (long? idConta, long? idCartao, double? valor);
        
        /// <summary>
        /// Desbloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <remarks>
        /// Desbloquear um determinado cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser desbloqueado</param>
        /// <returns>Response</returns>
        Response DesbloquearUsingPUT (long? idConta, long? idCartao);
  
        /// <summary>
        /// Desbloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <remarks>
        /// Desbloquear um determinado cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser desbloqueado</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> DesbloquearUsingPUTWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o</param>
        /// <returns>Response</returns>
        Response ExtratosUsingPOST (long? idConta, long? idCartao);
  
        /// <summary>
        /// Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> ExtratosUsingPOSTWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Retona todos os cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <remarks>
        /// Consulte todos os carteos de uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>List&lt;Cartao&gt;</returns>
        List<Cartao> GetAllUsingGET (long? idConta);
  
        /// <summary>
        /// Retona todos os cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <remarks>
        /// Consulte todos os carteos de uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>ApiResponse of List&lt;Cartao&gt;</returns>
        ApiResponse<List<Cartao>> GetAllUsingGETWithHttpInfo (long? idConta);
        
        /// <summary>
        /// Retorna um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consulte um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o</param>
        /// <returns>Cartao</returns>
        Cartao GetOneUsingGET (long? idConta, long? idCartao);
  
        /// <summary>
        /// Retorna um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consulte um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o</param>
        /// <returns>ApiResponse of Cartao</returns>
        ApiResponse<Cartao> GetOneUsingGETWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Retorna o limite do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consultar o limite de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <returns>Limite</returns>
        Limite LimiteUsingGET (long? idConta, long? idCartao);
  
        /// <summary>
        /// Retorna o limite do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consultar o limite de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <returns>ApiResponse of Limite</returns>
        ApiResponse<Limite> LimiteUsingGETWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Transacionar valores
        /// </summary>
        /// <remarks>
        /// Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor da transa\u00C3\u00A7\u00C3\u00A3o</param>
        /// <returns>Response</returns>
        Response TransacionarUsingPUT (long? idConta, long? idCartao, double? valor);
  
        /// <summary>
        /// Transacionar valores
        /// </summary>
        /// <remarks>
        /// Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor da transa\u00C3\u00A7\u00C3\u00A3o</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> TransacionarUsingPUTWithHttpInfo (long? idConta, long? idCartao, double? valor);
        
        /// <summary>
        /// Transferir valores entre dois cart\u00C3\u00B5es distintos
        /// </summary>
        /// <remarks>
        /// Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartaoDestino">ID do cart\u00C3\u00A3o de destino</param>
        /// <param name="valor">Valor a ser transferido</param>
        /// <returns>Response</returns>
        Response TransferirUsingPOST (long? idConta, long? idCartao, long? idCartaoDestino, double? valor);
  
        /// <summary>
        /// Transferir valores entre dois cart\u00C3\u00B5es distintos
        /// </summary>
        /// <remarks>
        /// Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartaoDestino">ID do cart\u00C3\u00A3o de destino</param>
        /// <param name="valor">Valor a ser transferido</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> TransferirUsingPOSTWithHttpInfo (long? idConta, long? idCartao, long? idCartaoDestino, double? valor);
        
        /// <summary>
        /// Atualiza um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Atualiza um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser atualizado</param>
        /// <returns>Cartao</returns>
        Cartao UpdateUsingPUT (long? idConta, Cartao cartao);
  
        /// <summary>
        /// Atualiza um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Atualiza um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser atualizado</param>
        /// <returns>ApiResponse of Cartao</returns>
        ApiResponse<Cartao> UpdateUsingPUTWithHttpInfo (long? idConta, Cartao cartao);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Bloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <remarks>
        /// Bloquear um cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser bloqueado</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> BloquearUsingPUTAsync (long? idConta, long? idCartao);

        /// <summary>
        /// Bloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <remarks>
        /// Bloquear um cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser bloqueado</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> BloquearUsingPUTAsyncWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Cancelar um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser cancelado</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> CancelarUsingDELETEAsync (long? idConta, long? idCartao);

        /// <summary>
        /// Cancelar um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Cancelar um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser cancelado</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> CancelarUsingDELETEAsyncWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Cria um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser criado</param>
        /// <returns>Task of Cartao</returns>
        System.Threading.Tasks.Task<Cartao> CreateUsingPOSTAsync (long? idConta, Cartao cartao);

        /// <summary>
        /// Cria um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser criado</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cartao>> CreateUsingPOSTAsyncWithHttpInfo (long? idConta, Cartao cartao);
        
        /// <summary>
        /// Creditar dinheiro em um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor a ser creditado</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> CreditarUsingPUTAsync (long? idConta, long? idCartao, double? valor);

        /// <summary>
        /// Creditar dinheiro em um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor a ser creditado</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> CreditarUsingPUTAsyncWithHttpInfo (long? idConta, long? idCartao, double? valor);
        
        /// <summary>
        /// Desbloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <remarks>
        /// Desbloquear um determinado cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser desbloqueado</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> DesbloquearUsingPUTAsync (long? idConta, long? idCartao);

        /// <summary>
        /// Desbloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <remarks>
        /// Desbloquear um determinado cart\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser desbloqueado</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> DesbloquearUsingPUTAsyncWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> ExtratosUsingPOSTAsync (long? idConta, long? idCartao);

        /// <summary>
        /// Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> ExtratosUsingPOSTAsyncWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Retona todos os cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <remarks>
        /// Consulte todos os carteos de uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of List&lt;Cartao&gt;</returns>
        System.Threading.Tasks.Task<List<Cartao>> GetAllUsingGETAsync (long? idConta);

        /// <summary>
        /// Retona todos os cart\u00C3\u00A3o de uma conta
        /// </summary>
        /// <remarks>
        /// Consulte todos os carteos de uma determinada conta.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (List&lt;Cartao&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Cartao>>> GetAllUsingGETAsyncWithHttpInfo (long? idConta);
        
        /// <summary>
        /// Retorna um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consulte um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o</param>
        /// <returns>Task of Cartao</returns>
        System.Threading.Tasks.Task<Cartao> GetOneUsingGETAsync (long? idConta, long? idCartao);

        /// <summary>
        /// Retorna um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consulte um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cartao>> GetOneUsingGETAsyncWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Retorna o limite do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consultar o limite de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <returns>Task of Limite</returns>
        System.Threading.Tasks.Task<Limite> LimiteUsingGETAsync (long? idConta, long? idCartao);

        /// <summary>
        /// Retorna o limite do cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Consultar o limite de um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <returns>Task of ApiResponse (Limite)</returns>
        System.Threading.Tasks.Task<ApiResponse<Limite>> LimiteUsingGETAsyncWithHttpInfo (long? idConta, long? idCartao);
        
        /// <summary>
        /// Transacionar valores
        /// </summary>
        /// <remarks>
        /// Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor da transa\u00C3\u00A7\u00C3\u00A3o</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> TransacionarUsingPUTAsync (long? idConta, long? idCartao, double? valor);

        /// <summary>
        /// Transacionar valores
        /// </summary>
        /// <remarks>
        /// Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor da transa\u00C3\u00A7\u00C3\u00A3o</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> TransacionarUsingPUTAsyncWithHttpInfo (long? idConta, long? idCartao, double? valor);
        
        /// <summary>
        /// Transferir valores entre dois cart\u00C3\u00B5es distintos
        /// </summary>
        /// <remarks>
        /// Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartaoDestino">ID do cart\u00C3\u00A3o de destino</param>
        /// <param name="valor">Valor a ser transferido</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> TransferirUsingPOSTAsync (long? idConta, long? idCartao, long? idCartaoDestino, double? valor);

        /// <summary>
        /// Transferir valores entre dois cart\u00C3\u00B5es distintos
        /// </summary>
        /// <remarks>
        /// Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartaoDestino">ID do cart\u00C3\u00A3o de destino</param>
        /// <param name="valor">Valor a ser transferido</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> TransferirUsingPOSTAsyncWithHttpInfo (long? idConta, long? idCartao, long? idCartaoDestino, double? valor);
        
        /// <summary>
        /// Atualiza um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Atualiza um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser atualizado</param>
        /// <returns>Task of Cartao</returns>
        System.Threading.Tasks.Task<Cartao> UpdateUsingPUTAsync (long? idConta, Cartao cartao);

        /// <summary>
        /// Atualiza um cart\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Atualiza um determinado cart\u00C3\u00A3o
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser atualizado</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cartao>> UpdateUsingPUTAsyncWithHttpInfo (long? idConta, Cartao cartao);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CartaoApi : ICartaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CartaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CartaoApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Bloquear um cart\u00C3\u00A3o. Bloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser bloqueado</param> 
        /// <returns>Response</returns>
        public Response BloquearUsingPUT (long? idConta, long? idCartao)
        {
             ApiResponse<Response> localVarResponse = BloquearUsingPUTWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bloquear um cart\u00C3\u00A3o. Bloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser bloqueado</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > BloquearUsingPUTWithHttpInfo (long? idConta, long? idCartao)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->BloquearUsingPUT");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->BloquearUsingPUT");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/bloquear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        
        /// <summary>
        /// Bloquear um cart\u00C3\u00A3o. Bloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser bloqueado</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> BloquearUsingPUTAsync (long? idConta, long? idCartao)
        {
             ApiResponse<Response> localVarResponse = await BloquearUsingPUTAsyncWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bloquear um cart\u00C3\u00A3o. Bloquear um cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser bloqueado</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> BloquearUsingPUTAsyncWithHttpInfo (long? idConta, long? idCartao)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling BloquearUsingPUT");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling BloquearUsingPUT");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/bloquear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling BloquearUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }
        
        /// <summary>
        /// Cancelar um cart\u00C3\u00A3o Cancelar um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser cancelado</param> 
        /// <returns>Response</returns>
        public Response CancelarUsingDELETE (long? idConta, long? idCartao)
        {
             ApiResponse<Response> localVarResponse = CancelarUsingDELETEWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancelar um cart\u00C3\u00A3o Cancelar um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser cancelado</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > CancelarUsingDELETEWithHttpInfo (long? idConta, long? idCartao)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->CancelarUsingDELETE");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->CancelarUsingDELETE");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/cancelar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingDELETE: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingDELETE: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        
        /// <summary>
        /// Cancelar um cart\u00C3\u00A3o Cancelar um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser cancelado</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> CancelarUsingDELETEAsync (long? idConta, long? idCartao)
        {
             ApiResponse<Response> localVarResponse = await CancelarUsingDELETEAsyncWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancelar um cart\u00C3\u00A3o Cancelar um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser cancelado</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> CancelarUsingDELETEAsyncWithHttpInfo (long? idConta, long? idCartao)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling CancelarUsingDELETE");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling CancelarUsingDELETE");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/cancelar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingDELETE: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingDELETE: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }
        
        /// <summary>
        /// Cria um cart\u00C3\u00A3o Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="cartao">Cart\u00C3\u00A3o a ser criado</param> 
        /// <returns>Cartao</returns>
        public Cartao CreateUsingPOST (long? idConta, Cartao cartao)
        {
             ApiResponse<Cartao> localVarResponse = CreateUsingPOSTWithHttpInfo(idConta, cartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cria um cart\u00C3\u00A3o Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="cartao">Cart\u00C3\u00A3o a ser criado</param> 
        /// <returns>ApiResponse of Cartao</returns>
        public ApiResponse< Cartao > CreateUsingPOSTWithHttpInfo (long? idConta, Cartao cartao)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->CreateUsingPOST");
            
            // verify the required parameter 'cartao' is set
            if (cartao == null)
                throw new ApiException(400, "Missing required parameter 'cartao' when calling CartaoApi->CreateUsingPOST");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            if (cartao.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartao); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartao; // byte array
            }

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }

        
        /// <summary>
        /// Cria um cart\u00C3\u00A3o Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser criado</param>
        /// <returns>Task of Cartao</returns>
        public async System.Threading.Tasks.Task<Cartao> CreateUsingPOSTAsync (long? idConta, Cartao cartao)
        {
             ApiResponse<Cartao> localVarResponse = await CreateUsingPOSTAsyncWithHttpInfo(idConta, cartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cria um cart\u00C3\u00A3o Voc\u00C3\u00AA pode criar um cart\u00C3\u00A3o ligado h\u00C3\u00A1 uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser criado</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cartao>> CreateUsingPOSTAsyncWithHttpInfo (long? idConta, Cartao cartao)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling CreateUsingPOST");
            // verify the required parameter 'cartao' is set
            if (cartao == null) throw new ApiException(400, "Missing required parameter 'cartao' when calling CreateUsingPOST");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            if (cartao.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartao); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartao; // byte array
            }

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }
        
        /// <summary>
        /// Creditar dinheiro em um cart\u00C3\u00A3o Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cartao a ser creditado</param> 
        /// <param name="valor">Valor a ser creditado</param> 
        /// <returns>Response</returns>
        public Response CreditarUsingPUT (long? idConta, long? idCartao, double? valor)
        {
             ApiResponse<Response> localVarResponse = CreditarUsingPUTWithHttpInfo(idConta, idCartao, valor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creditar dinheiro em um cart\u00C3\u00A3o Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cartao a ser creditado</param> 
        /// <param name="valor">Valor a ser creditado</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > CreditarUsingPUTWithHttpInfo (long? idConta, long? idCartao, double? valor)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->CreditarUsingPUT");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->CreditarUsingPUT");
            
            // verify the required parameter 'valor' is set
            if (valor == null)
                throw new ApiException(400, "Missing required parameter 'valor' when calling CartaoApi->CreditarUsingPUT");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/creditar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            if (valor.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(valor); // http body (model) parameter
            }
            else
            {
                localVarPostBody = valor; // byte array
            }

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreditarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreditarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        
        /// <summary>
        /// Creditar dinheiro em um cart\u00C3\u00A3o Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor a ser creditado</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> CreditarUsingPUTAsync (long? idConta, long? idCartao, double? valor)
        {
             ApiResponse<Response> localVarResponse = await CreditarUsingPUTAsyncWithHttpInfo(idConta, idCartao, valor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creditar dinheiro em um cart\u00C3\u00A3o Com esse m\u00C3\u00A9todo \u00C3\u00A9 possivel creditar qualquer valor em um cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor a ser creditado</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> CreditarUsingPUTAsyncWithHttpInfo (long? idConta, long? idCartao, double? valor)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling CreditarUsingPUT");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling CreditarUsingPUT");
            // verify the required parameter 'valor' is set
            if (valor == null) throw new ApiException(400, "Missing required parameter 'valor' when calling CreditarUsingPUT");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/creditar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            if (valor.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(valor); // http body (model) parameter
            }
            else
            {
                localVarPostBody = valor; // byte array
            }

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreditarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreditarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }
        
        /// <summary>
        /// Desbloquear um cart\u00C3\u00A3o. Desbloquear um determinado cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser desbloqueado</param> 
        /// <returns>Response</returns>
        public Response DesbloquearUsingPUT (long? idConta, long? idCartao)
        {
             ApiResponse<Response> localVarResponse = DesbloquearUsingPUTWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desbloquear um cart\u00C3\u00A3o. Desbloquear um determinado cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser desbloqueado</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > DesbloquearUsingPUTWithHttpInfo (long? idConta, long? idCartao)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->DesbloquearUsingPUT");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->DesbloquearUsingPUT");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/desbloquear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        
        /// <summary>
        /// Desbloquear um cart\u00C3\u00A3o. Desbloquear um determinado cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser desbloqueado</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> DesbloquearUsingPUTAsync (long? idConta, long? idCartao)
        {
             ApiResponse<Response> localVarResponse = await DesbloquearUsingPUTAsyncWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desbloquear um cart\u00C3\u00A3o. Desbloquear um determinado cart\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">Cart\u00C3\u00A3o a ser desbloqueado</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> DesbloquearUsingPUTAsyncWithHttpInfo (long? idConta, long? idCartao)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling DesbloquearUsingPUT");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling DesbloquearUsingPUT");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/desbloquear";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesbloquearUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }
        
        /// <summary>
        /// Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do cart\u00C3\u00A3o</param> 
        /// <returns>Response</returns>
        public Response ExtratosUsingPOST (long? idConta, long? idCartao)
        {
             ApiResponse<Response> localVarResponse = ExtratosUsingPOSTWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do cart\u00C3\u00A3o</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > ExtratosUsingPOSTWithHttpInfo (long? idConta, long? idCartao)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->ExtratosUsingPOST");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->ExtratosUsingPOST");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/extratos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ExtratosUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ExtratosUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        
        /// <summary>
        /// Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> ExtratosUsingPOSTAsync (long? idConta, long? idCartao)
        {
             ApiResponse<Response> localVarResponse = await ExtratosUsingPOSTAsyncWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retonar os extratos de transa\u00C3\u00A7oes do cart\u00C3\u00A3o Retorna os extratos de todas as transa\u00C3\u00A7oes de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> ExtratosUsingPOSTAsyncWithHttpInfo (long? idConta, long? idCartao)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ExtratosUsingPOST");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling ExtratosUsingPOST");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/extratos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ExtratosUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ExtratosUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }
        
        /// <summary>
        /// Retona todos os cart\u00C3\u00A3o de uma conta Consulte todos os carteos de uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>List&lt;Cartao&gt;</returns>
        public List<Cartao> GetAllUsingGET (long? idConta)
        {
             ApiResponse<List<Cartao>> localVarResponse = GetAllUsingGETWithHttpInfo(idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retona todos os cart\u00C3\u00A3o de uma conta Consulte todos os carteos de uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <returns>ApiResponse of List&lt;Cartao&gt;</returns>
        public ApiResponse< List<Cartao> > GetAllUsingGETWithHttpInfo (long? idConta)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->GetAllUsingGET");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Cartao>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Cartao>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Cartao>)));
            
        }

        
        /// <summary>
        /// Retona todos os cart\u00C3\u00A3o de uma conta Consulte todos os carteos de uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of List&lt;Cartao&gt;</returns>
        public async System.Threading.Tasks.Task<List<Cartao>> GetAllUsingGETAsync (long? idConta)
        {
             ApiResponse<List<Cartao>> localVarResponse = await GetAllUsingGETAsyncWithHttpInfo(idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retona todos os cart\u00C3\u00A3o de uma conta Consulte todos os carteos de uma determinada conta.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <returns>Task of ApiResponse (List&lt;Cartao&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Cartao>>> GetAllUsingGETAsyncWithHttpInfo (long? idConta)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling GetAllUsingGET");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Cartao>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Cartao>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Cartao>)));
            
        }
        
        /// <summary>
        /// Retorna um cart\u00C3\u00A3o Consulte um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o</param> 
        /// <returns>Cartao</returns>
        public Cartao GetOneUsingGET (long? idConta, long? idCartao)
        {
             ApiResponse<Cartao> localVarResponse = GetOneUsingGETWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna um cart\u00C3\u00A3o Consulte um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o</param> 
        /// <returns>ApiResponse of Cartao</returns>
        public ApiResponse< Cartao > GetOneUsingGETWithHttpInfo (long? idConta, long? idCartao)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->GetOneUsingGET");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->GetOneUsingGET");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOneUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOneUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }

        
        /// <summary>
        /// Retorna um cart\u00C3\u00A3o Consulte um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o</param>
        /// <returns>Task of Cartao</returns>
        public async System.Threading.Tasks.Task<Cartao> GetOneUsingGETAsync (long? idConta, long? idCartao)
        {
             ApiResponse<Cartao> localVarResponse = await GetOneUsingGETAsyncWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna um cart\u00C3\u00A3o Consulte um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cart\u00C3\u00A3o</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cartao>> GetOneUsingGETAsyncWithHttpInfo (long? idConta, long? idCartao)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling GetOneUsingGET");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling GetOneUsingGET");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOneUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOneUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }
        
        /// <summary>
        /// Retorna o limite do cart\u00C3\u00A3o Consultar o limite de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cartao a ser creditado</param> 
        /// <returns>Limite</returns>
        public Limite LimiteUsingGET (long? idConta, long? idCartao)
        {
             ApiResponse<Limite> localVarResponse = LimiteUsingGETWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna o limite do cart\u00C3\u00A3o Consultar o limite de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cartao a ser creditado</param> 
        /// <returns>ApiResponse of Limite</returns>
        public ApiResponse< Limite > LimiteUsingGETWithHttpInfo (long? idConta, long? idCartao)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->LimiteUsingGET");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->LimiteUsingGET");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/limite";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling LimiteUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LimiteUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Limite>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Limite) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Limite)));
            
        }

        
        /// <summary>
        /// Retorna o limite do cart\u00C3\u00A3o Consultar o limite de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <returns>Task of Limite</returns>
        public async System.Threading.Tasks.Task<Limite> LimiteUsingGETAsync (long? idConta, long? idCartao)
        {
             ApiResponse<Limite> localVarResponse = await LimiteUsingGETAsyncWithHttpInfo(idConta, idCartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna o limite do cart\u00C3\u00A3o Consultar o limite de um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <returns>Task of ApiResponse (Limite)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Limite>> LimiteUsingGETAsyncWithHttpInfo (long? idConta, long? idCartao)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling LimiteUsingGET");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling LimiteUsingGET");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/limite";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling LimiteUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LimiteUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Limite>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Limite) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Limite)));
            
        }
        
        /// <summary>
        /// Transacionar valores Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cartao a ser creditado</param> 
        /// <param name="valor">Valor da transa\u00C3\u00A7\u00C3\u00A3o</param> 
        /// <returns>Response</returns>
        public Response TransacionarUsingPUT (long? idConta, long? idCartao, double? valor)
        {
             ApiResponse<Response> localVarResponse = TransacionarUsingPUTWithHttpInfo(idConta, idCartao, valor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transacionar valores Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="idCartao">ID do Cartao a ser creditado</param> 
        /// <param name="valor">Valor da transa\u00C3\u00A7\u00C3\u00A3o</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > TransacionarUsingPUTWithHttpInfo (long? idConta, long? idCartao, double? valor)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->TransacionarUsingPUT");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->TransacionarUsingPUT");
            
            // verify the required parameter 'valor' is set
            if (valor == null)
                throw new ApiException(400, "Missing required parameter 'valor' when calling CartaoApi->TransacionarUsingPUT");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/transacionar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            if (valor.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(valor); // http body (model) parameter
            }
            else
            {
                localVarPostBody = valor; // byte array
            }

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransacionarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransacionarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        
        /// <summary>
        /// Transacionar valores Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor da transa\u00C3\u00A7\u00C3\u00A3o</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> TransacionarUsingPUTAsync (long? idConta, long? idCartao, double? valor)
        {
             ApiResponse<Response> localVarResponse = await TransacionarUsingPUTAsyncWithHttpInfo(idConta, idCartao, valor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transacionar valores Transacionar algum valor utilizando um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="idCartao">ID do Cartao a ser creditado</param>
        /// <param name="valor">Valor da transa\u00C3\u00A7\u00C3\u00A3o</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> TransacionarUsingPUTAsyncWithHttpInfo (long? idConta, long? idCartao, double? valor)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling TransacionarUsingPUT");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling TransacionarUsingPUT");
            // verify the required parameter 'valor' is set
            if (valor == null) throw new ApiException(400, "Missing required parameter 'valor' when calling TransacionarUsingPUT");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/transacionar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            
            
            
            if (valor.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(valor); // http body (model) parameter
            }
            else
            {
                localVarPostBody = valor; // byte array
            }

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransacionarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransacionarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }
        
        /// <summary>
        /// Transferir valores entre dois cart\u00C3\u00B5es distintos Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta do cart\u00C3\u00A3o de origem</param> 
        /// <param name="idCartao">ID do cart\u00C3\u00A3o de origem</param> 
        /// <param name="idCartaoDestino">ID do cart\u00C3\u00A3o de destino</param> 
        /// <param name="valor">Valor a ser transferido</param> 
        /// <returns>Response</returns>
        public Response TransferirUsingPOST (long? idConta, long? idCartao, long? idCartaoDestino, double? valor)
        {
             ApiResponse<Response> localVarResponse = TransferirUsingPOSTWithHttpInfo(idConta, idCartao, idCartaoDestino, valor);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Transferir valores entre dois cart\u00C3\u00B5es distintos Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta do cart\u00C3\u00A3o de origem</param> 
        /// <param name="idCartao">ID do cart\u00C3\u00A3o de origem</param> 
        /// <param name="idCartaoDestino">ID do cart\u00C3\u00A3o de destino</param> 
        /// <param name="valor">Valor a ser transferido</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > TransferirUsingPOSTWithHttpInfo (long? idConta, long? idCartao, long? idCartaoDestino, double? valor)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->TransferirUsingPOST");
            
            // verify the required parameter 'idCartao' is set
            if (idCartao == null)
                throw new ApiException(400, "Missing required parameter 'idCartao' when calling CartaoApi->TransferirUsingPOST");
            
            // verify the required parameter 'idCartaoDestino' is set
            if (idCartaoDestino == null)
                throw new ApiException(400, "Missing required parameter 'idCartaoDestino' when calling CartaoApi->TransferirUsingPOST");
            
            // verify the required parameter 'valor' is set
            if (valor == null)
                throw new ApiException(400, "Missing required parameter 'valor' when calling CartaoApi->TransferirUsingPOST");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/transferir";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (idCartaoDestino != null) localVarQueryParams.Add("idCartaoDestino", Configuration.ApiClient.ParameterToString(idCartaoDestino)); // query parameter
            
            
            
            if (valor.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(valor); // http body (model) parameter
            }
            else
            {
                localVarPostBody = valor; // byte array
            }

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        
        /// <summary>
        /// Transferir valores entre dois cart\u00C3\u00B5es distintos Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartaoDestino">ID do cart\u00C3\u00A3o de destino</param>
        /// <param name="valor">Valor a ser transferido</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> TransferirUsingPOSTAsync (long? idConta, long? idCartao, long? idCartaoDestino, double? valor)
        {
             ApiResponse<Response> localVarResponse = await TransferirUsingPOSTAsyncWithHttpInfo(idConta, idCartao, idCartaoDestino, valor);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Transferir valores entre dois cart\u00C3\u00B5es distintos Com esse m\u00C3\u00A9todo \u00C3\u00A9 permitido transferir qualquer valores entre dois cart\u00C3\u00B5es. Basta o cart\u00C3\u00A3o possuir limite e estar desbloqueado.
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartao">ID do cart\u00C3\u00A3o de origem</param>
        /// <param name="idCartaoDestino">ID do cart\u00C3\u00A3o de destino</param>
        /// <param name="valor">Valor a ser transferido</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> TransferirUsingPOSTAsyncWithHttpInfo (long? idConta, long? idCartao, long? idCartaoDestino, double? valor)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling TransferirUsingPOST");
            // verify the required parameter 'idCartao' is set
            if (idCartao == null) throw new ApiException(400, "Missing required parameter 'idCartao' when calling TransferirUsingPOST");
            // verify the required parameter 'idCartaoDestino' is set
            if (idCartaoDestino == null) throw new ApiException(400, "Missing required parameter 'idCartaoDestino' when calling TransferirUsingPOST");
            // verify the required parameter 'valor' is set
            if (valor == null) throw new ApiException(400, "Missing required parameter 'valor' when calling TransferirUsingPOST");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes/{idCartao}/transferir";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idCartao != null) localVarPathParams.Add("idCartao", Configuration.ApiClient.ParameterToString(idCartao)); // path parameter
            
            if (idCartaoDestino != null) localVarQueryParams.Add("idCartaoDestino", Configuration.ApiClient.ParameterToString(idCartaoDestino)); // query parameter
            
            
            
            if (valor.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(valor); // http body (model) parameter
            }
            else
            {
                localVarPostBody = valor; // byte array
            }

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling TransferirUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }
        
        /// <summary>
        /// Atualiza um cart\u00C3\u00A3o Atualiza um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="cartao">Cart\u00C3\u00A3o a ser atualizado</param> 
        /// <returns>Cartao</returns>
        public Cartao UpdateUsingPUT (long? idConta, Cartao cartao)
        {
             ApiResponse<Cartao> localVarResponse = UpdateUsingPUTWithHttpInfo(idConta, cartao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza um cart\u00C3\u00A3o Atualiza um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param> 
        /// <param name="cartao">Cart\u00C3\u00A3o a ser atualizado</param> 
        /// <returns>ApiResponse of Cartao</returns>
        public ApiResponse< Cartao > UpdateUsingPUTWithHttpInfo (long? idConta, Cartao cartao)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CartaoApi->UpdateUsingPUT");
            
            // verify the required parameter 'cartao' is set
            if (cartao == null)
                throw new ApiException(400, "Missing required parameter 'cartao' when calling CartaoApi->UpdateUsingPUT");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            if (cartao.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartao); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartao; // byte array
            }

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }

        
        /// <summary>
        /// Atualiza um cart\u00C3\u00A3o Atualiza um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser atualizado</param>
        /// <returns>Task of Cartao</returns>
        public async System.Threading.Tasks.Task<Cartao> UpdateUsingPUTAsync (long? idConta, Cartao cartao)
        {
             ApiResponse<Cartao> localVarResponse = await UpdateUsingPUTAsyncWithHttpInfo(idConta, cartao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza um cart\u00C3\u00A3o Atualiza um determinado cart\u00C3\u00A3o
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">ID da Conta</param>
        /// <param name="cartao">Cart\u00C3\u00A3o a ser atualizado</param>
        /// <returns>Task of ApiResponse (Cartao)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cartao>> UpdateUsingPUTAsyncWithHttpInfo (long? idConta, Cartao cartao)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling UpdateUsingPUT");
            // verify the required parameter 'cartao' is set
            if (cartao == null) throw new ApiException(400, "Missing required parameter 'cartao' when calling UpdateUsingPUT");
            
    
            var localVarPath = "/v1/contas/{idConta}/cartoes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            
            
            
            
            if (cartao.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cartao); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cartao; // byte array
            }

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Cartao>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Cartao) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cartao)));
            
        }
        
    }
    
}
