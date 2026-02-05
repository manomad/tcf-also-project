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
  public class GetPreviewInvoicesBody {
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
      sb.Append("class GetPreviewInvoicesBody {\n");
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
