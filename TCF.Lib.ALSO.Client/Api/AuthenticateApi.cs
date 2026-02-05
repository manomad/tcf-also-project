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
    public interface IAuthenticateApi
    {
        /// <summary>
        /// Returns a session token. &lt;div&gt; &lt;p&gt;&lt;strong&gt;Functional Description:&lt;/strong&gt;&lt;/p&gt; &lt;p&gt;Returns a session token. Authentication is sessions based. Note that &lt;i&gt;for other API calls&lt;/i&gt;, the requester must provide a valid session token in the Authenticate field of each request (see example above).&lt;/p&gt; &lt;p&gt;A session has access to the same resources and capabilities as the given user.&lt;/p&gt; &lt;p&gt;MFA users are not supported. If you want to use some user for authentication, consider disabling MFA for this user. Individual user exceptions can be found under Company-&gt;Security-&gt;Enforced Multi-Factor Authentication&lt;/p&gt; &lt;/div&gt;
        /// </summary>
        /// <param name="body">Username and password with rights to login to Marketplace.</param>
        /// <returns>string</returns>
        string GetSessionTokenPost (AuthenticateRequest body);
        /// <summary>
        /// Validates a session. Validates a session. Returns nothing, if session is still active. Returns exception if the session expired. Json body should be empty.
        /// </summary>
        /// <param name="body">An empty object.</param>
        /// <returns></returns>
        void Pingpong (Object body);
        /// <summary>
        /// Ends the session of the token. &lt;div&gt; &lt;p&gt;&lt;strong&gt;Functional Description:&lt;/strong&gt;&lt;/p&gt; &lt;p&gt;Ends the session linked to the given session token&lt;/p&gt; &lt;/div&gt;
        /// </summary>
        /// <returns></returns>
        void TerminateSessionTokenPost ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthenticateApi : IAuthenticateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthenticateApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticateApi(String basePath)
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
        /// Returns a session token. &lt;div&gt; &lt;p&gt;&lt;strong&gt;Functional Description:&lt;/strong&gt;&lt;/p&gt; &lt;p&gt;Returns a session token. Authentication is sessions based. Note that &lt;i&gt;for other API calls&lt;/i&gt;, the requester must provide a valid session token in the Authenticate field of each request (see example above).&lt;/p&gt; &lt;p&gt;A session has access to the same resources and capabilities as the given user.&lt;/p&gt; &lt;p&gt;MFA users are not supported. If you want to use some user for authentication, consider disabling MFA for this user. Individual user exceptions can be found under Company-&gt;Security-&gt;Enforced Multi-Factor Authentication&lt;/p&gt; &lt;/div&gt;
        /// </summary>
        /// <param name="body">Username and password with rights to login to Marketplace.</param>
        /// <returns>string</returns>
        public string GetSessionTokenPost (AuthenticateRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetSessionTokenPost");
    
            var path = "/GetSessionToken";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSessionTokenPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSessionTokenPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Validates a session. Validates a session. Returns nothing, if session is still active. Returns exception if the session expired. Json body should be empty.
        /// </summary>
        /// <param name="body">An empty object.</param>
        /// <returns></returns>
        public void Pingpong (Object body)
        {
    
            var path = "/PingPong";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Pingpong: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Pingpong: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Ends the session of the token. &lt;div&gt; &lt;p&gt;&lt;strong&gt;Functional Description:&lt;/strong&gt;&lt;/p&gt; &lt;p&gt;Ends the session linked to the given session token&lt;/p&gt; &lt;/div&gt;
        /// </summary>
        /// <returns></returns>
        public void TerminateSessionTokenPost ()
        {
    
            var path = "/TerminateSessionToken";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "UserSecurity" };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TerminateSessionTokenPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TerminateSessionTokenPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
