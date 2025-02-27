export interface IBaseFilter {
    page?: number;
    pageSize?: number;
    sortBy?: string;
    isDescending?: boolean;
    includeDeleted?: boolean;
}