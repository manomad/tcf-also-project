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
  public class ExecuteReportRequestParameters {
    /// <summary>
    /// Gets or Sets Enddate
    /// </summary>
    [DataMember(Name="enddate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enddate")]
    public string Enddate { get; set; }

    /// <summary>
    /// Gets or Sets Startdate
    /// </summary>
    [DataMember(Name="startdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startdate")]
    public string Startdate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExecuteReportRequestParameters {\n");
      sb.Append("  Enddate: ").Append(Enddate).Append("\n");
      sb.Append("  Startdate: ").Append(Startdate).Append("\n");
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
