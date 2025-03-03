import {Avatar, AvatarFallback, AvatarImage} from "@/core/presentation/components/ui/avatar.tsx";
import User from "@/assets/user.svg";
import {
    DropdownMenu,
    DropdownMenuContent,
    DropdownMenuItem,
    DropdownMenuSeparator,
    DropdownMenuTrigger
} from "@/core/presentation/components/ui/dropdown-menu.tsx";
import {useSelector} from "react-redux";
import {RootState} from "@/core/application/store/store.ts";
import {useAppDispatch} from "@/core/presentation/hooks/use-app-dispatch.ts";
import {useNavigate} from "@tanstack/react-router";
import {unauthorizedMenu, tenantMenu, ownerMenu} from "../../../application/configs/menu-configs.ts";
import {Roles} from "@/core/application/constants/roles.ts";
import {openAuthModal} from "@/core/application/store/auth-modal/auth-modal-slice.ts";
import React from "react";

export default function AccountBtn() {
    const dispatch = useAppDispatch();
    const navigate = useNavigate();
    const {user, isAuthenticated} = useSelector((state: RootState) => state.auth);

    const handleMenuItemClick = async (href: string) => {
        if (href === '/auth') {
            if (!isAuthenticated) {
                dispatch(openAuthModal({returnPath: '/'}));
                return;
            }
        }
        navigate({to: href});
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
                        {menuConfig.separatorIndices.includes(index) && <DropdownMenuSeparator/>}
                        <DropdownMenuItem
                            className={`${item.className || ''}`}
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
                <Avatar
                    className="h-12 w-12 border-2 border-accent-background flex items-center justify-center cursor-pointer">
                    {isAuthenticated && user ? (
                        <>
                            <AvatarImage src={user.profileImageUrl} className="h-4 w-4"/>
                            <AvatarFallback className="bg-background font-medium">
                                {`${user.firstName[0]}${user.lastName[0]}`.toUpperCase()}
                            </AvatarFallback>
                        </>
                    ) : (
                        <AvatarImage src={User} className="h-4 w-4"/>
                    )}
                </Avatar>
            </DropdownMenuTrigger>
            <DropdownMenuContent align="end" className="mt-2 py-2 w-64 rounded-2xl">
                {renderMenuItems()}
                {isAuthenticated && user && (
                    <>
                        <DropdownMenuSeparator/>

                        <DropdownMenuItem
                            className="text-destructive hover:bg-destructive/10 data-[highlighted]:text-destructive data-[highlighted]:bg-destructive/10"
                            onClick={() => console.log("TODO")}
                        >
                            Log out
                        </DropdownMenuItem>
                    </>
                )}
            </DropdownMenuContent>
        </DropdownMenu>
    );
}