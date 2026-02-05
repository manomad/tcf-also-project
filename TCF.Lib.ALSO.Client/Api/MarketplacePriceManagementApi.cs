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
    public interface IMarketplacePriceManagementApi
    {
        /// <summary>
        /// Gets marketplace service charges. Gets marketplace services and current prices that are set for services
        /// </summary>
        /// <param name="body">Marketplace ID</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        List<MarketplaceServiceInfo> GetMarketplaceServiceCharges (GetMarketplaceServiceChargesBody body);
        /// <summary>
        /// Updates marketplace service charges. Updates marketplace service Custom prices
        /// </summary>
        /// <param name="body">An object of marketplace ID and object of marketplace service info.</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        List<MarketplaceServiceInfo> UpdateMarketplaceServiceCharges (UpdateMarketplaceServiceChargesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MarketplacePriceManagementApi : IMarketplacePriceManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePriceManagementApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MarketplacePriceManagementApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePriceManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MarketplacePriceManagementApi(String basePath)
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
        /// Gets marketplace service charges. Gets marketplace services and current prices that are set for services
        /// </summary>
        /// <param name="body">Marketplace ID</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        public List<MarketplaceServiceInfo> GetMarketplaceServiceCharges (GetMarketplaceServiceChargesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetMarketplaceServiceCharges");
    
            var path = "/GetMarketplaceServiceCharges";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "UserSecurity" };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketplaceServiceCharges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketplaceServiceCharges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MarketplaceServiceInfo>) ApiClient.Deserialize(response.Content, typeof(List<MarketplaceServiceInfo>), response.Headers);
        }
    
        /// <summary>
        /// Updates marketplace service charges. Updates marketplace service Custom prices
        /// </summary>
        /// <param name="body">An object of marketplace ID and object of marketplace service info.</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        public List<MarketplaceServiceInfo> UpdateMarketplaceServiceCharges (UpdateMarketplaceServiceChargesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMarketplaceServiceCharges");
    
            var path = "/UpdateMarketplaceServiceCharges";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "UserSecurity" };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMarketplaceServiceCharges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMarketplaceServiceCharges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MarketplaceServiceInfo>) ApiClient.Deserialize(response.Content, typeof(List<MarketplaceServiceInfo>), response.Headers);
        }
    
    }
}
