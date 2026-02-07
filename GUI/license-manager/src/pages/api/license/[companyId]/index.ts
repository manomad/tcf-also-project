import LicenseService from "@/lib/services/licenseService";
import { NextApiRequest, NextApiResponse } from "next";

/**
 * Handler for REST call for path - /api/license
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
    const { companyId } = req.query;
    const companyIdNum = parseInt(companyId as string, 0);

    switch (method) {
        case 'GET':
            try {
                const licenses = await LicenseService.getLicensesForCompany(companyIdNum);
                res.status(200).json({
                    success: true,
                    data: licenses,
                });
            }
            catch (error) {
                console.error('Error fetching licenses:', error);
                res.status(500).json({
                    success: false,
                    message: 'Error fetching licenses',
                });
            }
            break;
    }
}