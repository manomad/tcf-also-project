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
  public class DependencyInfo {
    /// <summary>
    /// Gets or Sets DependentProductAdded
    /// </summary>
    [DataMember(Name="DependentProductAdded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DependentProductAdded")]
    public bool? DependentProductAdded { get; set; }

    /// <summary>
    /// Gets or Sets IndirectDependencyInfoAccount
    /// </summary>
    [DataMember(Name="IndirectDependencyInfoAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IndirectDependencyInfoAccount")]
    public List<IndirectDependencyInfoAccount> IndirectDependencyInfoAccount { get; set; }

    /// <summary>
    /// Gets or Sets ProductDisplayname
    /// </summary>
    [DataMember(Name="ProductDisplayname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductDisplayname")]
    public string ProductDisplayname { get; set; }

    /// <summary>
    /// Gets or Sets ProductName
    /// </summary>
    [DataMember(Name="ProductName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductName")]
    public string ProductName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DependencyInfo {\n");
      sb.Append("  DependentProductAdded: ").Append(DependentProductAdded).Append("\n");
      sb.Append("  IndirectDependencyInfoAccount: ").Append(IndirectDependencyInfoAccount).Append("\n");
      sb.Append("  ProductDisplayname: ").Append(ProductDisplayname).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
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
