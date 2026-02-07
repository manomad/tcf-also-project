export interface LicenseInfo {
  id: string;
  customerName: string;
  customerAccountId: number;
  country: string;
  sku: string;
  contractType: string;
  salesPrice: number;
  paymentMethod: string;
  numberOfLicenses: number;
  expirationDate: string;
  licenseStatus: string;
  renewalStatus: string;
}
