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
  public class GetLatestInvoicesForPeriodBody {
    /// <summary>
    /// Gets or Sets Year
    /// </summary>
    [DataMember(Name="year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "year")]
    public int? Year { get; set; }

    /// <summary>
    /// Gets or Sets Month
    /// </summary>
    [DataMember(Name="month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "month")]
    public int? Month { get; set; }

    /// <summary>
    /// Gets or Sets ResellerContext
    /// </summary>
    [DataMember(Name="resellerContext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resellerContext")]
    public int? ResellerContext { get; set; }

    /// <summary>
    /// Gets or Sets GroupByDepartments
    /// </summary>
    [DataMember(Name="groupByDepartments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupByDepartments")]
    public bool? GroupByDepartments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetLatestInvoicesForPeriodBody {\n");
      sb.Append("  Year: ").Append(Year).Append("\n");
      sb.Append("  Month: ").Append(Month).Append("\n");
      sb.Append("  ResellerContext: ").Append(ResellerContext).Append("\n");
      sb.Append("  GroupByDepartments: ").Append(GroupByDepartments).Append("\n");
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
