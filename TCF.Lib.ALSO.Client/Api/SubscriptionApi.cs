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
    public interface ISubscriptionApi
    {
        /// <summary>
        /// Getting the subscription by Account ID. Getting the subscription by Account ID.
        /// </summary>
        /// <param name="body">An object of Account ID and reseller context.</param>
        /// <returns>Subscription</returns>
        Subscription Getsubscription (GetSubscriptionRequest body);
        /// <summary>
        /// Getting all subscription dependency accounts for provided Account ID. Getting all subscription dependency accounts for provided Account ID.
        /// </summary>
        /// <param name="body">An object of parent Account ID and reseller context (optional).</param>
        /// <returns>List&lt;Subscription&gt;</returns>
        List<Subscription> Getsubscriptiondependencies (GetSubscriptionDependenciesRequest body);
        /// <summary>
        /// Getting all Subscriptions under Account ID. Gets all subscriptions under the specified company&#x27;s Account ID.
        /// </summary>
        /// <param name="body">An object of parent Account ID and reseller context.</param>
        /// <returns>List&lt;Subscription&gt;</returns>
        List<Subscription> Getsubscriptions (GetSubscriptionsRequest body);
        /// <summary>
        /// Getting the subscription by Account ID with it&#x27;s addons. Getting the subscription by Account ID with it&#x27;s addons.
        /// </summary>
        /// <param name="body">An object of Account ID and reseller context.</param>
        /// <returns>Subscription</returns>
        Subscription Getsubscriptionwithaddons (GetSubscriptionRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubscriptionApi : ISubscriptionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionApi(String basePath)
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
        /// Getting the subscription by Account ID. Getting the subscription by Account ID.
        /// </summary>
        /// <param name="body">An object of Account ID and reseller context.</param>
        /// <returns>Subscription</returns>
        public Subscription Getsubscription (GetSubscriptionRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Getsubscription");
    
            var path = "/GetSubscription";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Getsubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getsubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
        /// <summary>
        /// Getting all subscription dependency accounts for provided Account ID. Getting all subscription dependency accounts for provided Account ID.
        /// </summary>
        /// <param name="body">An object of parent Account ID and reseller context (optional).</param>
        /// <returns>List&lt;Subscription&gt;</returns>
        public List<Subscription> Getsubscriptiondependencies (GetSubscriptionDependenciesRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Getsubscriptiondependencies");
    
            var path = "/GetSubscriptionDependencies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Getsubscriptiondependencies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getsubscriptiondependencies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Subscription>) ApiClient.Deserialize(response.Content, typeof(List<Subscription>), response.Headers);
        }
    
        /// <summary>
        /// Getting all Subscriptions under Account ID. Gets all subscriptions under the specified company&#x27;s Account ID.
        /// </summary>
        /// <param name="body">An object of parent Account ID and reseller context.</param>
        /// <returns>List&lt;Subscription&gt;</returns>
        public List<Subscription> Getsubscriptions (GetSubscriptionsRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Getsubscriptions");
    
            var path = "/GetSubscriptions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Getsubscriptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getsubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Subscription>) ApiClient.Deserialize(response.Content, typeof(List<Subscription>), response.Headers);
        }
    
        /// <summary>
        /// Getting the subscription by Account ID with it&#x27;s addons. Getting the subscription by Account ID with it&#x27;s addons.
        /// </summary>
        /// <param name="body">An object of Account ID and reseller context.</param>
        /// <returns>Subscription</returns>
        public Subscription Getsubscriptionwithaddons (GetSubscriptionRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Getsubscriptionwithaddons");
    
            var path = "/GetSubscriptionWithAddons";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Getsubscriptionwithaddons: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getsubscriptionwithaddons: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
    }
}
