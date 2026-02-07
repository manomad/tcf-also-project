import { ApiHelper, fetcher } from "@/lib/helpers/apiHelper";
import { Company } from "@/lib/models/company";
import { LicenseInfo } from "@/lib/models/licenseInfo";
import {
    EuiFormLabel,
    EuiLoadingElastic,
    EuiSelect,
    EuiSpacer,
    EuiText,
    EuiTitle,
    EuiDataGrid,
    EuiDataGridColumn,
    EuiDataGridCellValueElementProps,
    EuiDataGridSorting,
    EuiDataGridPaginationProps,
    EuiPanel,
} from "@elastic/eui";
import axios from "axios";
import { useState, useCallback, useMemo, useEffect } from "react";
import useSWR from "swr";


export default function LicensesPage() {

    const [selectedCompanyId, setSelectedCompanyId] = useState(0);
    const [licenses, setLicenses] = useState<LicenseInfo[]>([]);
    const [visibleColumns, setVisibleColumns] = useState<string[]>([
        'id',
        'customerName',
        'sku',
        'numberOfLicenses',
        'salesPrice',
        'expirationDate',
        'licenseStatus',
        'renewalStatus'
    ]);
    const [pagination, setPagination] = useState({ pageIndex: 0, pageSize: 10 });
    const [sortingColumns, setSortingColumns] = useState<EuiDataGridSorting['columns']>([]);

    const url = `/api/company`;
    const { data, error } = useSWR(url, fetcher);

    // Fetch licenses when company is selected
    useEffect(() => {
        if (selectedCompanyId > 0) {
            const fetchLicenses = async () => {
                try {
                    const response = await axios.get(`/api/license/${selectedCompanyId}`);
                    const licensesData = response.data.data as LicenseInfo[] || [];
                    console.log('Fetched licenses:', licensesData);
                    setLicenses(licensesData);
                } catch (error) {
                    console.error('Failed to fetch licenses:', error);
                    setLicenses([]);
                }
            };
            fetchLicenses();
        } else {
            setLicenses([]);
        }
    }, [selectedCompanyId]);

    // Cell renderer
    const renderCellValue = ({ rowIndex, columnId }: EuiDataGridCellValueElementProps) => {
        const license = licenses[rowIndex];
        if (!license) return null;

        const value = license[columnId as keyof LicenseInfo];

        // Format specific columns
        if (columnId === 'expirationDate' && value) {
            return new Date(value as string).toLocaleDateString();
        }

        if (columnId === 'salesPrice' && typeof value === 'number') {
            return `$${value.toFixed(2)}`;
        }

        return value?.toString() || '-';
    };

    const onChangeItemsPerPage = useCallback(
        (pageSize: number) => setPagination(prev => ({ ...prev, pageSize, pageIndex: 0 })),
        []
    );

    const onChangePage = useCallback(
        (pageIndex: number) => setPagination(prev => ({ ...prev, pageIndex })),
        []
    );

    if (error) return <div>Failed to load companies</div>;
    if (!data) return <EuiLoadingElastic size="xxl" />;

    const companies = data.data;

    const options =
        [
            { value: 0, text: 'Select a company' },
            ...companies.map((company: Company) => ({
                value: company.customerAccountId,
                text: company.customerName,
            }))
        ];

    const handleCompanyChange = (e: any) => {
        const companyId = parseInt(e.target.value, 10);
        console.log('Selected company ID:', companyId);
        setSelectedCompanyId(companyId);
    };

    // Define columns for the data grid
    const columns: EuiDataGridColumn[] = [
        { id: 'id', displayAsText: 'License ID', initialWidth: 200 },
        { id: 'customerName', displayAsText: 'Customer Name', initialWidth: 180 },
        { id: 'country', displayAsText: 'Country', initialWidth: 120 },
        { id: 'sku', displayAsText: 'SKU', initialWidth: 200 },
        { id: 'contractType', displayAsText: 'Contract Type', initialWidth: 130 },
        { id: 'salesPrice', displayAsText: 'Price', initialWidth: 100 },
        { id: 'paymentMethod', displayAsText: 'Payment Method', initialWidth: 140 },
        { id: 'numberOfLicenses', displayAsText: '# Licenses', initialWidth: 110 },
        { id: 'expirationDate', displayAsText: 'Expiration Date', initialWidth: 150 },
        { id: 'licenseStatus', displayAsText: 'Status', initialWidth: 120 },
        { id: 'renewalStatus', displayAsText: 'Renewal Status', initialWidth: 140 },
    ];

    const paginationProps: EuiDataGridPaginationProps = {
        ...pagination,
        pageSizeOptions: [10, 25, 50],
        onChangeItemsPerPage,
        onChangePage,
    };

    const sorting: EuiDataGridSorting = {
        columns: sortingColumns,
        onSort: setSortingColumns,
    };

    console.log('Rendering LicensesPage with selectedCompanyId:', selectedCompanyId, "licenses count:", licenses.length);

    return (
        <>
            <EuiTitle size="l">
                <h1>Licenses</h1>
            </EuiTitle>
            <EuiSpacer size="l" />
            <EuiText>
                This is where you can view companies and their licenses. Select a company to see more details about their licenses.
            </EuiText>
            <EuiSpacer size="l" />
            <EuiText size="m"><strong>Select a company:</strong></EuiText>
            <EuiSpacer size="s" />
            <EuiSelect
                options={options}
                aria-label="Select a company"
                value={selectedCompanyId}
                onChange={(e) => handleCompanyChange(e)}
            />
            <EuiSpacer size="l" />

            {licenses.length > 0 ? (
                <>
                    <EuiText size="m"><strong>Licenses ({licenses.length}):</strong></EuiText>
                    <EuiSpacer size="m" />
                    <EuiDataGrid
                        aria-label="License data grid"
                        columns={columns}
                        columnVisibility={{ visibleColumns, setVisibleColumns }}
                        rowCount={licenses.length}
                        renderCellValue={renderCellValue}
                        pagination={paginationProps}
                        sorting={sorting}
                        height={600}
                    />
                </>
            ) : selectedCompanyId > 0 ? (
                <EuiPanel>
                    <EuiText color="subdued" textAlign="center">
                        No licenses found for this company
                    </EuiText>
                </EuiPanel>
            ) : (
                <EuiPanel>
                    <EuiText color="subdued" textAlign="center">
                        Please select a company to view licenses
                    </EuiText>
                </EuiPanel>
            )}
        </>
    );
}