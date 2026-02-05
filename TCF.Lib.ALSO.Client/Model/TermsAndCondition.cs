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
  public class TermsAndCondition {
    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    [DataMember(Name="Content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Content")]
    public string Content { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="Title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets LocalizationLanguageCode
    /// </summary>
    [DataMember(Name="LocalizationLanguageCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalizationLanguageCode")]
    public string LocalizationLanguageCode { get; set; }

    /// <summary>
    /// Gets or Sets DescriptionGroupId
    /// </summary>
    [DataMember(Name="DescriptionGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DescriptionGroupId")]
    public string DescriptionGroupId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TermsAndCondition {\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  LocalizationLanguageCode: ").Append(LocalizationLanguageCode).Append("\n");
      sb.Append("  DescriptionGroupId: ").Append(DescriptionGroupId).Append("\n");
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
