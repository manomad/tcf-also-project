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
    public interface ISubscriptionActionsApi
    {
        /// <summary>
        /// Executes specified custom action. Executes specific custom action with field values for product subscription account.
        /// </summary>
        /// <param name="body">Oobject of action name and subscription object (mandatory: AccountId ServiceName).</param>
        /// <returns></returns>
        void ExecuteAccountCustomAction (ExecuteAccountCustomActionRequest body);
        /// <summary>
        /// Gets subscription Custom Action list. Gets a list of available custom actions with all fields for given product subscription account.
        /// </summary>
        /// <param name="body">Subscription Account ID</param>
        /// <returns>List&lt;CustomActionDefinition&gt;</returns>
        List<CustomActionDefinition> GetAccountCustomActionsWithFields (GetAccountCustomActionsWithFieldsRequest body);
        /// <summary>
        /// Gets remote enum values for the field in custom action. Returns list of enum values that needs to be retrieved from service provider backend before executing **_/CreateSubscription** or **_/UpdateSubscription** 
        /// </summary>
        /// <param name="body">An object with remote enum request.</param>
        /// <returns>List&lt;AccountFieldValueItem&gt;</returns>
        List<AccountFieldValueItem> GetRemoteEnumValuesForCustomAction (GetRemoteEnumValuesForCustomActionBody body);
        /// <summary>
        /// Retries account latest failed provisioning request for given account. Retries latest failed provisioning for given account. The provisioning status of subscription can be resolved by **_/GetSubscription** method.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void RetryLastFailedProvisioning (RetryLastFailedProvisioningBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubscriptionActionsApi : ISubscriptionActionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionActionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionActionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionActionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionActionsApi(String basePath)
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
        /// Executes specified custom action. Executes specific custom action with field values for product subscription account.
        /// </summary>
        /// <param name="body">Oobject of action name and subscription object (mandatory: AccountId ServiceName).</param>
        /// <returns></returns>
        public void ExecuteAccountCustomAction (ExecuteAccountCustomActionRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ExecuteAccountCustomAction");
    
            var path = "/ExecuteAccountCustomAction";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ExecuteAccountCustomAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExecuteAccountCustomAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets subscription Custom Action list. Gets a list of available custom actions with all fields for given product subscription account.
        /// </summary>
        /// <param name="body">Subscription Account ID</param>
        /// <returns>List&lt;CustomActionDefinition&gt;</returns>
        public List<CustomActionDefinition> GetAccountCustomActionsWithFields (GetAccountCustomActionsWithFieldsRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetAccountCustomActionsWithFields");
    
            var path = "/GetAccountCustomActionsWithFields";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountCustomActionsWithFields: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountCustomActionsWithFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<CustomActionDefinition>) ApiClient.Deserialize(response.Content, typeof(List<CustomActionDefinition>), response.Headers);
        }
    
        /// <summary>
        /// Gets remote enum values for the field in custom action. Returns list of enum values that needs to be retrieved from service provider backend before executing **_/CreateSubscription** or **_/UpdateSubscription** 
        /// </summary>
        /// <param name="body">An object with remote enum request.</param>
        /// <returns>List&lt;AccountFieldValueItem&gt;</returns>
        public List<AccountFieldValueItem> GetRemoteEnumValuesForCustomAction (GetRemoteEnumValuesForCustomActionBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetRemoteEnumValuesForCustomAction");
    
            var path = "/GetRemoteEnumValuesForCustomAction";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRemoteEnumValuesForCustomAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRemoteEnumValuesForCustomAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountFieldValueItem>) ApiClient.Deserialize(response.Content, typeof(List<AccountFieldValueItem>), response.Headers);
        }
    
        /// <summary>
        /// Retries account latest failed provisioning request for given account. Retries latest failed provisioning for given account. The provisioning status of subscription can be resolved by **_/GetSubscription** method.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public void RetryLastFailedProvisioning (RetryLastFailedProvisioningBody body)
        {
    
            var path = "/RetryLastFailedProvisioning";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RetryLastFailedProvisioning: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RetryLastFailedProvisioning: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
