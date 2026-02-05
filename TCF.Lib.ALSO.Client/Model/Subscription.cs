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
  public class Subscription {
    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Gets or Sets AccountState
    /// </summary>
    [DataMember(Name="AccountState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountState")]
    public string AccountState { get; set; }

    /// <summary>
    /// Gets or Sets Fields
    /// </summary>
    [DataMember(Name="Fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fields")]
    public List<Field> Fields { get; set; }

    /// <summary>
    /// Gets or Sets ParentAccountId
    /// </summary>
    [DataMember(Name="ParentAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentAccountId")]
    public int? ParentAccountId { get; set; }

    /// <summary>
    /// Gets or Sets CompanyAccountId
    /// </summary>
    [DataMember(Name="CompanyAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyAccountId")]
    public int? CompanyAccountId { get; set; }

    /// <summary>
    /// Gets or Sets ParentType
    /// </summary>
    [DataMember(Name="ParentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentType")]
    public string ParentType { get; set; }

    /// <summary>
    /// Gets or Sets PriceableItems
    /// </summary>
    [DataMember(Name="PriceableItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceableItems")]
    public List<SubscriptionPriceableItem> PriceableItems { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets ErrorDetails
    /// </summary>
    [DataMember(Name="ErrorDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErrorDetails")]
    public string ErrorDetails { get; set; }

    /// <summary>
    /// Gets or Sets VendorReferenceId
    /// </summary>
    [DataMember(Name="VendorReferenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VendorReferenceId")]
    public string VendorReferenceId { get; set; }

    /// <summary>
    /// Gets or Sets SecondVendorReferenceId
    /// </summary>
    [DataMember(Name="SecondVendorReferenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondVendorReferenceId")]
    public string SecondVendorReferenceId { get; set; }

    /// <summary>
    /// Gets or Sets ServiceDisplayName
    /// </summary>
    [DataMember(Name="ServiceDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceDisplayName")]
    public string ServiceDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name="ServiceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceName")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Gets or Sets ContractEndDate
    /// </summary>
    [DataMember(Name="ContractEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContractEndDate")]
    public string ContractEndDate { get; set; }

    /// <summary>
    /// Gets or Sets BillingStartDate
    /// </summary>
    [DataMember(Name="BillingStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingStartDate")]
    public string BillingStartDate { get; set; }

    /// <summary>
    /// Gets or Sets PriceProtectionEndDate
    /// </summary>
    [DataMember(Name="PriceProtectionEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceProtectionEndDate")]
    public string PriceProtectionEndDate { get; set; }

    /// <summary>
    /// Gets or Sets VendorDisplayName
    /// </summary>
    [DataMember(Name="VendorDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VendorDisplayName")]
    public string VendorDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledTerminationDate
    /// </summary>
    [DataMember(Name="ScheduledTerminationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledTerminationDate")]
    public string ScheduledTerminationDate { get; set; }

    /// <summary>
    /// Gets or Sets HasRenewActionValuesConfigured
    /// </summary>
    [DataMember(Name="HasRenewActionValuesConfigured", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasRenewActionValuesConfigured")]
    public bool? HasRenewActionValuesConfigured { get; set; }

    /// <summary>
    /// Gets or Sets RemainingCreditLimit
    /// </summary>
    [DataMember(Name="RemainingCreditLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RemainingCreditLimit")]
    public decimal? RemainingCreditLimit { get; set; }

    /// <summary>
    /// Gets or Sets PurchaseOrderNumber
    /// </summary>
    [DataMember(Name="PurchaseOrderNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PurchaseOrderNumber")]
    public string PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Gets or Sets RenewFields
    /// </summary>
    [DataMember(Name="RenewFields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RenewFields")]
    public List<Field> RenewFields { get; set; }

    /// <summary>
    /// Gets or Sets AdvancePeriodEndDate
    /// </summary>
    [DataMember(Name="AdvancePeriodEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdvancePeriodEndDate")]
    public string AdvancePeriodEndDate { get; set; }

    /// <summary>
    /// Gets or Sets ContractId
    /// </summary>
    [DataMember(Name="ContractId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContractId")]
    public string ContractId { get; set; }

    /// <summary>
    /// Gets or Sets DependencyAccountId
    /// </summary>
    [DataMember(Name="DependencyAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DependencyAccountId")]
    public decimal? DependencyAccountId { get; set; }

    /// <summary>
    /// Gets or Sets DependencyServiceName
    /// </summary>
    [DataMember(Name="DependencyServiceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DependencyServiceName")]
    public string DependencyServiceName { get; set; }

    /// <summary>
    /// Gets or Sets Addons
    /// </summary>
    [DataMember(Name="Addons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Addons")]
    public SubscriptionAddons Addons { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Subscription {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountState: ").Append(AccountState).Append("\n");
      sb.Append("  Fields: ").Append(Fields).Append("\n");
      sb.Append("  ParentAccountId: ").Append(ParentAccountId).Append("\n");
      sb.Append("  CompanyAccountId: ").Append(CompanyAccountId).Append("\n");
      sb.Append("  ParentType: ").Append(ParentType).Append("\n");
      sb.Append("  PriceableItems: ").Append(PriceableItems).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
      sb.Append("  VendorReferenceId: ").Append(VendorReferenceId).Append("\n");
      sb.Append("  SecondVendorReferenceId: ").Append(SecondVendorReferenceId).Append("\n");
      sb.Append("  ServiceDisplayName: ").Append(ServiceDisplayName).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  ContractEndDate: ").Append(ContractEndDate).Append("\n");
      sb.Append("  BillingStartDate: ").Append(BillingStartDate).Append("\n");
      sb.Append("  PriceProtectionEndDate: ").Append(PriceProtectionEndDate).Append("\n");
      sb.Append("  VendorDisplayName: ").Append(VendorDisplayName).Append("\n");
      sb.Append("  ScheduledTerminationDate: ").Append(ScheduledTerminationDate).Append("\n");
      sb.Append("  HasRenewActionValuesConfigured: ").Append(HasRenewActionValuesConfigured).Append("\n");
      sb.Append("  RemainingCreditLimit: ").Append(RemainingCreditLimit).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  RenewFields: ").Append(RenewFields).Append("\n");
      sb.Append("  AdvancePeriodEndDate: ").Append(AdvancePeriodEndDate).Append("\n");
      sb.Append("  ContractId: ").Append(ContractId).Append("\n");
      sb.Append("  DependencyAccountId: ").Append(DependencyAccountId).Append("\n");
      sb.Append("  DependencyServiceName: ").Append(DependencyServiceName).Append("\n");
      sb.Append("  Addons: ").Append(Addons).Append("\n");
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
