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
    public interface ICompanyApi
    {
        /// <summary>
        /// Creates a company. Creates a company.
        /// </summary>
        /// <param name="body">The company account details that will be used to create the account.</param>
        /// <returns>Company</returns>
        Company CreateCompany (CompanyAccount body);
        /// <summary>
        /// Lists companies under specified parent Account ID. Lists companies under specified parent Account ID. Only first level of companies will be listed.
        /// </summary>
        /// <param name="body">Account ID of the parent.</param>
        /// <returns>List&lt;Company&gt;</returns>
        List<Company> GetCompanies (GetCompaniesRequest body);
        /// <summary>
        /// Gets a company based on its Account ID. Gets a company based on the Account ID provided. If no account ID is provided, the current session user&#x27;s company Account ID is used.
        /// </summary>
        /// <param name="body">Account ID of the requested company. (This is an **optional** parameter. If no Account ID is provided, the current session user&#x27;s company Account ID is used.)</param>
        /// <returns>List&lt;Company&gt;</returns>
        List<Company> Getcompany (GetCompanyRequest body);
        /// <summary>
        /// Gets a company based on its Vat ID. Gets a company based on the Vat ID provided.
        /// </summary>
        /// <param name="body">Vat ID</param>
        /// <returns>List&lt;Company&gt;</returns>
        List<Company> GetcompanyByVatId (GetCompanyByVatIdBody body);
        /// <summary>
        /// Updates the company details. Updates the company details including contract id, company name, e-mail, crefo nr, domain, address, city, zip and customer id.  Works only if the Account type is company, so won&#x27;t work if you try to modify a reseller. 
        /// </summary>
        /// <param name="body">Company object containing data to be updated.</param>
        /// <returns></returns>
        void Updatecompany (UpdateCompany body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CompanyApi : ICompanyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CompanyApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompanyApi(String basePath)
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
        /// Creates a company. Creates a company.
        /// </summary>
        /// <param name="body">The company account details that will be used to create the account.</param>
        /// <returns>Company</returns>
        public Company CreateCompany (CompanyAccount body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateCompany");
    
            var path = "/CreateCompany";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCompany: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCompany: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Company) ApiClient.Deserialize(response.Content, typeof(Company), response.Headers);
        }
    
        /// <summary>
        /// Lists companies under specified parent Account ID. Lists companies under specified parent Account ID. Only first level of companies will be listed.
        /// </summary>
        /// <param name="body">Account ID of the parent.</param>
        /// <returns>List&lt;Company&gt;</returns>
        public List<Company> GetCompanies (GetCompaniesRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetCompanies");
    
            var path = "/GetCompanies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCompanies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCompanies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Company>) ApiClient.Deserialize(response.Content, typeof(List<Company>), response.Headers);
        }
    
        /// <summary>
        /// Gets a company based on its Account ID. Gets a company based on the Account ID provided. If no account ID is provided, the current session user&#x27;s company Account ID is used.
        /// </summary>
        /// <param name="body">Account ID of the requested company. (This is an **optional** parameter. If no Account ID is provided, the current session user&#x27;s company Account ID is used.)</param>
        /// <returns>List&lt;Company&gt;</returns>
        public List<Company> Getcompany (GetCompanyRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Getcompany");
    
            var path = "/GetCompany";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Getcompany: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getcompany: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Company>) ApiClient.Deserialize(response.Content, typeof(List<Company>), response.Headers);
        }
    
        /// <summary>
        /// Gets a company based on its Vat ID. Gets a company based on the Vat ID provided.
        /// </summary>
        /// <param name="body">Vat ID</param>
        /// <returns>List&lt;Company&gt;</returns>
        public List<Company> GetcompanyByVatId (GetCompanyByVatIdBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetcompanyByVatId");
    
            var path = "/GetCompanyByVatId";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetcompanyByVatId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetcompanyByVatId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Company>) ApiClient.Deserialize(response.Content, typeof(List<Company>), response.Headers);
        }
    
        /// <summary>
        /// Updates the company details. Updates the company details including contract id, company name, e-mail, crefo nr, domain, address, city, zip and customer id.  Works only if the Account type is company, so won&#x27;t work if you try to modify a reseller. 
        /// </summary>
        /// <param name="body">Company object containing data to be updated.</param>
        /// <returns></returns>
        public void Updatecompany (UpdateCompany body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Updatecompany");
    
            var path = "/UpdateCompany";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Updatecompany: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Updatecompany: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
