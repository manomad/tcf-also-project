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
    public interface IRenewApi
    {
        /// <summary>
        /// Configures renew field values for particular account. These values will be used when Renew happens at the subscription end date. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void Executeproductrenew (ConfigureSubscriptionRenewRequest body);
        /// <summary>
        /// Gets possible fields for renew view of specified account. 
        /// </summary>
        /// <param name="body">Account ID of the service for renew to configure</param>
        /// <returns>PossibleUpgradeRenewFields</returns>
        PossibleUpgradeRenewFields Getpossiblefieldsforrenew (GetSubscriptionFieldsForRenewRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RenewApi : IRenewApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RenewApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RenewApi(String basePath)
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
        /// Configures renew field values for particular account. These values will be used when Renew happens at the subscription end date. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public void Executeproductrenew (ConfigureSubscriptionRenewRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Executeproductrenew");
    
            var path = "/ConfigureSubscriptionRenew";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Executeproductrenew: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Executeproductrenew: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets possible fields for renew view of specified account. 
        /// </summary>
        /// <param name="body">Account ID of the service for renew to configure</param>
        /// <returns>PossibleUpgradeRenewFields</returns>
        public PossibleUpgradeRenewFields Getpossiblefieldsforrenew (GetSubscriptionFieldsForRenewRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Getpossiblefieldsforrenew");
    
            var path = "/GetSubscriptionFieldsForRenew";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Getpossiblefieldsforrenew: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getpossiblefieldsforrenew: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PossibleUpgradeRenewFields) ApiClient.Deserialize(response.Content, typeof(PossibleUpgradeRenewFields), response.Headers);
        }
    
    }
}
