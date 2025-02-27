﻿import {QueryClient} from '@tanstack/react-query';

export const queryClient = new QueryClient({
    defaultOptions: {
        queries: {
            retry: 3,
            refetchOnWindowFocus: false,
            staleTime: 5 * 60 * 1000,
        },
        mutations: {
            onError: (error) => console.error('Mutation error:', error),
        },
    },
});