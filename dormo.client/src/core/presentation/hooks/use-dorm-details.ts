import { useQuery } from '@tanstack/react-query';
import { DormApi } from '@/core/data/api/dorm-api';

export const useDormDetails = (dormId: number) => {
  return useQuery({
    queryKey: ['dormDetails', dormId],
    queryFn: async() => {
      const response = await DormApi.getById(dormId);
      return response.data;
    },
    enabled: !!dormId,
    staleTime: 5 * 60 * 1000, // 5 minutes
  });
};
