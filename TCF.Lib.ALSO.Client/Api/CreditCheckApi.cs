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
    public interface ICreditCheckApi
    {
        /// <summary>
        /// Approves provided credit check order. Approves provided credit check order
        /// </summary>
        /// <param name="body">A credit object.</param>
        /// <returns></returns>
        void ApproveCreditCheckOrder (CreditCheckInfo body);
        /// <summary>
        /// Declines provided credit check order. Declines provided credit check order
        /// </summary>
        /// <param name="body">A credit object.</param>
        /// <returns></returns>
        void DeclineCreditCheckOrder (CreditCheckInfo body);
        /// <summary>
        /// Gets credit limit for company. Gets credit limit for company
        /// </summary>
        /// <param name="body">Company account id</param>
        /// <returns>SimpleCreditLimitRecord</returns>
        SimpleCreditLimitRecord GetCreditLimit (GetCreditLimitBody body);
        /// <summary>
        /// Gets a list of all credit check orders for approval. Gets a list of all credit check orders for approval
        /// </summary>
        /// <param name="body">An empty object.</param>
        /// <returns>List&lt;CreditCheckInfo&gt;</returns>
        List<CreditCheckInfo> ListCreditCheckOrdersForApproval (Object body);
        /// <summary>
        /// Sets credit limit for company. Sets credit Limit for company. If the limit is empty, credit limit will no longer be verified.
        /// </summary>
        /// <param name="body">An object containing the data used to set the credit limit.</param>
        /// <returns></returns>
        void SetCreditLimit (SetCreditLimitRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CreditCheckApi : ICreditCheckApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCheckApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CreditCheckApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCheckApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CreditCheckApi(String basePath)
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
        /// Approves provided credit check order. Approves provided credit check order
        /// </summary>
        /// <param name="body">A credit object.</param>
        /// <returns></returns>
        public void ApproveCreditCheckOrder (CreditCheckInfo body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ApproveCreditCheckOrder");
    
            var path = "/ApproveCreditCheckOrder";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApproveCreditCheckOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApproveCreditCheckOrder: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Declines provided credit check order. Declines provided credit check order
        /// </summary>
        /// <param name="body">A credit object.</param>
        /// <returns></returns>
        public void DeclineCreditCheckOrder (CreditCheckInfo body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeclineCreditCheckOrder");
    
            var path = "/DeclineCreditCheckOrder";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeclineCreditCheckOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeclineCreditCheckOrder: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets credit limit for company. Gets credit limit for company
        /// </summary>
        /// <param name="body">Company account id</param>
        /// <returns>SimpleCreditLimitRecord</returns>
        public SimpleCreditLimitRecord GetCreditLimit (GetCreditLimitBody body)
        {
    
            var path = "/GetCreditLimit";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreditLimit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCreditLimit: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SimpleCreditLimitRecord) ApiClient.Deserialize(response.Content, typeof(SimpleCreditLimitRecord), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of all credit check orders for approval. Gets a list of all credit check orders for approval
        /// </summary>
        /// <param name="body">An empty object.</param>
        /// <returns>List&lt;CreditCheckInfo&gt;</returns>
        public List<CreditCheckInfo> ListCreditCheckOrdersForApproval (Object body)
        {
    
            var path = "/ListCreditCheckOrdersForApproval";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListCreditCheckOrdersForApproval: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListCreditCheckOrdersForApproval: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<CreditCheckInfo>) ApiClient.Deserialize(response.Content, typeof(List<CreditCheckInfo>), response.Headers);
        }
    
        /// <summary>
        /// Sets credit limit for company. Sets credit Limit for company. If the limit is empty, credit limit will no longer be verified.
        /// </summary>
        /// <param name="body">An object containing the data used to set the credit limit.</param>
        /// <returns></returns>
        public void SetCreditLimit (SetCreditLimitRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SetCreditLimit");
    
            var path = "/SetCreditLimit";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetCreditLimit: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetCreditLimit: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
