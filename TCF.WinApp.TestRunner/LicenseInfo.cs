using System;
using System.Collections.Generic;
using System.Text;

namespace TCF.WinApp.TestRunner
{    
    internal record LicenseInfo
    {
        public string Id { get; set; } = String.Empty;
        public string CustomerName { get; set; } = String.Empty;
        public int CustomerAccountId { get; set; } = 0;
        public string Country { get; set; } = String.Empty;
        public string Sku { get; set; } = String.Empty;
        public string ContractType { get; set; } = String.Empty;
        public decimal? SalesPrice { get; set; }
        public string PaymentMethod { get; set; } = String.Empty;
        public int NumberOfLicenses { get; set; } = 0;
        public DateTime ExpirationDate { get; set; } = DateTime.MinValue;
        public string LicenseStatus { get; set; } = String.Empty;
        public string RenewalStatus { get; set; } = String.Empty;
    }
}
