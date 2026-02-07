import LicenseService from "@/lib/services/licenseService";
import { NextApiRequest, NextApiResponse } from "next";

/**
 * Handler for REST call for path - /api/company
 *
 *
 * @param req - Request
 * @param res  - Response
 */
export default async function handler(
    req: NextApiRequest,
    res: NextApiResponse
) {
    const { method } = req;

    switch (method) {
        case 'GET':
            try {
                const companies = await LicenseService.getCompanies();
                res.status(200).json({
                    success: true,
                    data: companies,
                });
            }
            catch (error) {
                console.error('Error fetching companies:', error);
                res.status(500).json({
                    success: false,
                    message: 'Error fetching companies',
                });
            }
            break;
    }
}