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
    public interface IUserApi
    {
        /// <summary>
        /// Creates a user under selected Parent. Creates a user under selected Parent (Customer or Reseller) Account ID.
        /// </summary>
        /// <param name="body">An object containing the details of the user to be created.</param>
        /// <returns>User</returns>
        User Createuser (CreateUserRequest body);
        /// <summary>
        /// Gets a user based on its Account ID. Get user information based on the Account ID provided. **Account ID is optional** - If no Account ID is provided, the current session’s user Account ID is used.
        /// </summary>
        /// <param name="body">Account ID of the desired user (**Account ID is optional** - If no Account ID is provided, the current session’s user Account ID is used)</param>
        /// <returns>User</returns>
        User Getuser (GetUserBody body);
        /// <summary>
        /// Gets all users under the specified companieds Account ID. Gets all users under the specified company&#x27;s Account ID.
        /// </summary>
        /// <param name="body">An object of the company&#x27;s Account ID.</param>
        /// <returns>Users</returns>
        Users Getusers (GetUsersRequest body);
        /// <summary>
        /// Updates the user settings. Updates the user settings. Even if you aren&#x27;t updating the firtsname or lastname those parameters need to be provided always. The Account ID specifies which user should be modified.
        /// </summary>
        /// <param name="body">An object of the user data to be updated.</param>
        /// <returns></returns>
        void Updateuser (UpdateUser body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
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
        /// Creates a user under selected Parent. Creates a user under selected Parent (Customer or Reseller) Account ID.
        /// </summary>
        /// <param name="body">An object containing the details of the user to be created.</param>
        /// <returns>User</returns>
        public User Createuser (CreateUserRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Createuser");
    
            var path = "/CreateUser";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Createuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Createuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
    
        /// <summary>
        /// Gets a user based on its Account ID. Get user information based on the Account ID provided. **Account ID is optional** - If no Account ID is provided, the current session’s user Account ID is used.
        /// </summary>
        /// <param name="body">Account ID of the desired user (**Account ID is optional** - If no Account ID is provided, the current session’s user Account ID is used)</param>
        /// <returns>User</returns>
        public User Getuser (GetUserBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Getuser");
    
            var path = "/GetUser";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Getuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
    
        /// <summary>
        /// Gets all users under the specified companieds Account ID. Gets all users under the specified company&#x27;s Account ID.
        /// </summary>
        /// <param name="body">An object of the company&#x27;s Account ID.</param>
        /// <returns>Users</returns>
        public Users Getusers (GetUsersRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Getusers");
    
            var path = "/GetUsers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Getusers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getusers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Users) ApiClient.Deserialize(response.Content, typeof(Users), response.Headers);
        }
    
        /// <summary>
        /// Updates the user settings. Updates the user settings. Even if you aren&#x27;t updating the firtsname or lastname those parameters need to be provided always. The Account ID specifies which user should be modified.
        /// </summary>
        /// <param name="body">An object of the user data to be updated.</param>
        /// <returns></returns>
        public void Updateuser (UpdateUser body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Updateuser");
    
            var path = "/UpdateUser";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Updateuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Updateuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
