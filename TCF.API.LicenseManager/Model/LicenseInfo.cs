namespace TCF.API.LicenseManager.Model;

public record LicenseInfo
{
    public string id { get; set; } = String.Empty;
    public string customerName { get; set; } = String.Empty;
    public int customerAccountId { get; set; } = 0;
    public string country { get; set; } = String.Empty;
    public string sku { get; set; } = String.Empty;
    public string contractType { get; set; } = String.Empty;
    public decimal? salesPrice { get; set; }
    public string paymentMethod { get; set; } = String.Empty;
    public int numberOfLicenses { get; set; } = 0;
    public DateTime expirationDate { get; set; } = DateTime.MinValue;
    public string licenseStatus { get; set; } = String.Empty;
    public string renewalStatus { get; set; } = String.Empty;
}