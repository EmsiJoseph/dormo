interface MenuItem {
    label: string;
    href: string;
    className?: string;
}

interface MenuConfig {
    items: MenuItem[];
    separatorIndices: number[];
}

export const unauthorizedMenu: MenuConfig = {
    items: [
        {label: 'Login', href: '/auth', className: 'font-medium'},
        {label: 'Sign up', href: '/auth', className: 'font-medium'},
        {label: 'Student Deals', href: '/deals'},
        {label: 'For business', href: '/business'},
        {label: 'Help Center', href: '/help'}
    ],
    separatorIndices: [2]
};

export const tenantMenu: MenuConfig = {
    items: [
        {label: 'Messages', href: '/messages'},
        {label: 'Notifications', href: '/notifications'},
        {label: 'Bookings', href: '/bookings'},
        {label: 'Visits', href: '/visits'},
        {label: 'Favorites', href: '/favorites'},
        {label: 'Student Deals', href: '/deals'},
        {label: 'For business', href: '/business'},
        {label: 'Account', href: '/account'},
        {label: 'Help Center', href: '/help'},
        {label: 'Log out', href: '#', className: 'text-red-600'}
    ],
    separatorIndices: [5, 7, 9]
};

export const ownerMenu: MenuConfig = {
    items: [
        {label: 'Messages', href: '/messages'},
        {label: 'Notifications', href: '/notifications'},
        {label: 'Bookings', href: '/bookings'},
        {label: 'Visits', href: '/visits'},
        {label: 'Favorites', href: '/favorites'},
        {label: 'Student Deals', href: '/deals'},
        {label: 'Manage listings', href: '/listings'},
        {label: 'Account', href: '/account'},
        {label: 'Help Center', href: '/help'},
        {label: 'Log out', href: '#', className: 'text-red-600'}
    ],
    separatorIndices: [5, 7, 9]
};
