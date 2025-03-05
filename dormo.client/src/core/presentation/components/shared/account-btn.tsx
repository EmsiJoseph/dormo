import {
  Avatar,
  AvatarFallback,
  AvatarImage,
} from "@/core/presentation/components/ui/avatar";
import User from "@/assets/user.svg";
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuItem,
  DropdownMenuSeparator,
  DropdownMenuTrigger,
} from "@/core/presentation/components/ui/dropdown-menu";
import { useSelector } from "react-redux";
import { RootState } from "@/core/application/store/store";
import { useAppDispatch } from "@/core/presentation/hooks/use-app-dispatch";
import { useNavigate } from "@tanstack/react-router";
import {
  unauthorizedMenu,
  tenantMenu,
  ownerMenu,
} from "../../../application/configs/menu-configs";
import { Roles } from "@/core/application/constants/roles";
import { openAuthModal } from "@/core/application/store/auth-modal/auth-modal-slice";
import React from "react";
import { AuthApi } from "@/core/data/api/auth-api";
import { checkAuthStatus } from "@/core/application/store/auth/auth-slice";
import {
  AlertDialog,
  AlertDialogAction,
  AlertDialogCancel,
  AlertDialogContent,
  AlertDialogDescription,
  AlertDialogFooter,
  AlertDialogHeader,
  AlertDialogTitle,
  AlertDialogTrigger,
} from "@/core/presentation/components/ui/alert-dialog.tsx";

export default function AccountBtn() {
  const dispatch = useAppDispatch();
  const navigate = useNavigate();

  const { user, isAuthenticated } = useSelector(
    (state: RootState) => state.auth
  );

  const handleMenuItemClick = async (href: string) => {
    if (href === "/auth") {
      if (!isAuthenticated) {
        // Pass returnPath as an object parameter
        dispatch(openAuthModal({ returnPath: "/" }));
        return;
      }
    }
    navigate({ to: href });
  };

  const handleLogout = async () => {
    // Call the logout API
    await AuthApi.logout();

    // Update the auth state in the Redux store
    await dispatch(checkAuthStatus()).unwrap();

    window.location.reload();
  };

  const renderMenuItems = () => {
    const menuConfig = !isAuthenticated
      ? unauthorizedMenu
      : user?.role === Roles.TENANT
        ? tenantMenu
        : ownerMenu;

    return (
      <>
        {menuConfig.items.map((item, index) => (
          <React.Fragment key={item.label}>
            {menuConfig.separatorIndices.includes(index) && (
              <DropdownMenuSeparator />
            )}
            <DropdownMenuItem
              className={`${item.className || ""}`}
              onClick={() => handleMenuItemClick(item.href)}
            >
              {item.label}
            </DropdownMenuItem>
          </React.Fragment>
        ))}
      </>
    );
  };

  return (
    <DropdownMenu>
      <DropdownMenuTrigger asChild>
        <Avatar className="h-12 w-12 border-2 border-accent-background flex items-center justify-center cursor-pointer">
          {isAuthenticated && user ? (
            <>
              <AvatarImage src={user.profileImageUrl} className="h-4 w-4" />
              <AvatarFallback className="bg-background font-medium">
                {`${user.firstName[0]}${user.lastName[0]}`.toUpperCase()}
              </AvatarFallback>
            </>
          ) : (
            <AvatarImage src={User} className="h-4 w-4" />
          )}
        </Avatar>
      </DropdownMenuTrigger>
      <DropdownMenuContent align="end" className="mt-2 py-2 w-64 rounded-2xl">
        {renderMenuItems()}
        {isAuthenticated && user && (
          <>
            <DropdownMenuSeparator />

            <AlertDialog>
              <AlertDialogTrigger asChild>
                {/* Add onSelect to prevent the dropdown from closing */}
                <DropdownMenuItem
                  onSelect={(e) => e.preventDefault()} // Prevent the dropdown from closing
                  className="text-destructive hover:bg-destructive/10 data-[highlighted]:text-destructive data-[highlighted]:bg-destructive/10"
                >
                  Log out
                </DropdownMenuItem>
              </AlertDialogTrigger>
              <AlertDialogContent>
                <AlertDialogHeader>
                  <AlertDialogTitle>
                    Are you sure you want to log out?
                  </AlertDialogTitle>
                  <AlertDialogDescription>
                    We hope to see you again soon! Logging out will end your
                    current session.
                  </AlertDialogDescription>
                </AlertDialogHeader>
                <AlertDialogFooter>
                  <AlertDialogCancel>Close</AlertDialogCancel>
                  <AlertDialogAction
                    className="text-white bg-destructive hover:bg-destructive/90"
                    onClick={handleLogout}
                  >
                    Log Out
                  </AlertDialogAction>
                </AlertDialogFooter>
              </AlertDialogContent>
            </AlertDialog>
          </>
        )}
      </DropdownMenuContent>
    </DropdownMenu>
  );
}
