using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace TCF.WinApp.TestRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var apiClient = new ApiClient("https://apim-tcf.azure-api.net");
                //var apiClient = new ApiClient();
                IAuthenticateApi authApi = new AuthenticateApi(apiClient);
                string sessionToken = authApi.GetSessionTokenPost(new AuthenticateRequest
                {
                    Username = "your_username",
                    Password = "your_password"
                });

                var authHeader = new Dictionary<string, string>
                {
                    { "Authenticate", "CCPSessionId " + sessionToken },
                };

                IO.Swagger.Client.Configuration.ApiKey["Authenticate"] = sessionToken;
                IO.Swagger.Client.Configuration.ApiKeyPrefix["Authenticate"] = "CCPSessionId";

                ICompanyApi companyApi = new CompanyApi(apiClient);
                var companies = companyApi.GetCompanies(new GetCompaniesRequest
                {
                    ParentAccountId = 12345,
                });

                List<LicenseInfo> licenses = new List<LicenseInfo>();
                Random random = new Random();
                ISubscriptionApi subscriptionApi = new SubscriptionApi(apiClient);
                foreach (var company in companies)
                {
                    Console.WriteLine($"Retrieving subscriptions for - Company ID: {company.AccountId}, Name: {company.CompanyName}");

                    var subscriptions = subscriptionApi.Getsubscriptions(new GetSubscriptionsRequest
                    {
                        ParentAccountId = company.AccountId,
                        ResellerContext = 12345,
                        ExcludeUserLevel = true
                    });

                    foreach (var subscription in subscriptions)
                    {
                        foreach (var priceableItem in subscription.PriceableItems)
                        {
                            licenses.Add(new LicenseInfo
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

                Console.WriteLine("Licenses retrieved: ");
                foreach (var license in licenses)
                {
                    Console.WriteLine($"Customer: {license.CustomerName}, SKU: {license.Sku}, Sales Price: {license.SalesPrice}, Expiration: {license.ExpirationDate.ToShortDateString()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message);
            }
        }
    }
}
