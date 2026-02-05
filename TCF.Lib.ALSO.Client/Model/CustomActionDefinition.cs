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
  public class CustomActionDefinition {
    /// <summary>
    /// Gets or Sets ActionName
    /// </summary>
    [DataMember(Name="ActionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActionName")]
    public string ActionName { get; set; }

    /// <summary>
    /// Gets or Sets ActionDisplayName
    /// </summary>
    [DataMember(Name="ActionDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActionDisplayName")]
    public string ActionDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ActionIcon
    /// </summary>
    [DataMember(Name="ActionIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActionIcon")]
    public string ActionIcon { get; set; }

    /// <summary>
    /// Gets or Sets Fields
    /// </summary>
    [DataMember(Name="Fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fields")]
    public SubscriptionAccountSubscriptionAccountFields Fields { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name="ServiceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceName")]
    public string ServiceName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomActionDefinition {\n");
      sb.Append("  ActionName: ").Append(ActionName).Append("\n");
      sb.Append("  ActionDisplayName: ").Append(ActionDisplayName).Append("\n");
      sb.Append("  ActionIcon: ").Append(ActionIcon).Append("\n");
      sb.Append("  Fields: ").Append(Fields).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
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
