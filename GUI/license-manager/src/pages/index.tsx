import Head from 'next/head';
import {
  EuiTitle,
  EuiText,
  EuiPanel,
  EuiSpacer,
  EuiFlexGroup,
  EuiFlexItem,
  EuiStat,
  EuiCard,
} from '@elastic/eui';

export default function Home() {
  return (
    <>
      <Head>
        <title>License Manager - Dashboard</title>
        <meta name="description" content="License Management Dashboard" />
      </Head>

      <EuiTitle size="l">
        <h1>Dashboard</h1>
      </EuiTitle>

      <EuiSpacer size="l" />

      <EuiFlexGroup>
        <EuiFlexItem>
          <EuiPanel>
            <EuiStat
              title="245"
              description="Total Licenses"
              titleColor="primary"
            />
          </EuiPanel>
        </EuiFlexItem>

        <EuiFlexItem>
          <EuiPanel>
            <EuiStat
              title="189"
              description="Active Licenses"
              titleColor="success"
            />
          </EuiPanel>
        </EuiFlexItem>

        <EuiFlexItem>
          <EuiPanel>
            <EuiStat
              title="56"
              description="Expired Licenses"
              titleColor="danger"
            />
          </EuiPanel>
        </EuiFlexItem>
      </EuiFlexGroup>

      <EuiSpacer size="xl" />

      <EuiTitle size="m">
        <h2>Recent Activity</h2>
      </EuiTitle>

      <EuiSpacer size="m" />

      <EuiFlexGroup>
        <EuiFlexItem>
          <EuiCard
            title="License Renewals"
            description="12 licenses expiring in the next 30 days"
          />
        </EuiFlexItem>

        <EuiFlexItem>
          <EuiCard
            title="New Registrations"
            description="8 new licenses registered this week"
          />
        </EuiFlexItem>
      </EuiFlexGroup>
    </>
  );
}
