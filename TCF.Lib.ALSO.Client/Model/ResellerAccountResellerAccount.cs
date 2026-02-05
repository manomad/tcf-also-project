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
  public class ResellerAccountResellerAccount {
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
    /// Gets or Sets CompanyName
    /// </summary>
    [DataMember(Name="CompanyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyName")]
    public string CompanyName { get; set; }

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
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="Country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets CrefoNumber
    /// </summary>
    [DataMember(Name="CrefoNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CrefoNumber")]
    public string CrefoNumber { get; set; }

    /// <summary>
    /// Gets or Sets CustomerId
    /// </summary>
    [DataMember(Name="CustomerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerId")]
    public string CustomerId { get; set; }

    /// <summary>
    /// Gets or Sets BankDetails
    /// </summary>
    [DataMember(Name="BankDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankDetails")]
    public BankDetails BankDetails { get; set; }

    /// <summary>
    /// Gets or Sets CompanyContractEndDate
    /// </summary>
    [DataMember(Name="CompanyContractEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyContractEndDate")]
    public string CompanyContractEndDate { get; set; }

    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    [DataMember(Name="Domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Domain")]
    public List<string> Domain { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="Email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Email")]
    public string Email { get; set; }

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
    /// Gets or Sets ParentAccountId
    /// </summary>
    [DataMember(Name="ParentAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentAccountId")]
    public int? ParentAccountId { get; set; }

    /// <summary>
    /// Gets or Sets VATID
    /// </summary>
    [DataMember(Name="VATID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VATID")]
    public string VATID { get; set; }

    /// <summary>
    /// Gets or Sets Zip
    /// </summary>
    [DataMember(Name="Zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Zip")]
    public string Zip { get; set; }

    /// <summary>
    /// Gets or Sets TechnicalEmail
    /// </summary>
    [DataMember(Name="TechnicalEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TechnicalEmail")]
    public string TechnicalEmail { get; set; }

    /// <summary>
    /// Gets or Sets ContactPhone
    /// </summary>
    [DataMember(Name="ContactPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactPhone")]
    public string ContactPhone { get; set; }

    /// <summary>
    /// Gets or Sets TehnicalAccountManager
    /// </summary>
    [DataMember(Name="TehnicalAccountManager", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TehnicalAccountManager")]
    public string TehnicalAccountManager { get; set; }

    /// <summary>
    /// Gets or Sets ReferenceNumber
    /// </summary>
    [DataMember(Name="ReferenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReferenceNumber")]
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Only necessary for US instance.
    /// </summary>
    /// <value>Only necessary for US instance.</value>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets CreateDefaultAdminUser
    /// </summary>
    [DataMember(Name="CreateDefaultAdminUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreateDefaultAdminUser")]
    public bool? CreateDefaultAdminUser { get; set; }

    /// <summary>
    /// Gets or Sets CreateDefaultMarketplace
    /// </summary>
    [DataMember(Name="CreateDefaultMarketplace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreateDefaultMarketplace")]
    public bool? CreateDefaultMarketplace { get; set; }

    /// <summary>
    /// Gets or Sets MPNId
    /// </summary>
    [DataMember(Name="MPNId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MPNId")]
    public string MPNId { get; set; }

    /// <summary>
    /// Gets or Sets ParentRoleList
    /// </summary>
    [DataMember(Name="ParentRoleList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentRoleList")]
    public List<int?> ParentRoleList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResellerAccountResellerAccount {\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  ContractId: ").Append(ContractId).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  CrefoNumber: ").Append(CrefoNumber).Append("\n");
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
      sb.Append("  BankDetails: ").Append(BankDetails).Append("\n");
      sb.Append("  CompanyContractEndDate: ").Append(CompanyContractEndDate).Append("\n");
      sb.Append("  Domain: ").Append(Domain).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Marketplace: ").Append(Marketplace).Append("\n");
      sb.Append("  Marketplaces: ").Append(Marketplaces).Append("\n");
      sb.Append("  ParentAccountId: ").Append(ParentAccountId).Append("\n");
      sb.Append("  VATID: ").Append(VATID).Append("\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
      sb.Append("  TechnicalEmail: ").Append(TechnicalEmail).Append("\n");
      sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
      sb.Append("  TehnicalAccountManager: ").Append(TehnicalAccountManager).Append("\n");
      sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  CreateDefaultAdminUser: ").Append(CreateDefaultAdminUser).Append("\n");
      sb.Append("  CreateDefaultMarketplace: ").Append(CreateDefaultMarketplace).Append("\n");
      sb.Append("  MPNId: ").Append(MPNId).Append("\n");
      sb.Append("  ParentRoleList: ").Append(ParentRoleList).Append("\n");
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
