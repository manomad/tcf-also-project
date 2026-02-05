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
  public class UpdateCompanyCompany {
    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

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
    /// Gets or Sets ContactPhone
    /// </summary>
    [DataMember(Name="ContactPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactPhone")]
    public string ContactPhone { get; set; }

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
    /// Gets or Sets ReferenceNumber
    /// </summary>
    [DataMember(Name="ReferenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReferenceNumber")]
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Gets or Sets Salesman
    /// </summary>
    [DataMember(Name="Salesman", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Salesman")]
    public string Salesman { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets TehnicalAccountManager
    /// </summary>
    [DataMember(Name="TehnicalAccountManager", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TehnicalAccountManager")]
    public string TehnicalAccountManager { get; set; }

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
      sb.Append("class UpdateCompanyCompany {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
      sb.Append("  ContractId: ").Append(ContractId).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  CrefoNumber: ").Append(CrefoNumber).Append("\n");
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
      sb.Append("  Domain: ").Append(Domain).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Marketplaces: ").Append(Marketplaces).Append("\n");
      sb.Append("  BankDetails: ").Append(BankDetails).Append("\n");
      sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
      sb.Append("  Salesman: ").Append(Salesman).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  TehnicalAccountManager: ").Append(TehnicalAccountManager).Append("\n");
      sb.Append("  VATID: ").Append(VATID).Append("\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
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
