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
  public class UpdateSubscriptionSubscription {
    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

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
    /// Gets or Sets Fields
    /// </summary>
    [DataMember(Name="Fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fields")]
    public List<UpdateFields> Fields { get; set; }

    /// <summary>
    /// Gets or Sets ParentAccountId
    /// </summary>
    [DataMember(Name="ParentAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentAccountId")]
    public int? ParentAccountId { get; set; }

    /// <summary>
    /// Gets or Sets ServiceDisplayName
    /// </summary>
    [DataMember(Name="ServiceDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceDisplayName")]
    public string ServiceDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name="ServiceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceName")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Possible Values are \"Renew\" and \"Terminate\".
    /// </summary>
    /// <value>Possible Values are \"Renew\" and \"Terminate\".</value>
    [DataMember(Name="AdvancePeriodEndAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdvancePeriodEndAction")]
    public string AdvancePeriodEndAction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateSubscriptionSubscription {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  ContractId: ").Append(ContractId).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  Fields: ").Append(Fields).Append("\n");
      sb.Append("  ParentAccountId: ").Append(ParentAccountId).Append("\n");
      sb.Append("  ServiceDisplayName: ").Append(ServiceDisplayName).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  AdvancePeriodEndAction: ").Append(AdvancePeriodEndAction).Append("\n");
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
