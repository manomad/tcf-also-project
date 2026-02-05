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
  public class ElectronicInvoicing {
    /// <summary>
    /// Gets or Sets InvoiceCurrency
    /// </summary>
    [DataMember(Name="InvoiceCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceCurrency")]
    public string InvoiceCurrency { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceExchangeRate
    /// </summary>
    [DataMember(Name="InvoiceExchangeRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceExchangeRate")]
    public string InvoiceExchangeRate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ElectronicInvoicing {\n");
      sb.Append("  InvoiceCurrency: ").Append(InvoiceCurrency).Append("\n");
      sb.Append("  InvoiceExchangeRate: ").Append(InvoiceExchangeRate).Append("\n");
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
