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
  public class SimpleCreditLimitRecord {
    /// <summary>
    /// Gets or Sets Comment
    /// </summary>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="Currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="Date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Date")]
    public string Date { get; set; }

    /// <summary>
    /// Gets or Sets Limit
    /// </summary>
    [DataMember(Name="Limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Limit")]
    public decimal? Limit { get; set; }

    /// <summary>
    /// Gets or Sets RemainingCreditLimit
    /// </summary>
    [DataMember(Name="RemainingCreditLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RemainingCreditLimit")]
    public decimal? RemainingCreditLimit { get; set; }

    /// <summary>
    /// Gets or Sets HasCreditLimit
    /// </summary>
    [DataMember(Name="HasCreditLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasCreditLimit")]
    public bool? HasCreditLimit { get; set; }

    /// <summary>
    /// Gets or Sets CreatedByAccountId
    /// </summary>
    [DataMember(Name="CreatedByAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByAccountId")]
    public int? CreatedByAccountId { get; set; }

    /// <summary>
    /// Gets or Sets IsLocked
    /// </summary>
    [DataMember(Name="IsLocked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsLocked")]
    public bool? IsLocked { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SimpleCreditLimitRecord {\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  RemainingCreditLimit: ").Append(RemainingCreditLimit).Append("\n");
      sb.Append("  HasCreditLimit: ").Append(HasCreditLimit).Append("\n");
      sb.Append("  CreatedByAccountId: ").Append(CreatedByAccountId).Append("\n");
      sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
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
