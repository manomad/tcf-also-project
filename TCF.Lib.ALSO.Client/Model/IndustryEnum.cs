using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Possible industry values. Note the encoding symbol at the end is required on some of the values.
  /// </summary>
  [DataContract]
    public enum IndustryEnum
    {
        [EnumMember(Value = "Accommodation and Food Services")]
#pragma warning disable CS1591
        AccommodationAndFoodServices,
#pragma warning restore CS1591
        [EnumMember(Value = "Administrative and Support and Waste Management and Remediation Services")]
#pragma warning disable CS1591
        AdministrativeAndSupportAndWasteManagementAndRemediationServices,
#pragma warning restore CS1591
        [EnumMember(Value = "Agriculture, Forestry, Fishing and Hunting")]
#pragma warning disable CS1591
        AgricultureForestryFishingAndHunting,
#pragma warning restore CS1591
        [EnumMember(Value = "Arts, Entertainment, and Recreation")]
#pragma warning disable CS1591
        ArtsEntertainmentAndRecreation,
#pragma warning restore CS1591
        [EnumMember(Value = "Construction")]
#pragma warning disable CS1591
        Construction,
#pragma warning restore CS1591
        [EnumMember(Value = "Educational Services")]
#pragma warning disable CS1591
        EducationalServices,
#pragma warning restore CS1591
        [EnumMember(Value = "Finance and Insurance")]
#pragma warning disable CS1591
        FinanceAndInsurance,
#pragma warning restore CS1591
        [EnumMember(Value = "Health Care and Social Assistance")]
#pragma warning disable CS1591
        HealthCareAndSocialAssistance,
#pragma warning restore CS1591
        [EnumMember(Value = "Information")]
#pragma warning disable CS1591
        Information,
#pragma warning restore CS1591
        [EnumMember(Value = "Management of Companies and Enterprises")]
#pragma warning disable CS1591
        ManagementOfCompaniesAndEnterprises,
#pragma warning restore CS1591
        [EnumMember(Value = "Manufacturing")]
#pragma warning disable CS1591
        Manufacturing,
#pragma warning restore CS1591
        [EnumMember(Value = "Mining, Quarrying, and Oil and Gas Extraction")]
#pragma warning disable CS1591
        MiningQuarryingAndOilAndGasExtraction,
#pragma warning restore CS1591
        [EnumMember(Value = "Other Services (except Public Administration")]
#pragma warning disable CS1591
        OtherServicesExceptPublicAdministration,
#pragma warning restore CS1591
        [EnumMember(Value = "Professional, Scientific, and Technical Service")]
#pragma warning disable CS1591
        ProfessionalScientificAndTechnicalService,
#pragma warning restore CS1591
        [EnumMember(Value = "Public Administration")]
#pragma warning disable CS1591
        PublicAdministration,
#pragma warning restore CS1591
        [EnumMember(Value = "Real Estate and Rental and Leasing")]
#pragma warning disable CS1591
        RealEstateAndRentalAndLeasing,
#pragma warning restore CS1591
        [EnumMember(Value = "Retail Trade")]
#pragma warning disable CS1591
        RetailTrade,
#pragma warning restore CS1591
        [EnumMember(Value = "Transportation and Warehousing")]
#pragma warning disable CS1591
        TransportationAndWarehousing,
#pragma warning restore CS1591
        [EnumMember(Value = "Utilities")]
#pragma warning disable CS1591
        Utilities,
#pragma warning restore CS1591
        [EnumMember(Value = "Wholesale Trade")]
#pragma warning disable CS1591
        WholesaleTrade,
#pragma warning restore CS1591
    }
}
