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
    public interface IInvoicesApi
    {
        /// <summary>
        /// Gets the invoices for specific period. Gets the invoice for specific period. Response contains all charges for child companies for the last closed billing interval, meaning last full month.  Charges will be grouped by departments if parameter set.
        /// </summary>
        /// <param name="body">An empty object or reseller context</param>
        /// <returns>List&lt;Invoice&gt;</returns>
        List<Invoice> GetLatestInvoicesForPeriod (GetLatestInvoicesForPeriodBody body);
        /// <summary>
        /// Gets the latest invoices for the authenticated account. Gets the latest invoices for the authenticated account, json body should be empty. Response contains all charges for child companies for the last closed billing interval, meaning last full month. Charges will be grouped by departments if parameter set.
        /// </summary>
        /// <param name="body">An empty object or reseller context</param>
        /// <returns>List&lt;Invoice&gt;</returns>
        List<Invoice> Getlatestinvoices (GetLatestInvoicesBody body);
        /// <summary>
        /// Gets the invoices for current Preview interval (current unclosed month), if it exists. Gets the invoices for current Preview interval (current unclosed month), if it exists for the authorised account&#x27;s company. Json body should be empty. Response contains all charges for child companies for the last preview billing interval, meaning current month. Preview invoices are generated every Friday morning and shows how the invoice would look like assuming nothing changes until end of month. Charges will be grouped by departments if parameter set.
        /// </summary>
        /// <param name="body">An empty object or reseller context</param>
        /// <returns>List&lt;Invoice&gt;</returns>
        List<Invoice> Getpreviewinvoices (GetPreviewInvoicesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoicesApi : IInvoicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InvoicesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoicesApi(String basePath)
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
        /// Gets the invoices for specific period. Gets the invoice for specific period. Response contains all charges for child companies for the last closed billing interval, meaning last full month.  Charges will be grouped by departments if parameter set.
        /// </summary>
        /// <param name="body">An empty object or reseller context</param>
        /// <returns>List&lt;Invoice&gt;</returns>
        public List<Invoice> GetLatestInvoicesForPeriod (GetLatestInvoicesForPeriodBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetLatestInvoicesForPeriod");
    
            var path = "/GetLatestInvoicesForPeriod";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLatestInvoicesForPeriod: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLatestInvoicesForPeriod: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Invoice>) ApiClient.Deserialize(response.Content, typeof(List<Invoice>), response.Headers);
        }
    
        /// <summary>
        /// Gets the latest invoices for the authenticated account. Gets the latest invoices for the authenticated account, json body should be empty. Response contains all charges for child companies for the last closed billing interval, meaning last full month. Charges will be grouped by departments if parameter set.
        /// </summary>
        /// <param name="body">An empty object or reseller context</param>
        /// <returns>List&lt;Invoice&gt;</returns>
        public List<Invoice> Getlatestinvoices (GetLatestInvoicesBody body)
        {
    
            var path = "/GetLatestInvoices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Getlatestinvoices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getlatestinvoices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Invoice>) ApiClient.Deserialize(response.Content, typeof(List<Invoice>), response.Headers);
        }
    
        /// <summary>
        /// Gets the invoices for current Preview interval (current unclosed month), if it exists. Gets the invoices for current Preview interval (current unclosed month), if it exists for the authorised account&#x27;s company. Json body should be empty. Response contains all charges for child companies for the last preview billing interval, meaning current month. Preview invoices are generated every Friday morning and shows how the invoice would look like assuming nothing changes until end of month. Charges will be grouped by departments if parameter set.
        /// </summary>
        /// <param name="body">An empty object or reseller context</param>
        /// <returns>List&lt;Invoice&gt;</returns>
        public List<Invoice> Getpreviewinvoices (GetPreviewInvoicesBody body)
        {
    
            var path = "/GetPreviewInvoices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Getpreviewinvoices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getpreviewinvoices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Invoice>) ApiClient.Deserialize(response.Content, typeof(List<Invoice>), response.Headers);
        }
    
    }
}
