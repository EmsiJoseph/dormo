﻿export interface PaginatedDto<T> {
    items: T[];
    totalItems: number;
    page: number;
    pageSize: number;
    nextPage: number | null;
}