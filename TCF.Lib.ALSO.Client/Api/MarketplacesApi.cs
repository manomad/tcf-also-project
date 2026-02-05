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
    public interface IMarketplacesApi
    {
        /// <summary>
        /// Creates new markeplace. Creates new marketplace
        /// </summary>
        /// <param name="body">Marketplace name. If no name is supplied, it is generated as My Marketplace YY-MM-DD HH:MM:SS</param>
        /// <returns>MarketplaceInfo</returns>
        MarketplaceInfo CreateMarketplace (CreateMarketplaceBody body);
        /// <summary>
        /// Deletes markeplace by providing markeplace ID. Deletes marketplace
        /// </summary>
        /// <param name="body">Marketplace ID</param>
        /// <returns></returns>
        void DeleteMarketplaces (DeleteMarketplaceBody body);
        /// <summary>
        /// Gets company owned marketplaces. Gets marketplaces
        /// </summary>
        /// <param name="body">An empty object.</param>
        /// <returns>List&lt;MarketplaceInfo&gt;</returns>
        List<MarketplaceInfo> GetMarketplaces (Object body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MarketplacesApi : IMarketplacesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MarketplacesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MarketplacesApi(String basePath)
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
        /// Creates new markeplace. Creates new marketplace
        /// </summary>
        /// <param name="body">Marketplace name. If no name is supplied, it is generated as My Marketplace YY-MM-DD HH:MM:SS</param>
        /// <returns>MarketplaceInfo</returns>
        public MarketplaceInfo CreateMarketplace (CreateMarketplaceBody body)
        {
    
            var path = "/CreateMarketplace";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateMarketplace: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateMarketplace: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MarketplaceInfo) ApiClient.Deserialize(response.Content, typeof(MarketplaceInfo), response.Headers);
        }
    
        /// <summary>
        /// Deletes markeplace by providing markeplace ID. Deletes marketplace
        /// </summary>
        /// <param name="body">Marketplace ID</param>
        /// <returns></returns>
        public void DeleteMarketplaces (DeleteMarketplaceBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteMarketplaces");
    
            var path = "/DeleteMarketplace";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMarketplaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMarketplaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets company owned marketplaces. Gets marketplaces
        /// </summary>
        /// <param name="body">An empty object.</param>
        /// <returns>List&lt;MarketplaceInfo&gt;</returns>
        public List<MarketplaceInfo> GetMarketplaces (Object body)
        {
    
            var path = "/GetMarketplaces";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketplaces: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMarketplaces: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MarketplaceInfo>) ApiClient.Deserialize(response.Content, typeof(List<MarketplaceInfo>), response.Headers);
        }
    
    }
}
