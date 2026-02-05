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
    public interface ISecurityApi
    {
        /// <summary>
        /// Gets security roles for company\\reseller account. 
        /// </summary>
        /// <param name="body">Company\\Reseller account id (optional)</param>
        /// <returns>List&lt;SimpleRole&gt;</returns>
        List<SimpleRole> GetSecurityRoles (GetSecurityRolesBody body);
        /// <summary>
        /// Gets security roles for company\\reseller account. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>SimpleRole</returns>
        SimpleRole UpdateSecurityRolesUsers (SimpleUpdateRoleUsers body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SecurityApi : ISecurityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SecurityApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecurityApi(String basePath)
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
        /// Gets security roles for company\\reseller account. 
        /// </summary>
        /// <param name="body">Company\\Reseller account id (optional)</param>
        /// <returns>List&lt;SimpleRole&gt;</returns>
        public List<SimpleRole> GetSecurityRoles (GetSecurityRolesBody body)
        {
    
            var path = "/GetSecurityRoles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSecurityRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSecurityRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SimpleRole>) ApiClient.Deserialize(response.Content, typeof(List<SimpleRole>), response.Headers);
        }
    
        /// <summary>
        /// Gets security roles for company\\reseller account. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>SimpleRole</returns>
        public SimpleRole UpdateSecurityRolesUsers (SimpleUpdateRoleUsers body)
        {
    
            var path = "/UpdateSecurityRolesUsers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSecurityRolesUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSecurityRolesUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SimpleRole) ApiClient.Deserialize(response.Content, typeof(SimpleRole), response.Headers);
        }
    
    }
}
