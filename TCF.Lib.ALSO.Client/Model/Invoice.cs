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
  public class Invoice {
    /// <summary>
    /// Code of billing interval
    /// </summary>
    /// <value>Code of billing interval</value>
    [DataMember(Name="BillingInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingInterval")]
    public string BillingInterval { get; set; }

    /// <summary>
    /// Gets or Sets Charges
    /// </summary>
    [DataMember(Name="Charges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Charges")]
    public List<ServiceCharge> Charges { get; set; }

    /// <summary>
    /// AccountId of a customer
    /// </summary>
    /// <value>AccountId of a customer</value>
    [DataMember(Name="CompanyAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyAccountId")]
    public int? CompanyAccountId { get; set; }

    /// <summary>
    /// Company name of a customer
    /// </summary>
    /// <value>Company name of a customer</value>
    [DataMember(Name="CompanyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyName")]
    public string CompanyName { get; set; }

    /// <summary>
    /// NumericID of a customer
    /// </summary>
    /// <value>NumericID of a customer</value>
    [DataMember(Name="CustomerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerId")]
    public string CustomerId { get; set; }

    /// <summary>
    /// VATID of a customer
    /// </summary>
    /// <value>VATID of a customer</value>
    [DataMember(Name="CompanyVatId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyVatId")]
    public string CompanyVatId { get; set; }

    /// <summary>
    /// Department name if SplitByDepartment = true
    /// </summary>
    /// <value>Department name if SplitByDepartment = true</value>
    [DataMember(Name="DepartmentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DepartmentName")]
    public string DepartmentName { get; set; }

    /// <summary>
    /// Unique invoice number
    /// </summary>
    /// <value>Unique invoice number</value>
    [DataMember(Name="InvoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// The company sales manager
    /// </summary>
    /// <value>The company sales manager</value>
    [DataMember(Name="Salesman", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Salesman")]
    public string Salesman { get; set; }

    /// <summary>
    /// Reseller Contract ID
    /// </summary>
    /// <value>Reseller Contract ID</value>
    [DataMember(Name="ResellerContractId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResellerContractId")]
    public string ResellerContractId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Invoice {\n");
      sb.Append("  BillingInterval: ").Append(BillingInterval).Append("\n");
      sb.Append("  Charges: ").Append(Charges).Append("\n");
      sb.Append("  CompanyAccountId: ").Append(CompanyAccountId).Append("\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
      sb.Append("  CompanyVatId: ").Append(CompanyVatId).Append("\n");
      sb.Append("  DepartmentName: ").Append(DepartmentName).Append("\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  Salesman: ").Append(Salesman).Append("\n");
      sb.Append("  ResellerContractId: ").Append(ResellerContractId).Append("\n");
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
