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
    public interface ISubscriptionManagementApi
    {
        /// <summary>
        /// Creates a subscription. Creates a subscription under selected parent (Company, User, Reseller, Service). You need to specify the parent Account ID.
        /// </summary>
        /// <param name="body">An object of the subscription account details.</param>
        /// <returns>Subscription</returns>
        Subscription CreateSubscription (CreateSubscription body);
        /// <summary>
        /// Gets list of fields of a service for subscription creation. Gets list of fields (with drop-down values and default values) for the service if subcritpion needs to be created under specified parent.
        /// </summary>
        /// <param name="body">An object containing the data used to return the requested fields.</param>
        /// <returns>SubscriptionInputDefinition</returns>
        SubscriptionInputDefinition GetFieldsForService (GetFieldsForServiceRequest body);
        /// <summary>
        /// Get all Services to which specified parent can be subscribed to. Get all Services which can be added under the specified account
        /// </summary>
        /// <param name="body">Parent Account ID.</param>
        /// <returns>List&lt;SimpleProductInfo&gt;</returns>
        List<SimpleProductInfo> GetPossibleServicesForParent (GetPossibleServicesForParentRequest body);
        /// <summary>
        /// Gets remote enum values for the field. Returns list of enum values that needs to be retrieved from service provider backend before executing **_/CreateSubscription** or **_/UpdateSubscription** 
        /// </summary>
        /// <param name="body">An object with remote enum request. AccountViewName should always start with Product_</param>
        /// <returns>List&lt;AccountFieldValueItem&gt;</returns>
        List<AccountFieldValueItem> GetRemoteEnums (GetRemoteEnumsRequest body);
        /// <summary>
        /// Updates a service subscription. Updates a service subscription.
        /// </summary>
        /// <param name="body">Object of the subscription to be updated.</param>
        /// <returns></returns>
        void Updatesubscription (UpdateSubscription body);
        /// <summary>
        /// Validates a subscription. Validates object before creating subscription. You need to specify the parent Account ID. If AccounID is provided with object then validation happens for update action.
        /// </summary>
        /// <param name="body">An object of the subscription account details.</param>
        /// <returns>ValidationResult</returns>
        ValidationResult ValidateFields (ValidateFields body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubscriptionManagementApi : ISubscriptionManagementApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionManagementApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionManagementApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionManagementApi(String basePath)
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
        /// Creates a subscription. Creates a subscription under selected parent (Company, User, Reseller, Service). You need to specify the parent Account ID.
        /// </summary>
        /// <param name="body">An object of the subscription account details.</param>
        /// <returns>Subscription</returns>
        public Subscription CreateSubscription (CreateSubscription body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateSubscription");
    
            var path = "/CreateSubscription";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
        /// <summary>
        /// Gets list of fields of a service for subscription creation. Gets list of fields (with drop-down values and default values) for the service if subcritpion needs to be created under specified parent.
        /// </summary>
        /// <param name="body">An object containing the data used to return the requested fields.</param>
        /// <returns>SubscriptionInputDefinition</returns>
        public SubscriptionInputDefinition GetFieldsForService (GetFieldsForServiceRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetFieldsForService");
    
            var path = "/GetFieldsForService";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFieldsForService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFieldsForService: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SubscriptionInputDefinition) ApiClient.Deserialize(response.Content, typeof(SubscriptionInputDefinition), response.Headers);
        }
    
        /// <summary>
        /// Get all Services to which specified parent can be subscribed to. Get all Services which can be added under the specified account
        /// </summary>
        /// <param name="body">Parent Account ID.</param>
        /// <returns>List&lt;SimpleProductInfo&gt;</returns>
        public List<SimpleProductInfo> GetPossibleServicesForParent (GetPossibleServicesForParentRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetPossibleServicesForParent");
    
            var path = "/GetPossibleServicesForParent";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPossibleServicesForParent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPossibleServicesForParent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SimpleProductInfo>) ApiClient.Deserialize(response.Content, typeof(List<SimpleProductInfo>), response.Headers);
        }
    
        /// <summary>
        /// Gets remote enum values for the field. Returns list of enum values that needs to be retrieved from service provider backend before executing **_/CreateSubscription** or **_/UpdateSubscription** 
        /// </summary>
        /// <param name="body">An object with remote enum request. AccountViewName should always start with Product_</param>
        /// <returns>List&lt;AccountFieldValueItem&gt;</returns>
        public List<AccountFieldValueItem> GetRemoteEnums (GetRemoteEnumsRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetRemoteEnums");
    
            var path = "/GetRemoteEnums";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRemoteEnums: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRemoteEnums: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountFieldValueItem>) ApiClient.Deserialize(response.Content, typeof(List<AccountFieldValueItem>), response.Headers);
        }
    
        /// <summary>
        /// Updates a service subscription. Updates a service subscription.
        /// </summary>
        /// <param name="body">Object of the subscription to be updated.</param>
        /// <returns></returns>
        public void Updatesubscription (UpdateSubscription body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Updatesubscription");
    
            var path = "/UpdateSubscription";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Updatesubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Updatesubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Validates a subscription. Validates object before creating subscription. You need to specify the parent Account ID. If AccounID is provided with object then validation happens for update action.
        /// </summary>
        /// <param name="body">An object of the subscription account details.</param>
        /// <returns>ValidationResult</returns>
        public ValidationResult ValidateFields (ValidateFields body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ValidateFields");
    
            var path = "/ValidateFields";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ValidateFields: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ValidateFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ValidationResult) ApiClient.Deserialize(response.Content, typeof(ValidationResult), response.Headers);
        }
    
    }
}
