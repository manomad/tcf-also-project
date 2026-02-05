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
  public class GetRemoteEnumsRequestRemoteEnumRequest {
    /// <summary>
    /// Gets or Sets FieldName
    /// </summary>
    [DataMember(Name="FieldName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FieldName")]
    public string FieldName { get; set; }

    /// <summary>
    /// Gets or Sets AccountViewName
    /// </summary>
    [DataMember(Name="AccountViewName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountViewName")]
    public string AccountViewName { get; set; }

    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Should Always start with Product_
    /// </summary>
    /// <value>Should Always start with Product_</value>
    [DataMember(Name="ParentAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentAccountId")]
    public int? ParentAccountId { get; set; }

    /// <summary>
    /// Gets or Sets DependencyAccountId
    /// </summary>
    [DataMember(Name="DependencyAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DependencyAccountId")]
    public int? DependencyAccountId { get; set; }

    /// <summary>
    /// Gets or Sets ContextValues
    /// </summary>
    [DataMember(Name="ContextValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContextValues")]
    public GetRemoteEnumsRequestRemoteEnumRequestContextValues ContextValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetRemoteEnumsRequestRemoteEnumRequest {\n");
      sb.Append("  FieldName: ").Append(FieldName).Append("\n");
      sb.Append("  AccountViewName: ").Append(AccountViewName).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  ParentAccountId: ").Append(ParentAccountId).Append("\n");
      sb.Append("  DependencyAccountId: ").Append(DependencyAccountId).Append("\n");
      sb.Append("  ContextValues: ").Append(ContextValues).Append("\n");
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
