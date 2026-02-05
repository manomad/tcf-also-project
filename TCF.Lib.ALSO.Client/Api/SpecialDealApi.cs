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
    public interface ISpecialDealApi
    {
        /// <summary>
        /// Deletes special deal discounts for the given account and charge stream. Deletes special deal discounts for the given account that belong to the provided charge stream.
        /// </summary>
        /// <param name="body">AccountId and ChargeStreamId</param>
        /// <returns></returns>
        void DeleteSpecialDeal (DeleteSpecialDealBody body);
        /// <summary>
        /// Gets special deal discounts for the given account. Gets special deal discounts for the given account.
        /// </summary>
        /// <param name="body">AccountId</param>
        /// <returns>List&lt;SimpleSpecialDealResponse&gt;</returns>
        List<SimpleSpecialDealResponse> GetSpecialDeal (GetSpecialDealBody body);
        /// <summary>
        /// Creates a special deal discount for the given account and charge stream. Creates a special deal discount for the given account
        /// </summary>
        /// <param name="body">**ChargestreamId** can be taken from GetSpecialDeal. **PricableItemId** can be retrieved form GetSubscription endpoint.    If **IsCustomCharge** is false, the **Discount** (%) is applied to all discount items and CustomCharge is ignored. If **IsCustomCharge** is true, the **CustomCharge** amount is applied to all discount items and the Discount property is ignored.    **EffectiveEndDate** Always set to first date of the month (previous month will be applied)</param>
        /// <returns>SimpleSpecialDealResponse</returns>
        SimpleSpecialDealResponse SetSpecialDeal (SetSpecialDealBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SpecialDealApi : ISpecialDealApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialDealApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SpecialDealApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialDealApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SpecialDealApi(String basePath)
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
        /// Deletes special deal discounts for the given account and charge stream. Deletes special deal discounts for the given account that belong to the provided charge stream.
        /// </summary>
        /// <param name="body">AccountId and ChargeStreamId</param>
        /// <returns></returns>
        public void DeleteSpecialDeal (DeleteSpecialDealBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteSpecialDeal");
    
            var path = "/DeleteSpecialDeal";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSpecialDeal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSpecialDeal: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets special deal discounts for the given account. Gets special deal discounts for the given account.
        /// </summary>
        /// <param name="body">AccountId</param>
        /// <returns>List&lt;SimpleSpecialDealResponse&gt;</returns>
        public List<SimpleSpecialDealResponse> GetSpecialDeal (GetSpecialDealBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetSpecialDeal");
    
            var path = "/GetSpecialDeal";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSpecialDeal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSpecialDeal: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SimpleSpecialDealResponse>) ApiClient.Deserialize(response.Content, typeof(List<SimpleSpecialDealResponse>), response.Headers);
        }
    
        /// <summary>
        /// Creates a special deal discount for the given account and charge stream. Creates a special deal discount for the given account
        /// </summary>
        /// <param name="body">**ChargestreamId** can be taken from GetSpecialDeal. **PricableItemId** can be retrieved form GetSubscription endpoint.    If **IsCustomCharge** is false, the **Discount** (%) is applied to all discount items and CustomCharge is ignored. If **IsCustomCharge** is true, the **CustomCharge** amount is applied to all discount items and the Discount property is ignored.    **EffectiveEndDate** Always set to first date of the month (previous month will be applied)</param>
        /// <returns>SimpleSpecialDealResponse</returns>
        public SimpleSpecialDealResponse SetSpecialDeal (SetSpecialDealBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SetSpecialDeal");
    
            var path = "/SetSpecialDeal";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetSpecialDeal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetSpecialDeal: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SimpleSpecialDealResponse) ApiClient.Deserialize(response.Content, typeof(SimpleSpecialDealResponse), response.Headers);
        }
    
    }
}
