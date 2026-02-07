import { useSession, signIn, signOut } from "next-auth/react";
import {
  EuiButton,
  EuiFlexGroup,
  EuiFlexItem,
  EuiText,
  EuiAvatar,
  EuiSpacer,
} from '@elastic/eui';

export default function LoginButton() {
  const { data: session } = useSession();

  if (session) {
    return (
      <EuiFlexGroup direction="column" gutterSize="s" alignItems="center">
        <EuiFlexItem>
          <EuiAvatar
            size="l"
            name={session?.user?.name || 'User'}
            imageUrl={session?.user?.image || ""}
          />
        </EuiFlexItem>
        <EuiFlexItem>
          <EuiText size="s" textAlign="center">
            <strong>{session?.user?.name || 'User'}</strong>
          </EuiText>
        </EuiFlexItem>
        <EuiFlexItem>
          <EuiButton
            size="s"
            color="danger"
            fullWidth
            onClick={() => signOut()}
          >
            Logout
          </EuiButton>
        </EuiFlexItem>
      </EuiFlexGroup>
    );
  }

  return (
    <EuiFlexGroup direction="column" gutterSize="s" alignItems="center">
      <EuiFlexItem>
        <EuiText size="s" color="subdued" textAlign="center">
          Not signed in
        </EuiText>
      </EuiFlexItem>
      <EuiFlexItem>
        <EuiButton
          size="s"
          fill
          fullWidth
          onClick={() => signIn()}
        >
          Login
        </EuiButton>
      </EuiFlexItem>
    </EuiFlexGroup>
  );
}