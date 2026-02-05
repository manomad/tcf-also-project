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
  public class ProductDependency {
    /// <summary>
    /// Gets or Sets ParentFieldName
    /// </summary>
    [DataMember(Name="ParentFieldName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentFieldName")]
    public string ParentFieldName { get; set; }

    /// <summary>
    /// Gets or Sets ParentFieldValue
    /// </summary>
    [DataMember(Name="ParentFieldValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentFieldValue")]
    public string ParentFieldValue { get; set; }

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
      sb.Append("class ProductDependency {\n");
      sb.Append("  ParentFieldName: ").Append(ParentFieldName).Append("\n");
      sb.Append("  ParentFieldValue: ").Append(ParentFieldValue).Append("\n");
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
