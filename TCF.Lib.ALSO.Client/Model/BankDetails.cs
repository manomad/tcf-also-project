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
  public class BankDetails {
    /// <summary>
    /// Gets or Sets IBAN
    /// </summary>
    [DataMember(Name="IBAN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IBAN")]
    public string IBAN { get; set; }

    /// <summary>
    /// Gets or Sets BankName
    /// </summary>
    [DataMember(Name="BankName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankName")]
    public string BankName { get; set; }

    /// <summary>
    /// Gets or Sets BankIdentifierCode
    /// </summary>
    [DataMember(Name="BankIdentifierCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankIdentifierCode")]
    public string BankIdentifierCode { get; set; }

    /// <summary>
    /// Gets or Sets SWIFTCode
    /// </summary>
    [DataMember(Name="SWIFTCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SWIFTCode")]
    public string SWIFTCode { get; set; }

    /// <summary>
    /// Gets or Sets AccountNumber
    /// </summary>
    [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or Sets AccountName
    /// </summary>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Gets or Sets BranchCode
    /// </summary>
    [DataMember(Name="BranchCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BranchCode")]
    public string BranchCode { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationNumber
    /// </summary>
    [DataMember(Name="RegistrationNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RegistrationNumber")]
    public string RegistrationNumber { get; set; }

    /// <summary>
    /// Gets or Sets TermsOfPayment
    /// </summary>
    [DataMember(Name="TermsOfPayment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TermsOfPayment")]
    public string TermsOfPayment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BankDetails {\n");
      sb.Append("  IBAN: ").Append(IBAN).Append("\n");
      sb.Append("  BankName: ").Append(BankName).Append("\n");
      sb.Append("  BankIdentifierCode: ").Append(BankIdentifierCode).Append("\n");
      sb.Append("  SWIFTCode: ").Append(SWIFTCode).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
      sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
      sb.Append("  TermsOfPayment: ").Append(TermsOfPayment).Append("\n");
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
