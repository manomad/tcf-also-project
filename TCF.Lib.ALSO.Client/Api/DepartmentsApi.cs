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
    public interface IDepartmentsApi
    {
        /// <summary>
        /// Creates a department. Creates a department under specified parent id
        /// </summary>
        /// <param name="body">Supply deparment fields to create. If address fields are not specified, they are taken from the parent</param>
        /// <returns>Departments</returns>
        Departments CreateDepartment (CreateDepartmentBody body);
        /// <summary>
        /// Gets department object by its Account ID. Lists departments under specified parent Account ID
        /// </summary>
        /// <param name="body">Account ID of the department.</param>
        /// <returns>Departments</returns>
        Departments GetDepartment (GetDepartmentRequest body);
        /// <summary>
        /// Lists departments under specified parent Account ID. Lists departments under specified parent Account ID. Only first level of departments will be listed.
        /// </summary>
        /// <param name="body">Account ID of the parent.</param>
        /// <returns>List&lt;Departments&gt;</returns>
        List<Departments> GetDepartments (GetCompaniesRequest body);
        /// <summary>
        /// Updates a department. Updates a department
        /// </summary>
        /// <param name="body">Supply department fields to update. At least one field other than accountId must be supplied.</param>
        /// <returns></returns>
        void UpdateDepartment (UpdateDepartmentBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DepartmentsApi : IDepartmentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DepartmentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DepartmentsApi(String basePath)
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
        /// Creates a department. Creates a department under specified parent id
        /// </summary>
        /// <param name="body">Supply deparment fields to create. If address fields are not specified, they are taken from the parent</param>
        /// <returns>Departments</returns>
        public Departments CreateDepartment (CreateDepartmentBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateDepartment");
    
            var path = "/CreateDepartment";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDepartment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDepartment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Departments) ApiClient.Deserialize(response.Content, typeof(Departments), response.Headers);
        }
    
        /// <summary>
        /// Gets department object by its Account ID. Lists departments under specified parent Account ID
        /// </summary>
        /// <param name="body">Account ID of the department.</param>
        /// <returns>Departments</returns>
        public Departments GetDepartment (GetDepartmentRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetDepartment");
    
            var path = "/GetDepartment";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDepartment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDepartment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Departments) ApiClient.Deserialize(response.Content, typeof(Departments), response.Headers);
        }
    
        /// <summary>
        /// Lists departments under specified parent Account ID. Lists departments under specified parent Account ID. Only first level of departments will be listed.
        /// </summary>
        /// <param name="body">Account ID of the parent.</param>
        /// <returns>List&lt;Departments&gt;</returns>
        public List<Departments> GetDepartments (GetCompaniesRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetDepartments");
    
            var path = "/GetDepartments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDepartments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDepartments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Departments>) ApiClient.Deserialize(response.Content, typeof(List<Departments>), response.Headers);
        }
    
        /// <summary>
        /// Updates a department. Updates a department
        /// </summary>
        /// <param name="body">Supply department fields to update. At least one field other than accountId must be supplied.</param>
        /// <returns></returns>
        public void UpdateDepartment (UpdateDepartmentBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateDepartment");
    
            var path = "/UpdateDepartment";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDepartment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDepartment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
