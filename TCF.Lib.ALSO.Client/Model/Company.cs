using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Company {
    /// <summary>
    /// Gets or Sets ParentAccountId
    /// </summary>
    [DataMember(Name="ParentAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentAccountId")]
    public int? ParentAccountId { get; set; }

    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Gets or Sets AccountState
    /// </summary>
    [DataMember(Name="AccountState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountState")]
    public string AccountState { get; set; }

    /// <summary>
    /// Gets or Sets CompanyName
    /// </summary>
    [DataMember(Name="CompanyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyName")]
    public string CompanyName { get; set; }

    /// <summary>
    /// Gets or Sets VATID
    /// </summary>
    [DataMember(Name="VATID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VATID")]
    public string VATID { get; set; }

    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    [DataMember(Name="Domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Domain")]
    public List<string> Domain { get; set; }

    /// <summary>
    /// Gets or Sets BillingStartDate
    /// </summary>
    [DataMember(Name="BillingStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingStartDate")]
    public string BillingStartDate { get; set; }

    /// <summary>
    /// Gets or Sets ContractId
    /// </summary>
    [DataMember(Name="ContractId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContractId")]
    public string ContractId { get; set; }

    /// <summary>
    /// Gets or Sets PurchaseOrderNumber
    /// </summary>
    [DataMember(Name="PurchaseOrderNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PurchaseOrderNumber")]
    public string PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Gets or Sets CustomerId
    /// </summary>
    [DataMember(Name="CustomerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerId")]
    public string CustomerId { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="Currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets City
    /// </summary>
    [DataMember(Name="City", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "City")]
    public string City { get; set; }

    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="Country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets Zip
    /// </summary>
    [DataMember(Name="Zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Zip")]
    public string Zip { get; set; }

    /// <summary>
    /// Gets or Sets OnlineBillSplitByEndCustomer
    /// </summary>
    [DataMember(Name="OnlineBillSplitByEndCustomer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OnlineBillSplitByEndCustomer")]
    public bool? OnlineBillSplitByEndCustomer { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="Email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets TechnicalEmail
    /// </summary>
    [DataMember(Name="TechnicalEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TechnicalEmail")]
    public string TechnicalEmail { get; set; }

    /// <summary>
    /// Gets or Sets TechnicalContact
    /// </summary>
    [DataMember(Name="TechnicalContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TechnicalContact")]
    public string TechnicalContact { get; set; }

    /// <summary>
    /// Gets or Sets Salesman
    /// </summary>
    [DataMember(Name="Salesman", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Salesman")]
    public string Salesman { get; set; }

    /// <summary>
    /// Gets or Sets Marketplace
    /// </summary>
    [DataMember(Name="Marketplace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Marketplace")]
    public int? Marketplace { get; set; }

    /// <summary>
    /// Gets or Sets Marketplaces
    /// </summary>
    [DataMember(Name="Marketplaces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Marketplaces")]
    public List<int?> Marketplaces { get; set; }

    /// <summary>
    /// Gets or Sets BankDetails
    /// </summary>
    [DataMember(Name="BankDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankDetails")]
    public BankDetails BankDetails { get; set; }

    /// <summary>
    /// Gets or Sets ElectronicInvoicing
    /// </summary>
    [DataMember(Name="ElectronicInvoicing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ElectronicInvoicing")]
    public ElectronicInvoicing ElectronicInvoicing { get; set; }

    /// <summary>
    /// Gets or Sets CrefoNumber
    /// </summary>
    [DataMember(Name="CrefoNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CrefoNumber")]
    public string CrefoNumber { get; set; }

    /// <summary>
    /// Gets or Sets CompanyContractEndDate
    /// </summary>
    [DataMember(Name="CompanyContractEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyContractEndDate")]
    public string CompanyContractEndDate { get; set; }

    /// <summary>
    /// Gets or Sets MPNId
    /// </summary>
    [DataMember(Name="MPNId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MPNId")]
    public string MPNId { get; set; }

    /// <summary>
    /// Gets or Sets AccountType
    /// </summary>
    [DataMember(Name="AccountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountType")]
    public string AccountType { get; set; }

    /// <summary>
    /// Gets or Sets ContactPerson
    /// </summary>
    [DataMember(Name="ContactPerson", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactPerson")]
    public string ContactPerson { get; set; }

    /// <summary>
    /// Gets or Sets ReferenceNumber
    /// </summary>
    [DataMember(Name="ReferenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReferenceNumber")]
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Gets or Sets Industry
    /// </summary>
    [DataMember(Name="Industry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Industry")]
    public IndustryEnum Industry { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Company {\n");
      sb.Append("  ParentAccountId: ").Append(ParentAccountId).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountState: ").Append(AccountState).Append("\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  VATID: ").Append(VATID).Append("\n");
      sb.Append("  Domain: ").Append(Domain).Append("\n");
      sb.Append("  BillingStartDate: ").Append(BillingStartDate).Append("\n");
      sb.Append("  ContractId: ").Append(ContractId).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
      sb.Append("  OnlineBillSplitByEndCustomer: ").Append(OnlineBillSplitByEndCustomer).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  TechnicalEmail: ").Append(TechnicalEmail).Append("\n");
      sb.Append("  TechnicalContact: ").Append(TechnicalContact).Append("\n");
      sb.Append("  Salesman: ").Append(Salesman).Append("\n");
      sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
      sb.Append("  Marketplaces: ").Append(Marketplaces).Append("\n");
      sb.Append("  BankDetails: ").Append(BankDetails).Append("\n");
      sb.Append("  ElectronicInvoicing: ").Append(ElectronicInvoicing).Append("\n");
      sb.Append("  CrefoNumber: ").Append(CrefoNumber).Append("\n");
      sb.Append("  CompanyContractEndDate: ").Append(CompanyContractEndDate).Append("\n");
      sb.Append("  MPNId: ").Append(MPNId).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
      sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
      sb.Append("  Industry: ").Append(Industry).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
