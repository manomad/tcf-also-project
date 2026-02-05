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
  public class TermsAndConditions {
    /// <summary>
    /// Gets or Sets TermsAndCondition
    /// </summary>
    [DataMember(Name="TermsAndCondition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TermsAndCondition")]
    public List<TermsAndCondition> TermsAndCondition { get; set; }

    /// <summary>
    /// Gets or Sets RelatedProducts
    /// </summary>
    [DataMember(Name="RelatedProducts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RelatedProducts")]
    public List<RelatedProducts> RelatedProducts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TermsAndConditions {\n");
      sb.Append("  TermsAndCondition: ").Append(TermsAndCondition).Append("\n");
      sb.Append("  RelatedProducts: ").Append(RelatedProducts).Append("\n");
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
