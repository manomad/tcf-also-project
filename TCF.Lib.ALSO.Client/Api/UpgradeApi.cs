using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUpgradeApi
    {
        /// <summary>
        /// Executes upgrade action for specified account. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>string</returns>
        string Executeproductupgrade (ExecuteProductUpgradeRequest body);
        /// <summary>
        /// Gets possible fields for upgrade for specified account. 
        /// </summary>
        /// <param name="body">Account ID of the service that upgrade is required and technical product name of destination account</param>
        /// <returns>PossibleUpgradeRenewFields</returns>
        PossibleUpgradeRenewFields Getpossiblefieldsforupgrade (GetProductFieldsForUpgradeRequest body);
        /// <summary>
        /// Gets possible services for upgrade specified account. 
        /// </summary>
        /// <param name="body">Account ID of the service that upgrade is required</param>
        /// <returns>PossibleUpgradeServices</returns>
        PossibleUpgradeServices Getpossibleproductsforupgrade (GetPossibleServicesForUpgradeRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UpgradeApi : IUpgradeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UpgradeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UpgradeApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Executes upgrade action for specified account. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>string</returns>
        public string Executeproductupgrade (ExecuteProductUpgradeRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Executeproductupgrade");
    
            var path = "/ExecuteSubscriptionUpgrade";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Executeproductupgrade: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Executeproductupgrade: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Gets possible fields for upgrade for specified account. 
        /// </summary>
        /// <param name="body">Account ID of the service that upgrade is required and technical product name of destination account</param>
        /// <returns>PossibleUpgradeRenewFields</returns>
        public PossibleUpgradeRenewFields Getpossiblefieldsforupgrade (GetProductFieldsForUpgradeRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Getpossiblefieldsforupgrade");
    
            var path = "/GetSubscriptionFieldsForUpgrade";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Getpossiblefieldsforupgrade: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getpossiblefieldsforupgrade: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PossibleUpgradeRenewFields) ApiClient.Deserialize(response.Content, typeof(PossibleUpgradeRenewFields), response.Headers);
        }
    
        /// <summary>
        /// Gets possible services for upgrade specified account. 
        /// </summary>
        /// <param name="body">Account ID of the service that upgrade is required</param>
        /// <returns>PossibleUpgradeServices</returns>
        public PossibleUpgradeServices Getpossibleproductsforupgrade (GetPossibleServicesForUpgradeRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Getpossibleproductsforupgrade");
    
            var path = "/GetPossibleServicesForUpgrade";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Getpossibleproductsforupgrade: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getpossibleproductsforupgrade: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PossibleUpgradeServices) ApiClient.Deserialize(response.Content, typeof(PossibleUpgradeServices), response.Headers);
        }
    
    }
}
