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
  public class SimpleProductInfo {
    /// <summary>
    /// Gets or Sets DependencyInfo
    /// </summary>
    [DataMember(Name="DependencyInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DependencyInfo")]
    public List<DependencyInfo> DependencyInfo { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Icon
    /// </summary>
    [DataMember(Name="Icon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Icon")]
    public string Icon { get; set; }

    /// <summary>
    /// Gets or Sets IndirectDependencies
    /// </summary>
    [DataMember(Name="IndirectDependencies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IndirectDependencies")]
    public List<ProductDependency> IndirectDependencies { get; set; }

    /// <summary>
    /// Gets or Sets OwnerName
    /// </summary>
    [DataMember(Name="OwnerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OwnerName")]
    public string OwnerName { get; set; }

    /// <summary>
    /// Gets or Sets ProductName
    /// </summary>
    [DataMember(Name="ProductName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductName")]
    public string ProductName { get; set; }

    /// <summary>
    /// Gets or Sets IsTCAccepted
    /// </summary>
    [DataMember(Name="IsTCAccepted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsTCAccepted")]
    public bool? IsTCAccepted { get; set; }

    /// <summary>
    /// Gets or Sets SimpleProductBillingInfo
    /// </summary>
    [DataMember(Name="SimpleProductBillingInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SimpleProductBillingInfo")]
    public List<SimpleProductBillingInfo> SimpleProductBillingInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SimpleProductInfo {\n");
      sb.Append("  DependencyInfo: ").Append(DependencyInfo).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Icon: ").Append(Icon).Append("\n");
      sb.Append("  IndirectDependencies: ").Append(IndirectDependencies).Append("\n");
      sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
      sb.Append("  IsTCAccepted: ").Append(IsTCAccepted).Append("\n");
      sb.Append("  SimpleProductBillingInfo: ").Append(SimpleProductBillingInfo).Append("\n");
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
