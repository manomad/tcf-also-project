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
  public class ServiceCharge {
    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Gets or Sets ActualChargeInterval
    /// </summary>
    [DataMember(Name="ActualChargeInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActualChargeInterval")]
    public string ActualChargeInterval { get; set; }

    /// <summary>
    /// Gets or Sets BillableParameter
    /// </summary>
    [DataMember(Name="BillableParameter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillableParameter")]
    public string BillableParameter { get; set; }

    /// <summary>
    /// Gets or Sets BillingStartDate
    /// </summary>
    [DataMember(Name="BillingStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingStartDate")]
    public string BillingStartDate { get; set; }

    /// <summary>
    /// ContractId field value that is set on subscription level
    /// </summary>
    /// <value>ContractId field value that is set on subscription level</value>
    [DataMember(Name="ContractId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContractId")]
    public string ContractId { get; set; }

    /// <summary>
    /// Subscription purchase order number
    /// </summary>
    /// <value>Subscription purchase order number</value>
    [DataMember(Name="PurchaseOrderNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PurchaseOrderNumber")]
    public string PurchaseOrderNumber { get; set; }

    /// <summary>
    /// purchase price of subscription
    /// </summary>
    /// <value>purchase price of subscription</value>
    [DataMember(Name="Costs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Costs")]
    public decimal? Costs { get; set; }

    /// <summary>
    /// purchase price of unit
    /// </summary>
    /// <value>purchase price of unit</value>
    [DataMember(Name="CostsOfUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CostsOfUnit")]
    public decimal? CostsOfUnit { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="Currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Currency")]
    public string Currency { get; set; }

    /// <summary>
    /// External Vendor reference for subscription.
    /// </summary>
    /// <value>External Vendor reference for subscription.</value>
    [DataMember(Name="VendorReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VendorReference")]
    public string VendorReference { get; set; }

    /// <summary>
    /// External Vendor reference for subscription (vendor can make alternative second vendor reference field) 
    /// </summary>
    /// <value>External Vendor reference for subscription (vendor can make alternative second vendor reference field) </value>
    [DataMember(Name="SecondVendorReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondVendorReference")]
    public string SecondVendorReference { get; set; }

    /// <summary>
    /// Gets or Sets MaterialNumber
    /// </summary>
    [DataMember(Name="MaterialNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaterialNumber")]
    public string MaterialNumber { get; set; }

    /// <summary>
    /// Gets or Sets PriceableItemDescription
    /// </summary>
    [DataMember(Name="PriceableItemDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceableItemDescription")]
    public string PriceableItemDescription { get; set; }

    /// <summary>
    /// sales price of subscription
    /// </summary>
    /// <value>sales price of subscription</value>
    [DataMember(Name="SalesPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SalesPrice")]
    public decimal? SalesPrice { get; set; }

    /// <summary>
    /// sales price of unit
    /// </summary>
    /// <value>sales price of unit</value>
    [DataMember(Name="SalesPriceOfUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SalesPriceOfUnit")]
    public decimal? SalesPriceOfUnit { get; set; }

    /// <summary>
    /// custom product code
    /// </summary>
    /// <value>custom product code</value>
    [DataMember(Name="ServiceCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceCode")]
    public string ServiceCode { get; set; }

    /// <summary>
    /// internal technical product name of a service
    /// </summary>
    /// <value>internal technical product name of a service</value>
    [DataMember(Name="ServiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceId")]
    public string ServiceId { get; set; }

    /// <summary>
    /// display name of a service
    /// </summary>
    /// <value>display name of a service</value>
    [DataMember(Name="ServiceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceName")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Internal id of priceable item
    /// </summary>
    /// <value>Internal id of priceable item</value>
    [DataMember(Name="PriceableItemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceableItemId")]
    public int? PriceableItemId { get; set; }

    /// <summary>
    /// Type of priceable item
    /// </summary>
    /// <value>Type of priceable item</value>
    [DataMember(Name="PriceableItemType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceableItemType")]
    public string PriceableItemType { get; set; }

    /// <summary>
    /// Vendor product number (SKU)
    /// </summary>
    /// <value>Vendor product number (SKU)</value>
    [DataMember(Name="ProductNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductNumber")]
    public string ProductNumber { get; set; }

    /// <summary>
    /// If billable item is unit based then it contains amount of units
    /// </summary>
    /// <value>If billable item is unit based then it contains amount of units</value>
    [DataMember(Name="UDRCValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UDRCValue")]
    public decimal? UDRCValue { get; set; }

    /// <summary>
    /// Vendor display name
    /// </summary>
    /// <value>Vendor display name</value>
    [DataMember(Name="VendorName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VendorName")]
    public string VendorName { get; set; }

    /// <summary>
    /// Sap Invoice Number
    /// </summary>
    /// <value>Sap Invoice Number</value>
    [DataMember(Name="SAPInvoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SAPInvoiceNumber")]
    public string SAPInvoiceNumber { get; set; }

    /// <summary>
    /// SAP invoice line number
    /// </summary>
    /// <value>SAP invoice line number</value>
    [DataMember(Name="SAPInvoiceLineNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SAPInvoiceLineNumber")]
    public decimal? SAPInvoiceLineNumber { get; set; }

    /// <summary>
    /// Name of customer
    /// </summary>
    /// <value>Name of customer</value>
    [DataMember(Name="EndCustomerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndCustomerName")]
    public string EndCustomerName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceCharge {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  ActualChargeInterval: ").Append(ActualChargeInterval).Append("\n");
      sb.Append("  BillableParameter: ").Append(BillableParameter).Append("\n");
      sb.Append("  BillingStartDate: ").Append(BillingStartDate).Append("\n");
      sb.Append("  ContractId: ").Append(ContractId).Append("\n");
      sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
      sb.Append("  Costs: ").Append(Costs).Append("\n");
      sb.Append("  CostsOfUnit: ").Append(CostsOfUnit).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  VendorReference: ").Append(VendorReference).Append("\n");
      sb.Append("  SecondVendorReference: ").Append(SecondVendorReference).Append("\n");
      sb.Append("  MaterialNumber: ").Append(MaterialNumber).Append("\n");
      sb.Append("  PriceableItemDescription: ").Append(PriceableItemDescription).Append("\n");
      sb.Append("  SalesPrice: ").Append(SalesPrice).Append("\n");
      sb.Append("  SalesPriceOfUnit: ").Append(SalesPriceOfUnit).Append("\n");
      sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
      sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  PriceableItemId: ").Append(PriceableItemId).Append("\n");
      sb.Append("  PriceableItemType: ").Append(PriceableItemType).Append("\n");
      sb.Append("  ProductNumber: ").Append(ProductNumber).Append("\n");
      sb.Append("  UDRCValue: ").Append(UDRCValue).Append("\n");
      sb.Append("  VendorName: ").Append(VendorName).Append("\n");
      sb.Append("  SAPInvoiceNumber: ").Append(SAPInvoiceNumber).Append("\n");
      sb.Append("  SAPInvoiceLineNumber: ").Append(SAPInvoiceLineNumber).Append("\n");
      sb.Append("  EndCustomerName: ").Append(EndCustomerName).Append("\n");
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
