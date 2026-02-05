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
  public class PossibleUpgradeServices {
    /// <summary>
    /// Gets or Sets UpgradeProducts
    /// </summary>
    [DataMember(Name="UpgradeProducts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpgradeProducts")]
    public List<UpgradeServices> UpgradeProducts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PossibleUpgradeServices {\n");
      sb.Append("  UpgradeProducts: ").Append(UpgradeProducts).Append("\n");
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
