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
  public class SimpleUpdateRoleUsersRoleUsers {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// Gets or Sets CompanyAccountId
    /// </summary>
    [DataMember(Name="CompanyAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyAccountId")]
    public decimal? CompanyAccountId { get; set; }

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
      sb.Append("class SimpleUpdateRoleUsersRoleUsers {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CompanyAccountId: ").Append(CompanyAccountId).Append("\n");
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
