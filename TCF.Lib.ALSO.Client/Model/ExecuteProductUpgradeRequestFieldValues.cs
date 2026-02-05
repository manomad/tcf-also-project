using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Field name - field value pairs
  /// </summary>
  [DataContract]
  public class ExecuteProductUpgradeRequestFieldValues {
    /// <summary>
    /// Gets or Sets ExistingOffice365customer
    /// </summary>
    [DataMember(Name="ExistingOffice365customer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExistingOffice365customer")]
    public bool? ExistingOffice365customer { get; set; }

    /// <summary>
    /// Gets or Sets MicrosoftpartnerID
    /// </summary>
    [DataMember(Name="MicrosoftpartnerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MicrosoftpartnerID")]
    public string MicrosoftpartnerID { get; set; }

    /// <summary>
    /// Gets or Sets Phone
    /// </summary>
    [DataMember(Name="Phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or Sets PostalCode
    /// </summary>
    [DataMember(Name="PostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PostalCode")]
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryContactEmailAddress
    /// </summary>
    [DataMember(Name="PrimaryContactEmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryContactEmailAddress")]
    public string PrimaryContactEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets Verification
    /// </summary>
    [DataMember(Name="Verification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Verification")]
    public string Verification { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExecuteProductUpgradeRequestFieldValues {\n");
      sb.Append("  ExistingOffice365customer: ").Append(ExistingOffice365customer).Append("\n");
      sb.Append("  MicrosoftpartnerID: ").Append(MicrosoftpartnerID).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  PrimaryContactEmailAddress: ").Append(PrimaryContactEmailAddress).Append("\n");
      sb.Append("  Verification: ").Append(Verification).Append("\n");
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
