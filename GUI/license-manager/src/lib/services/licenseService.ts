import axios from "axios";
import { Company } from "../models/company";

abstract class LicenseService {

    static baseUrl = process.env.LICENSE_MANAGER_API_URL || 'http://localhost:5000/api';    

    static async getCompanies(): Promise<Company[]> {
        try {
            const url = `${this.baseUrl}/LicenseInfo/companies`;
            const response = await axios.get(url);
            return response.data as Company[];
        } catch (error) {
            console.error('Error fetching companies:', error);
            throw error;
        }
    }

    static async getAllLicenses() {
        try {
            const url = `${this.baseUrl}/LicenseInfo`;
            const response = await axios.get(url);
            return response.data;
        } catch (error) {
            console.error('Error fetching licenses:', error);
            throw error;
        }
    }

    static async getLicensesForCompany(companyId: number) {
        try {
            const url = `${this.baseUrl}/LicenseInfo/company/${companyId}`;
            const response = await axios.get(url);
            return response.data;
        } catch (error) {
            console.error(`Error fetching licenses for company ${companyId}:`, error);
            throw error;
        }
    }
}

export default LicenseService;