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
    public interface IContaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Cria uma conta
        /// </summary>
        /// <remarks>
        /// Cria uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>Conta</returns>
        Conta CreateUsingPOST1 (Conta conta);
  
        /// <summary>
        /// Cria uma conta
        /// </summary>
        /// <remarks>
        /// Cria uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>ApiResponse of Conta</returns>
        ApiResponse<Conta> CreateUsingPOST1WithHttpInfo (Conta conta);
        
        /// <summary>
        /// Deleta uma conta
        /// </summary>
        /// <remarks>
        /// Deleta uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Response</returns>
        Response DeleteUsingDELETE (long? id);
  
        /// <summary>
        /// Deleta uma conta
        /// </summary>
        /// <remarks>
        /// Deleta uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> DeleteUsingDELETEWithHttpInfo (long? id);
        
        /// <summary>
        /// Retorna todas as contas
        /// </summary>
        /// <remarks>
        /// Retorna todas as contas
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Conta&gt;</returns>
        List<Conta> GetAllUsingGET1 ();
  
        /// <summary>
        /// Retorna todas as contas
        /// </summary>
        /// <remarks>
        /// Retorna todas as contas
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Conta&gt;</returns>
        ApiResponse<List<Conta>> GetAllUsingGET1WithHttpInfo ();
        
        /// <summary>
        /// Retorna uma conta
        /// </summary>
        /// <remarks>
        /// Retorna uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Conta</returns>
        Conta GetOneUsingGET1 (long? id);
  
        /// <summary>
        /// Retorna uma conta
        /// </summary>
        /// <remarks>
        /// Retorna uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of Conta</returns>
        ApiResponse<Conta> GetOneUsingGET1WithHttpInfo (long? id);
        
        /// <summary>
        /// Atualiza uma conta
        /// </summary>
        /// <remarks>
        /// Atualiza uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>Conta</returns>
        Conta UpdateUsingPUT1 (Conta conta);
  
        /// <summary>
        /// Atualiza uma conta
        /// </summary>
        /// <remarks>
        /// Atualiza uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>ApiResponse of Conta</returns>
        ApiResponse<Conta> UpdateUsingPUT1WithHttpInfo (Conta conta);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Cria uma conta
        /// </summary>
        /// <remarks>
        /// Cria uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>Task of Conta</returns>
        System.Threading.Tasks.Task<Conta> CreateUsingPOST1Async (Conta conta);

        /// <summary>
        /// Cria uma conta
        /// </summary>
        /// <remarks>
        /// Cria uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>Task of ApiResponse (Conta)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conta>> CreateUsingPOST1AsyncWithHttpInfo (Conta conta);
        
        /// <summary>
        /// Deleta uma conta
        /// </summary>
        /// <remarks>
        /// Deleta uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> DeleteUsingDELETEAsync (long? id);

        /// <summary>
        /// Deleta uma conta
        /// </summary>
        /// <remarks>
        /// Deleta uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> DeleteUsingDELETEAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Retorna todas as contas
        /// </summary>
        /// <remarks>
        /// Retorna todas as contas
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Conta&gt;</returns>
        System.Threading.Tasks.Task<List<Conta>> GetAllUsingGET1Async ();

        /// <summary>
        /// Retorna todas as contas
        /// </summary>
        /// <remarks>
        /// Retorna todas as contas
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Conta&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Conta>>> GetAllUsingGET1AsyncWithHttpInfo ();
        
        /// <summary>
        /// Retorna uma conta
        /// </summary>
        /// <remarks>
        /// Retorna uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Conta</returns>
        System.Threading.Tasks.Task<Conta> GetOneUsingGET1Async (long? id);

        /// <summary>
        /// Retorna uma conta
        /// </summary>
        /// <remarks>
        /// Retorna uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Conta)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conta>> GetOneUsingGET1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Atualiza uma conta
        /// </summary>
        /// <remarks>
        /// Atualiza uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>Task of Conta</returns>
        System.Threading.Tasks.Task<Conta> UpdateUsingPUT1Async (Conta conta);

        /// <summary>
        /// Atualiza uma conta
        /// </summary>
        /// <remarks>
        /// Atualiza uma conta
        /// </remarks>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>Task of ApiResponse (Conta)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conta>> UpdateUsingPUT1AsyncWithHttpInfo (Conta conta);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContaApi : IContaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContaApi(Configuration configuration = null)
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
        /// Cria uma conta Cria uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param> 
        /// <returns>Conta</returns>
        public Conta CreateUsingPOST1 (Conta conta)
        {
             ApiResponse<Conta> localVarResponse = CreateUsingPOST1WithHttpInfo(conta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cria uma conta Cria uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param> 
        /// <returns>ApiResponse of Conta</returns>
        public ApiResponse< Conta > CreateUsingPOST1WithHttpInfo (Conta conta)
        {
            
            // verify the required parameter 'conta' is set
            if (conta == null)
                throw new ApiException(400, "Missing required parameter 'conta' when calling ContaApi->CreateUsingPOST1");
            
    
            var localVarPath = "/v1/contas";
    
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
            
            
            
            
            if (conta.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(conta); // http body (model) parameter
            }
            else
            {
                localVarPostBody = conta; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CreateUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Conta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conta)));
            
        }

        
        /// <summary>
        /// Cria uma conta Cria uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>Task of Conta</returns>
        public async System.Threading.Tasks.Task<Conta> CreateUsingPOST1Async (Conta conta)
        {
             ApiResponse<Conta> localVarResponse = await CreateUsingPOST1AsyncWithHttpInfo(conta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cria uma conta Cria uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>Task of ApiResponse (Conta)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conta>> CreateUsingPOST1AsyncWithHttpInfo (Conta conta)
        {
            // verify the required parameter 'conta' is set
            if (conta == null) throw new ApiException(400, "Missing required parameter 'conta' when calling CreateUsingPOST1");
            
    
            var localVarPath = "/v1/contas";
    
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
            
            
            
            
            if (conta.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(conta); // http body (model) parameter
            }
            else
            {
                localVarPostBody = conta; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling CreateUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conta)));
            
        }
        
        /// <summary>
        /// Deleta uma conta Deleta uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>Response</returns>
        public Response DeleteUsingDELETE (long? id)
        {
             ApiResponse<Response> localVarResponse = DeleteUsingDELETEWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deleta uma conta Deleta uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > DeleteUsingDELETEWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->DeleteUsingDELETE");
            
    
            var localVarPath = "/v1/contas/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsingDELETE: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsingDELETE: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }

        
        /// <summary>
        /// Deleta uma conta Deleta uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> DeleteUsingDELETEAsync (long? id)
        {
             ApiResponse<Response> localVarResponse = await DeleteUsingDELETEAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deleta uma conta Deleta uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> DeleteUsingDELETEAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteUsingDELETE");
            
    
            var localVarPath = "/v1/contas/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsingDELETE: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUsingDELETE: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
            
        }
        
        /// <summary>
        /// Retorna todas as contas Retorna todas as contas
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Conta&gt;</returns>
        public List<Conta> GetAllUsingGET1 ()
        {
             ApiResponse<List<Conta>> localVarResponse = GetAllUsingGET1WithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna todas as contas Retorna todas as contas
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Conta&gt;</returns>
        public ApiResponse< List<Conta> > GetAllUsingGET1WithHttpInfo ()
        {
            
    
            var localVarPath = "/v1/contas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Conta>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Conta>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Conta>)));
            
        }

        
        /// <summary>
        /// Retorna todas as contas Retorna todas as contas
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Conta&gt;</returns>
        public async System.Threading.Tasks.Task<List<Conta>> GetAllUsingGET1Async ()
        {
             ApiResponse<List<Conta>> localVarResponse = await GetAllUsingGET1AsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna todas as contas Retorna todas as contas
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Conta&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Conta>>> GetAllUsingGET1AsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/v1/contas";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAllUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Conta>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Conta>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Conta>)));
            
        }
        
        /// <summary>
        /// Retorna uma conta Retorna uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>Conta</returns>
        public Conta GetOneUsingGET1 (long? id)
        {
             ApiResponse<Conta> localVarResponse = GetOneUsingGET1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna uma conta Retorna uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <returns>ApiResponse of Conta</returns>
        public ApiResponse< Conta > GetOneUsingGET1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ContaApi->GetOneUsingGET1");
            
    
            var localVarPath = "/v1/contas/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetOneUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOneUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Conta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conta)));
            
        }

        
        /// <summary>
        /// Retorna uma conta Retorna uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of Conta</returns>
        public async System.Threading.Tasks.Task<Conta> GetOneUsingGET1Async (long? id)
        {
             ApiResponse<Conta> localVarResponse = await GetOneUsingGET1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna uma conta Retorna uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>Task of ApiResponse (Conta)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conta>> GetOneUsingGET1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetOneUsingGET1");
            
    
            var localVarPath = "/v1/contas/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetOneUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOneUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conta)));
            
        }
        
        /// <summary>
        /// Atualiza uma conta Atualiza uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param> 
        /// <returns>Conta</returns>
        public Conta UpdateUsingPUT1 (Conta conta)
        {
             ApiResponse<Conta> localVarResponse = UpdateUsingPUT1WithHttpInfo(conta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza uma conta Atualiza uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param> 
        /// <returns>ApiResponse of Conta</returns>
        public ApiResponse< Conta > UpdateUsingPUT1WithHttpInfo (Conta conta)
        {
            
            // verify the required parameter 'conta' is set
            if (conta == null)
                throw new ApiException(400, "Missing required parameter 'conta' when calling ContaApi->UpdateUsingPUT1");
            
    
            var localVarPath = "/v1/contas";
    
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
            
            
            
            
            if (conta.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(conta); // http body (model) parameter
            }
            else
            {
                localVarPostBody = conta; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Conta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conta)));
            
        }

        
        /// <summary>
        /// Atualiza uma conta Atualiza uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>Task of Conta</returns>
        public async System.Threading.Tasks.Task<Conta> UpdateUsingPUT1Async (Conta conta)
        {
             ApiResponse<Conta> localVarResponse = await UpdateUsingPUT1AsyncWithHttpInfo(conta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza uma conta Atualiza uma conta
        /// </summary>
        /// <exception cref="Conductor.SDC.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conta">conta</param>
        /// <returns>Task of ApiResponse (Conta)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conta>> UpdateUsingPUT1AsyncWithHttpInfo (Conta conta)
        {
            // verify the required parameter 'conta' is set
            if (conta == null) throw new ApiException(400, "Missing required parameter 'conta' when calling UpdateUsingPUT1");
            
    
            var localVarPath = "/v1/contas";
    
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
            
            
            
            
            if (conta.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(conta); // http body (model) parameter
            }
            else
            {
                localVarPostBody = conta; // byte array
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conta>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conta) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conta)));
            
        }
        
    }
    
}
