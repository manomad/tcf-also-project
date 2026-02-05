using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Provide a list of key value pairs. Fieldname: Value. To determine the field names use the /GetFieldsForService method, the value of the Name key from the /GetFieldsForService method should be used as the field value. Validation should be taken into account. Some fields might have regex validation so important to provide correct values, otherwyse subscription creation will fail.
  /// </summary>
  [DataContract]
  public class SubscriptionAccountSubscriptionAccountFields {
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
    /// Gets or Sets Primarycontactfirstname
    /// </summary>
    [DataMember(Name="Primarycontactfirstname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Primarycontactfirstname")]
    public string Primarycontactfirstname { get; set; }

    /// <summary>
    /// Gets or Sets Primarycontactlastname
    /// </summary>
    [DataMember(Name="Primarycontactlastname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Primarycontactlastname")]
    public string Primarycontactlastname { get; set; }

    /// <summary>
    /// Gets or Sets Primarydomainname
    /// </summary>
    [DataMember(Name="Primarydomainname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Primarydomainname")]
    public string Primarydomainname { get; set; }

    /// <summary>
    /// Gets or Sets SpecialQualifications
    /// </summary>
    [DataMember(Name="SpecialQualifications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpecialQualifications")]
    public string SpecialQualifications { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionAccountSubscriptionAccountFields {\n");
      sb.Append("  ExistingOffice365customer: ").Append(ExistingOffice365customer).Append("\n");
      sb.Append("  MicrosoftpartnerID: ").Append(MicrosoftpartnerID).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  PrimaryContactEmailAddress: ").Append(PrimaryContactEmailAddress).Append("\n");
      sb.Append("  Verification: ").Append(Verification).Append("\n");
      sb.Append("  Primarycontactfirstname: ").Append(Primarycontactfirstname).Append("\n");
      sb.Append("  Primarycontactlastname: ").Append(Primarycontactlastname).Append("\n");
      sb.Append("  Primarydomainname: ").Append(Primarydomainname).Append("\n");
      sb.Append("  SpecialQualifications: ").Append(SpecialQualifications).Append("\n");
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
