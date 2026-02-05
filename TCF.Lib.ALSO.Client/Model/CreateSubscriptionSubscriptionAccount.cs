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
  public class CreateSubscriptionSubscriptionAccount {
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
    public SubscriptionAccountSubscriptionAccountFields Fields { get; set; }

    /// <summary>
    /// Parent AccountID of new subscription.
    /// </summary>
    /// <value>Parent AccountID of new subscription.</value>
    [DataMember(Name="ParentAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentAccountId")]
    public int? ParentAccountId { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name="ServiceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceName")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Gets or Sets QuoteId
    /// </summary>
    [DataMember(Name="QuoteId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteId")]
    public string QuoteId { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledDate
    /// </summary>
    [DataMember(Name="ScheduledDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledDate")]
    public string ScheduledDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateSubscriptionSubscriptionAccount {\n");
      sb.Append("  ContractId: ").Append(ContractId).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  Fields: ").Append(Fields).Append("\n");
      sb.Append("  ParentAccountId: ").Append(ParentAccountId).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
      sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
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
