import {AxiosConfig} from '@/core/data/axios-config';
import {handleServerResponse} from '@/core/presentation/handlers/api-response-handlers/handle-server-response.ts';
import {Dorm, DormFilter} from '@/core/domain/entities/Dorm';
import {Image} from "@/core/domain/entities/Image";
import {Room} from "@/core/domain/entities/Room";
import {PaginatedDto} from "@/core/domain/entities/PaginatedDto.ts";

const dormEndpoint = "/dorm";
export const DormApi = {
    getAll: async (filter?: DormFilter) => {
        return handleServerResponse<PaginatedDto<Dorm>>({
            request: () => AxiosConfig.get(dormEndpoint, {params: filter}),
            successMessage: 'Dorms fetched successfully'
        });
    },

    getById: async (id: number) => {
        return handleServerResponse<Dorm>({
            request: () => AxiosConfig.get(`${dormEndpoint}/${id}`),
            successMessage: 'Dorm details fetched successfully'
        });
    },

    create: async (dorm: Partial<Dorm>) => {
        return handleServerResponse<Dorm>({
            request: () => AxiosConfig.post(dormEndpoint, dorm),
            successMessage: 'Dorm created successfully'
        });
    },

    update: async (dorm: Partial<Dorm>) => {
        return handleServerResponse<Dorm>({
            request: () => AxiosConfig.put(dormEndpoint, dorm),
            successMessage: 'Dorm updated successfully'
        });
    },

    delete: async (id: number, hard: boolean = false) => {
        return handleServerResponse<void>({
            request: () => AxiosConfig.delete(`${dormEndpoint}/${id}`, {params: {hard}}),
            successMessage: 'Dorm deleted successfully'
        });
    },

    updateImages: async (dormId: number, images: Image[]) => {
        return handleServerResponse<void>({
            request: () => AxiosConfig.put(`${dormEndpoint}/${dormId}/images`, images),
            successMessage: 'Dorm images updated successfully'
        });
    },

    updateRooms: async (dormId: number, rooms: Room[]) => {
        return handleServerResponse<void>({
            request: () => AxiosConfig.put(`${dormEndpoint}/${dormId}/rooms`, rooms),
            successMessage: 'Dorm rooms updated successfully'
        });
    },

    updateMetaData: async (dormId: number, metaDataType: string, metaDataIds: number[]) => {
        return handleServerResponse<void>({
            request: () => AxiosConfig.put(`${dormEndpoint}/${dormId}/${metaDataType}`, metaDataIds),
            successMessage: `Dorm ${metaDataType} updated successfully`
        });
    }
};
