import '@/styles/globals.css'
import type { AppProps } from 'next/app'
import { EuiProvider } from '@elastic/eui';
import { SessionProvider } from 'next-auth/react';
import MainLayout from '@/components/MainLayout';

export default function App({
  Component,
  pageProps: { session, ...pageProps },
}: AppProps) {

  return (
    <SessionProvider session={session}>
      <EuiProvider colorMode="light">
        <MainLayout>
          <Component {...pageProps} />
        </MainLayout>
      </EuiProvider>
    </SessionProvider>
  );
}
