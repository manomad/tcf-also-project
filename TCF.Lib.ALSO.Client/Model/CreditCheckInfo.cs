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
  public class CreditCheckInfo {
    /// <summary>
    /// Gets or Sets RequestId
    /// </summary>
    [DataMember(Name="RequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestId")]
    public int? RequestId { get; set; }

    /// <summary>
    /// Gets or Sets QuoteId
    /// </summary>
    [DataMember(Name="QuoteId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuoteId")]
    public string QuoteId { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name="CreatedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedBy")]
    public int? CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets CreatedByDisplayName
    /// </summary>
    [DataMember(Name="CreatedByDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByDisplayName")]
    public string CreatedByDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="CreationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreationDate")]
    public string CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets MethodName
    /// </summary>
    [DataMember(Name="MethodName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MethodName")]
    public decimal? MethodName { get; set; }

    /// <summary>
    /// Gets or Sets BillableFields
    /// </summary>
    [DataMember(Name="BillableFields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillableFields")]
    public Dictionary<string, Object> BillableFields { get; set; }

    /// <summary>
    /// Gets or Sets PayerAccountId
    /// </summary>
    [DataMember(Name="PayerAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayerAccountId")]
    public int? PayerAccountId { get; set; }

    /// <summary>
    /// Gets or Sets PayerCompanyName
    /// </summary>
    [DataMember(Name="PayerCompanyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayerCompanyName")]
    public string PayerCompanyName { get; set; }

    /// <summary>
    /// Gets or Sets PayerCurrency
    /// </summary>
    [DataMember(Name="PayerCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayerCurrency")]
    public string PayerCurrency { get; set; }

    /// <summary>
    /// Gets or Sets PayerContractId
    /// </summary>
    [DataMember(Name="PayerContractId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayerContractId")]
    public string PayerContractId { get; set; }

    /// <summary>
    /// Gets or Sets EndCustomerAccountId
    /// </summary>
    [DataMember(Name="EndCustomerAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndCustomerAccountId")]
    public decimal? EndCustomerAccountId { get; set; }

    /// <summary>
    /// Gets or Sets EndCustomerName
    /// </summary>
    [DataMember(Name="EndCustomerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndCustomerName")]
    public string EndCustomerName { get; set; }

    /// <summary>
    /// Gets or Sets ProductName
    /// </summary>
    [DataMember(Name="ProductName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductName")]
    public string ProductName { get; set; }

    /// <summary>
    /// Gets or Sets ProductDisplayName
    /// </summary>
    [DataMember(Name="ProductDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductDisplayName")]
    public string ProductDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ExecutionDate
    /// </summary>
    [DataMember(Name="ExecutionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExecutionDate")]
    public string ExecutionDate { get; set; }

    /// <summary>
    /// Gets or Sets ErrorMessage
    /// </summary>
    [DataMember(Name="ErrorMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErrorMessage")]
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Gets or Sets CurrentLimit
    /// </summary>
    [DataMember(Name="CurrentLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CurrentLimit")]
    public decimal? CurrentLimit { get; set; }

    /// <summary>
    /// Gets or Sets ProjectedInvoice
    /// </summary>
    [DataMember(Name="ProjectedInvoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProjectedInvoice")]
    public decimal? ProjectedInvoice { get; set; }

    /// <summary>
    /// Gets or Sets DailyTransactions
    /// </summary>
    [DataMember(Name="DailyTransactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DailyTransactions")]
    public decimal? DailyTransactions { get; set; }

    /// <summary>
    /// Gets or Sets TransactionValue
    /// </summary>
    [DataMember(Name="TransactionValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransactionValue")]
    public decimal? TransactionValue { get; set; }

    /// <summary>
    /// Gets or Sets ApprovalStatus
    /// </summary>
    [DataMember(Name="ApprovalStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApprovalStatus")]
    public string ApprovalStatus { get; set; }

    /// <summary>
    /// Gets or Sets StatusDate
    /// </summary>
    [DataMember(Name="StatusDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StatusDate")]
    public string StatusDate { get; set; }

    /// <summary>
    /// Gets or Sets StatusUpdatedBy
    /// </summary>
    [DataMember(Name="StatusUpdatedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StatusUpdatedBy")]
    public int? StatusUpdatedBy { get; set; }

    /// <summary>
    /// Gets or Sets StatusUpdatedByDisplayName
    /// </summary>
    [DataMember(Name="StatusUpdatedByDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StatusUpdatedByDisplayName")]
    public string StatusUpdatedByDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Comment
    /// </summary>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Gets or Sets Attachments
    /// </summary>
    [DataMember(Name="Attachments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Attachments")]
    public List<CreditLimitRecordAttachment> Attachments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreditCheckInfo {\n");
      sb.Append("  RequestId: ").Append(RequestId).Append("\n");
      sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  CreatedByDisplayName: ").Append(CreatedByDisplayName).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  MethodName: ").Append(MethodName).Append("\n");
      sb.Append("  BillableFields: ").Append(BillableFields).Append("\n");
      sb.Append("  PayerAccountId: ").Append(PayerAccountId).Append("\n");
      sb.Append("  PayerCompanyName: ").Append(PayerCompanyName).Append("\n");
      sb.Append("  PayerCurrency: ").Append(PayerCurrency).Append("\n");
      sb.Append("  PayerContractId: ").Append(PayerContractId).Append("\n");
      sb.Append("  EndCustomerAccountId: ").Append(EndCustomerAccountId).Append("\n");
      sb.Append("  EndCustomerName: ").Append(EndCustomerName).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
      sb.Append("  ProductDisplayName: ").Append(ProductDisplayName).Append("\n");
      sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  CurrentLimit: ").Append(CurrentLimit).Append("\n");
      sb.Append("  ProjectedInvoice: ").Append(ProjectedInvoice).Append("\n");
      sb.Append("  DailyTransactions: ").Append(DailyTransactions).Append("\n");
      sb.Append("  TransactionValue: ").Append(TransactionValue).Append("\n");
      sb.Append("  ApprovalStatus: ").Append(ApprovalStatus).Append("\n");
      sb.Append("  StatusDate: ").Append(StatusDate).Append("\n");
      sb.Append("  StatusUpdatedBy: ").Append(StatusUpdatedBy).Append("\n");
      sb.Append("  StatusUpdatedByDisplayName: ").Append(StatusUpdatedByDisplayName).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
