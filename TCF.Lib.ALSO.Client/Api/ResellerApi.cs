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
    public interface IResellerApi
    {
        /// <summary>
        /// Creates a Reseller. Creates a Reseller.
        /// </summary>
        /// <param name="body">The reseller account details that will be used to create the account.</param>
        /// <returns>Company</returns>
        Company CreateReseller (ResellerAccount body);
        /// <summary>
        /// Gets a reseller based on its Account ID. Gets a reseller based on the Account ID provided. If no account ID is provided, the current session user&#x27;s reseller Account ID is used.
        /// </summary>
        /// <param name="body">Account ID of the requested reseller. (This is an **optional** parameter. If no Account ID is provided, the current session user&#x27;s reseller Account ID is used.)</param>
        /// <returns>List&lt;Company&gt;</returns>
        List<Company> GetReseller (GetResellerRequest body);
        /// <summary>
        /// Gets a reseller based on its Vat ID. Gets a reseller based on the Vat ID provided.
        /// </summary>
        /// <param name="body">Vat ID</param>
        /// <returns>List&lt;Company&gt;</returns>
        List<Company> GetResellerByVatId (GetResellerByVatIdBody body);
        /// <summary>
        /// Lists resellers under specified parent Account ID. Lists reseller under specified parent Account ID. Only first level of reseller will be listed.
        /// </summary>
        /// <param name="body">Account ID of the parent.</param>
        /// <returns>List&lt;Company&gt;</returns>
        List<Company> GetResellers (GetResellersRequest body);
        /// <summary>
        /// Updates the reseller details. Updates the reseller details
        /// </summary>
        /// <param name="body">Reseller object containing data to be updated.</param>
        /// <returns></returns>
        void UpdateReseller (UpdateReseller body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ResellerApi : IResellerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ResellerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ResellerApi(String basePath)
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
        /// Creates a Reseller. Creates a Reseller.
        /// </summary>
        /// <param name="body">The reseller account details that will be used to create the account.</param>
        /// <returns>Company</returns>
        public Company CreateReseller (ResellerAccount body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateReseller");
    
            var path = "/CreateReseller";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateReseller: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateReseller: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Company) ApiClient.Deserialize(response.Content, typeof(Company), response.Headers);
        }
    
        /// <summary>
        /// Gets a reseller based on its Account ID. Gets a reseller based on the Account ID provided. If no account ID is provided, the current session user&#x27;s reseller Account ID is used.
        /// </summary>
        /// <param name="body">Account ID of the requested reseller. (This is an **optional** parameter. If no Account ID is provided, the current session user&#x27;s reseller Account ID is used.)</param>
        /// <returns>List&lt;Company&gt;</returns>
        public List<Company> GetReseller (GetResellerRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetReseller");
    
            var path = "/GetReseller";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReseller: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReseller: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Company>) ApiClient.Deserialize(response.Content, typeof(List<Company>), response.Headers);
        }
    
        /// <summary>
        /// Gets a reseller based on its Vat ID. Gets a reseller based on the Vat ID provided.
        /// </summary>
        /// <param name="body">Vat ID</param>
        /// <returns>List&lt;Company&gt;</returns>
        public List<Company> GetResellerByVatId (GetResellerByVatIdBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetResellerByVatId");
    
            var path = "/GetResellerByVatId";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetResellerByVatId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetResellerByVatId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Company>) ApiClient.Deserialize(response.Content, typeof(List<Company>), response.Headers);
        }
    
        /// <summary>
        /// Lists resellers under specified parent Account ID. Lists reseller under specified parent Account ID. Only first level of reseller will be listed.
        /// </summary>
        /// <param name="body">Account ID of the parent.</param>
        /// <returns>List&lt;Company&gt;</returns>
        public List<Company> GetResellers (GetResellersRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetResellers");
    
            var path = "/GetResellers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetResellers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetResellers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Company>) ApiClient.Deserialize(response.Content, typeof(List<Company>), response.Headers);
        }
    
        /// <summary>
        /// Updates the reseller details. Updates the reseller details
        /// </summary>
        /// <param name="body">Reseller object containing data to be updated.</param>
        /// <returns></returns>
        public void UpdateReseller (UpdateReseller body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateReseller");
    
            var path = "/UpdateReseller";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReseller: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReseller: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
