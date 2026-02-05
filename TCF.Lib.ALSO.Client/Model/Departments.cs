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
  public class Departments {
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
    /// Gets or Sets DepartmentName
    /// </summary>
    [DataMember(Name="DepartmentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DepartmentName")]
    public string DepartmentName { get; set; }

    /// <summary>
    /// Gets or Sets VATID
    /// </summary>
    [DataMember(Name="VATID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VATID")]
    public string VATID { get; set; }

    /// <summary>
    /// Gets or Sets CompanyDomain
    /// </summary>
    [DataMember(Name="CompanyDomain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyDomain")]
    public List<string> CompanyDomain { get; set; }

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
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="Email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets VAT
    /// </summary>
    [DataMember(Name="VAT", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VAT")]
    public string VAT { get; set; }

    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    [DataMember(Name="Language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Language")]
    public string Language { get; set; }

    /// <summary>
    /// Gets or Sets Phone
    /// </summary>
    [DataMember(Name="Phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or Sets PurchaseOrderNumber
    /// </summary>
    [DataMember(Name="PurchaseOrderNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PurchaseOrderNumber")]
    public string PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Only necessary for US instance.
    /// </summary>
    /// <value>Only necessary for US instance.</value>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public string State { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Departments {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountState: ").Append(AccountState).Append("\n");
      sb.Append("  DepartmentName: ").Append(DepartmentName).Append("\n");
      sb.Append("  VATID: ").Append(VATID).Append("\n");
      sb.Append("  CompanyDomain: ").Append(CompanyDomain).Append("\n");
      sb.Append("  BillingStartDate: ").Append(BillingStartDate).Append("\n");
      sb.Append("  ContractId: ").Append(ContractId).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  VAT: ").Append(VAT).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
