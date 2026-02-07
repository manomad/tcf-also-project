import { useState, ReactNode } from 'react';
import { useRouter } from 'next/router';
import {
    EuiPage,
    EuiPageBody,
    EuiPageSidebar,
    EuiSideNav,
    EuiSpacer,
    EuiFlexGroup,
    EuiFlexItem,
    EuiTitle,
    EuiHorizontalRule,
    htmlIdGenerator,
    EuiImage,
    EuiIcon,
} from '@elastic/eui';
import { useSession } from 'next-auth/react';
import LoginButton from './LoginButton';

interface MainLayoutProps {
    children: ReactNode;
}

export default function MainLayout({ children }: MainLayoutProps) {

    const [isSideNavOpenOnMobile, setIsSideNavOpenOnMobile] = useState(false);
    const [selectedItemName, setSelectedItemName] = useState('dashboard');

    const { data: session } = useSession();
    const isAuthenticated = !!session;

    if (!isAuthenticated) {
        return (
            <EuiPage paddingSize="none">
                <EuiPageBody paddingSize="l" panelled>
                    <EuiFlexGroup direction="column" alignItems="center" justifyContent="center" style={{ minHeight: '100vh' }}>
                        <EuiFlexItem grow={false}>
                            <EuiTitle size="l">
                                <h1>Welcome to License Manager</h1>
                            </EuiTitle>
                            <EuiSpacer size="m" />
                            <LoginButton />
                        </EuiFlexItem>
                    </EuiFlexGroup>
                </EuiPageBody>
            </EuiPage>
        );
    }

    const router = useRouter();

    const toggleOpenOnMobile = () => {
        setIsSideNavOpenOnMobile(!isSideNavOpenOnMobile);
    };

    const selectItem = (name: string) => {
        console.log(`Selected item: ${name}`);
        let path = '/';
        switch (name) {
            case 'dashboard':
                path = '/';
                break;
            case 'licenses':
                path = '/licenses';
                break;
            case 'all-licenses':
                path = '/licenses/all-licenses';
                break;
            case 'active-licenses':
                path = '/licenses/active-licenses';
                break;
            case 'expired-licenses':
                path = '/licenses/expired-licenses';
                break;
            case 'users':
                path = '/users';
                break;
            case 'settings':
                path = '/settings';
                break;
            default:
                break;
        }
        console.log(`Navigating to: ${path}`);
        router.push(path);
        setSelectedItemName(name);
    };

    const createItem = (name: string, data = {}) => {
        return {
            ...data,
            id: htmlIdGenerator('sideNavItem')(),
            name,
            isSelected: selectedItemName === name,
        };
    };

    const sideNav = [
        createItem('Dashboard', {
            onClick: () => selectItem('dashboard'),
            icon: <span>📊</span>,
        }),
        createItem('Licenses', {
            onClick: () => selectItem('licenses'),
            icon: <span>📝</span>,
            items: [
                createItem('All Licenses', {
                    onClick: () => selectItem('all-licenses'),
                }),
                createItem('Active Licenses', {
                    onClick: () => selectItem('active-licenses'),
                }),
                createItem('Expired Licenses', {
                    onClick: () => selectItem('expired-licenses'),
                }),
            ],
        }),
        createItem('Users', {
            onClick: () => selectItem('users'),
            icon: <span>👥</span>,
        }),
        createItem('Settings', {
            onClick: () => selectItem('settings'),
            icon: <span>⚙️</span>,
        }),
    ];

    return (
        <EuiPage paddingSize="none">
            <EuiPageSidebar
                paddingSize="l"
                sticky
                minWidth={248}
                style={{ minHeight: '100vh' }}
            >
                <EuiFlexGroup direction="column" gutterSize="none">
                    <EuiFlexItem grow={false}>
                        <EuiImage
                            src="/logo.svg"
                            alt="License Manager Logo"
                            size="m"
                        />
                        <EuiSpacer size="s" />
                        <EuiTitle size="s">
                            <h3>License Manager</h3>
                        </EuiTitle>
                        <EuiSpacer size="m" />
                    </EuiFlexItem>

                    <EuiFlexItem grow={true}>
                        <EuiSideNav
                            aria-label="Main navigation"
                            mobileTitle="Navigation"
                            toggleOpenOnMobile={toggleOpenOnMobile}
                            isOpenOnMobile={isSideNavOpenOnMobile}
                            items={sideNav}
                        />
                    </EuiFlexItem>

                    <EuiFlexItem grow={false}>
                        <EuiHorizontalRule margin="s" />
                        <EuiSpacer size="s" />
                        <LoginButton />
                    </EuiFlexItem>
                </EuiFlexGroup>
            </EuiPageSidebar>

            <EuiPageBody paddingSize="l" panelled>
                {children}
            </EuiPageBody>
        </EuiPage>
    );
}
