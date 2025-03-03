import {useQuery} from '@tanstack/react-query';
import {DormApi} from '@/core/data/api/dorm-api';
import {DormFilter} from '@/core/domain/entities/Dorm';

export function useDormListings(filter?: DormFilter) {
    return useQuery({
        queryKey: ['dorms', filter],
        queryFn: async () => {
            const response = await DormApi.getAll(filter);
            return response.data;
        },
        staleTime: 5 * 60 * 1000,
        gcTime: 30 * 60 * 1000,
        refetchOnWindowFocus: false,
    });
}
