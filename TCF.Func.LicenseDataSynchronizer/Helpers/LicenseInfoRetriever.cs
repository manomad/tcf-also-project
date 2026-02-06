using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using Microsoft.Extensions.Logging;
using TCF.Func.LicenseDataSynchronizer.Model;

namespace TCF.Func.LicenseDataSynchronizer.Helpers
{
    internal class LicenseInfoRetriever
    {
        internal static List<LicenseInfo> GetLicenseData(ILogger logger)
        {
            var licenseData = new List<LicenseInfo>();
            try
            {
                // Setup API client
                var defaultUrl = "https://app.swaggerhub.com/apis/MarketplaceSimpleAPI/MarketplaceSimpleAPI/1.0.0#/";
                var apiUrl = Environment.GetEnvironmentVariable("LicenseDataApiUrl") ?? defaultUrl;
                logger.LogInformation($"Using API URL: {apiUrl}");
                var apiClient = new ApiClient(apiUrl);
                IAuthenticateApi authApi = new AuthenticateApi(apiClient);

                // Authenticate and get session token with dummy credentials
                string sessionToken = authApi.GetSessionTokenPost(new AuthenticateRequest
                {
                    Username = "dummy_username",
                    Password = "dummy_password"
                });
                logger.LogInformation("Successfully authenticated with the License Data API.");

                // Append session token to API client
                Configuration.ApiKey["Authenticate"] = sessionToken;
                Configuration.ApiKeyPrefix["Authenticate"] = "CCPSessionId";

                // Fetch companies
                ICompanyApi companyApi = new CompanyApi(apiClient);
                var companies = companyApi.GetCompanies(new GetCompaniesRequest
                {
                    ParentAccountId = Environment.GetEnvironmentVariable("ParentAccountId") != null ?
                        int.Parse(Environment.GetEnvironmentVariable("ParentAccountId")!) : 12345,
                });

                Random random = new Random();
                ISubscriptionApi subscriptionApi = new SubscriptionApi(apiClient);

                // Loop through companies and fetch subscriptions
                foreach (var company in companies)
                {
                    logger.LogDebug($"Retrieving subscriptions for - Company ID: {company.AccountId}, Name: {company.CompanyName}");

                    // Fetch subscriptions for the company
                    var subscriptions = subscriptionApi.Getsubscriptions(new GetSubscriptionsRequest
                    {
                        ParentAccountId = company.AccountId,
                        ResellerContext = Environment.GetEnvironmentVariable("ResellerContextId") != null ?
                            int.Parse(Environment.GetEnvironmentVariable("ResellerContextId")!) : 67890,
                        ExcludeUserLevel = true
                    });

                    // Loop through subscriptions and priceable items to build license data
                    foreach (var subscription in subscriptions)
                    {
                        foreach (var priceableItem in subscription.PriceableItems)
                        {
                            licenseData.Add(new LicenseInfo
                            {
                                Id = $"{company.AccountId}-{subscription.AccountId}-{priceableItem.PriceableItemId}",
                                CustomerName = company.CompanyName,
                                CustomerAccountId = company.AccountId ?? 0,
                                Country = company.Country,
                                Sku = priceableItem.PriceableItemDescription,
                                ContractType = priceableItem.PriceableItemType,
                                SalesPrice = priceableItem.SalesPrice,
                                PaymentMethod = priceableItem.ChargeType,
                                NumberOfLicenses = random.Next(1, 100), // Random number for demonstration
                                ExpirationDate = DateTime.Parse(subscription.ContractEndDate),
                                LicenseStatus = subscription.Status,
                                RenewalStatus = subscription.HasRenewActionValuesConfigured == true ? "Renewable" : ""
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError($"Error fetching license data: {ex.Message}");
            }
            return licenseData;
        }
    }
}
