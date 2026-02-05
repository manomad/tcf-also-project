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
  public class SimpleRole {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// Gets or Sets IsShared
    /// </summary>
    [DataMember(Name="IsShared", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsShared")]
    public bool? IsShared { get; set; }

    /// <summary>
    /// Gets or Sets IsTemplate
    /// </summary>
    [DataMember(Name="IsTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsTemplate")]
    public bool? IsTemplate { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// List of users whom this role is assigned to
    /// </summary>
    /// <value>List of users whom this role is assigned to</value>
    [DataMember(Name="Users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Users")]
    public List<SimpleRoleUsers> Users { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SimpleRole {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsShared: ").Append(IsShared).Append("\n");
      sb.Append("  IsTemplate: ").Append(IsTemplate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
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
