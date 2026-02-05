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
  public class SimpleSpecialDealResponse {
    /// <summary>
    /// Gets or Sets ChargeStreamId
    /// </summary>
    [DataMember(Name="ChargeStreamId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeStreamId")]
    public int? ChargeStreamId { get; set; }

    /// <summary>
    /// Gets or Sets Comments
    /// </summary>
    [DataMember(Name="Comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comments")]
    public string Comments { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="Author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Author")]
    public string Author { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public string CreatedDate { get; set; }

    /// <summary>
    /// Always set first date of the month (previous month will be applied)
    /// </summary>
    /// <value>Always set first date of the month (previous month will be applied)</value>
    [DataMember(Name="EffectiveEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveEndDate")]
    public string EffectiveEndDate { get; set; }

    /// <summary>
    /// When true, CustomCharge is applied to all discount items; when false, Discount percent is applied.
    /// </summary>
    /// <value>When true, CustomCharge is applied to all discount items; when false, Discount percent is applied.</value>
    [DataMember(Name="IsCustomCharge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsCustomCharge")]
    public bool? IsCustomCharge { get; set; }

    /// <summary>
    /// Gets or Sets DiscountItems
    /// </summary>
    [DataMember(Name="DiscountItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscountItems")]
    public List<SimpleSpecialDealItemResponse> DiscountItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SimpleSpecialDealResponse {\n");
      sb.Append("  ChargeStreamId: ").Append(ChargeStreamId).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
      sb.Append("  IsCustomCharge: ").Append(IsCustomCharge).Append("\n");
      sb.Append("  DiscountItems: ").Append(DiscountItems).Append("\n");
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
