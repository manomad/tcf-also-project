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
    public interface IMarketplaceServicesApi
    {
        /// <summary>
        /// Accept terms and conditions for service in marketplace. Accetpt terms and conditions
        /// </summary>
        /// <param name="body">Marketplace ID</param>
        /// <returns></returns>
        void AcceptTermsForMarketplaceService (AcceptTermsForMarketplaceServiceBody body);
        /// <summary>
        /// Add service to marketplace. Adds services to marketplace. Use /GetAvailableServicesForMarketplace to get list of services that can be added to current marketplace.
        /// </summary>
        /// <param name="body">An object of marketplace ID and object of service names. At least one service name should be provided</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        List<MarketplaceServiceInfo> AddMarketplaceServices (AddMarketplaceServicesBody body);
        /// <summary>
        /// Remove single service from marketplace. Removes single service from marketplace. The service can be in Hidden or Deleted state after method execution. Service goes to Hidden state if there is any active service subscription. Hidden state means that new subscriptions cannot be created, but existing subscriptions use prices from that marketplace.
        /// </summary>
        /// <param name="body">An object of marketplace ID and object of service name.</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        List<MarketplaceServiceInfo> DeleteMarketplaceService (DeleteMarketplaceServiceBody body);
        /// <summary>
        /// Remove services from marketplace. Removes services from marketplace. The service can be in Hidden or Deleted state after method execution. Service goes to Hidden state if there is any active service subscription. Hidden state means that new subscriptions cannot be created, but existing subscriptions use prices from that marketplace.
        /// </summary>
        /// <param name="body">An object of marketplace ID and object service names. At least one service name should be provided</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        List<MarketplaceServiceInfo> DeleteMarketplaceServices (DeleteMarketplaceServicesBody body);
        /// <summary>
        /// Get available services for specific marketplace. Return list of avilable services for specific marketplace
        /// </summary>
        /// <param name="body">Marketplace ID</param>
        /// <returns>List&lt;SimpleProductInfo&gt;</returns>
        List<SimpleProductInfo> GetAvailableServicesForMarketplace (GetAvailableServicesForMarketplaceBody body);
        /// <summary>
        /// List of servicies terms and conditions with list of related products. List of servicies terms and conditions with list of related products
        /// </summary>
        /// <param name="body">Product Name</param>
        /// <returns>List&lt;TermsAndConditions&gt;</returns>
        List<TermsAndConditions> GetSpecialProductTermsForService (GetSpecialProductTermsForServiceBody body);
        /// <summary>
        /// Gets a service information by its service name. Get service information by its service name.
        /// </summary>
        /// <param name="body">An object containing the data to get a service information.</param>
        /// <returns>ServiceInformation</returns>
        ServiceInformation Getserviceinformation (GetServiceInformationBody body);
        /// <summary>
        /// Lists all services for specific marketplace. Lists all services for specific marketplace
        /// </summary>
        /// <param name="body">marketplace ID</param>
        /// <returns>List&lt;SimpleProductInfo&gt;</returns>
        List<SimpleProductInfo> ListMarketplaceServices (ListMarketplaceServicesBody body);
        /// <summary>
        /// Adds provided services to provided marketplace Method was used to add services to marketplace. Please use **_/AddMarketplaceServices** method instead.
        /// </summary>
        /// <param name="body">An object of marketplace ID and object of marketplace service info.</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        List<MarketplaceServiceInfo> UpdateMarketplaceServices (UpdateMarketplaceServicesBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MarketplaceServicesApi : IMarketplaceServicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceServicesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MarketplaceServicesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceServicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MarketplaceServicesApi(String basePath)
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
        /// Accept terms and conditions for service in marketplace. Accetpt terms and conditions
        /// </summary>
        /// <param name="body">Marketplace ID</param>
        /// <returns></returns>
        public void AcceptTermsForMarketplaceService (AcceptTermsForMarketplaceServiceBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AcceptTermsForMarketplaceService");
    
            var path = "/AcceptTermsForMarketplaceService";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AcceptTermsForMarketplaceService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AcceptTermsForMarketplaceService: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add service to marketplace. Adds services to marketplace. Use /GetAvailableServicesForMarketplace to get list of services that can be added to current marketplace.
        /// </summary>
        /// <param name="body">An object of marketplace ID and object of service names. At least one service name should be provided</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        public List<MarketplaceServiceInfo> AddMarketplaceServices (AddMarketplaceServicesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddMarketplaceServices");
    
            var path = "/AddMarketplaceServices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddMarketplaceServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMarketplaceServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MarketplaceServiceInfo>) ApiClient.Deserialize(response.Content, typeof(List<MarketplaceServiceInfo>), response.Headers);
        }
    
        /// <summary>
        /// Remove single service from marketplace. Removes single service from marketplace. The service can be in Hidden or Deleted state after method execution. Service goes to Hidden state if there is any active service subscription. Hidden state means that new subscriptions cannot be created, but existing subscriptions use prices from that marketplace.
        /// </summary>
        /// <param name="body">An object of marketplace ID and object of service name.</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        public List<MarketplaceServiceInfo> DeleteMarketplaceService (DeleteMarketplaceServiceBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteMarketplaceService");
    
            var path = "/DeleteMarketplaceService";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMarketplaceService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMarketplaceService: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MarketplaceServiceInfo>) ApiClient.Deserialize(response.Content, typeof(List<MarketplaceServiceInfo>), response.Headers);
        }
    
        /// <summary>
        /// Remove services from marketplace. Removes services from marketplace. The service can be in Hidden or Deleted state after method execution. Service goes to Hidden state if there is any active service subscription. Hidden state means that new subscriptions cannot be created, but existing subscriptions use prices from that marketplace.
        /// </summary>
        /// <param name="body">An object of marketplace ID and object service names. At least one service name should be provided</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        public List<MarketplaceServiceInfo> DeleteMarketplaceServices (DeleteMarketplaceServicesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeleteMarketplaceServices");
    
            var path = "/DeleteMarketplaceServices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMarketplaceServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMarketplaceServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MarketplaceServiceInfo>) ApiClient.Deserialize(response.Content, typeof(List<MarketplaceServiceInfo>), response.Headers);
        }
    
        /// <summary>
        /// Get available services for specific marketplace. Return list of avilable services for specific marketplace
        /// </summary>
        /// <param name="body">Marketplace ID</param>
        /// <returns>List&lt;SimpleProductInfo&gt;</returns>
        public List<SimpleProductInfo> GetAvailableServicesForMarketplace (GetAvailableServicesForMarketplaceBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetAvailableServicesForMarketplace");
    
            var path = "/GetAvailableServicesForMarketplace";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAvailableServicesForMarketplace: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAvailableServicesForMarketplace: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SimpleProductInfo>) ApiClient.Deserialize(response.Content, typeof(List<SimpleProductInfo>), response.Headers);
        }
    
        /// <summary>
        /// List of servicies terms and conditions with list of related products. List of servicies terms and conditions with list of related products
        /// </summary>
        /// <param name="body">Product Name</param>
        /// <returns>List&lt;TermsAndConditions&gt;</returns>
        public List<TermsAndConditions> GetSpecialProductTermsForService (GetSpecialProductTermsForServiceBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetSpecialProductTermsForService");
    
            var path = "/GetSpecialProductTermsForService";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSpecialProductTermsForService: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSpecialProductTermsForService: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TermsAndConditions>) ApiClient.Deserialize(response.Content, typeof(List<TermsAndConditions>), response.Headers);
        }
    
        /// <summary>
        /// Gets a service information by its service name. Get service information by its service name.
        /// </summary>
        /// <param name="body">An object containing the data to get a service information.</param>
        /// <returns>ServiceInformation</returns>
        public ServiceInformation Getserviceinformation (GetServiceInformationBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Getserviceinformation");
    
            var path = "/GetServiceInformation";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Getserviceinformation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Getserviceinformation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServiceInformation) ApiClient.Deserialize(response.Content, typeof(ServiceInformation), response.Headers);
        }
    
        /// <summary>
        /// Lists all services for specific marketplace. Lists all services for specific marketplace
        /// </summary>
        /// <param name="body">marketplace ID</param>
        /// <returns>List&lt;SimpleProductInfo&gt;</returns>
        public List<SimpleProductInfo> ListMarketplaceServices (ListMarketplaceServicesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ListMarketplaceServices");
    
            var path = "/ListMarketplaceServices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListMarketplaceServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListMarketplaceServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SimpleProductInfo>) ApiClient.Deserialize(response.Content, typeof(List<SimpleProductInfo>), response.Headers);
        }
    
        /// <summary>
        /// Adds provided services to provided marketplace Method was used to add services to marketplace. Please use **_/AddMarketplaceServices** method instead.
        /// </summary>
        /// <param name="body">An object of marketplace ID and object of marketplace service info.</param>
        /// <returns>List&lt;MarketplaceServiceInfo&gt;</returns>
        public List<MarketplaceServiceInfo> UpdateMarketplaceServices (UpdateMarketplaceServicesBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMarketplaceServices");
    
            var path = "/UpdateMarketplaceServices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMarketplaceServices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMarketplaceServices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MarketplaceServiceInfo>) ApiClient.Deserialize(response.Content, typeof(List<MarketplaceServiceInfo>), response.Headers);
        }
    
    }
}
