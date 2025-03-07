import {DormFilter, DormListingDto} from "@/core/domain/entities/Dorm";
import {signal} from "@preact/signals";

export const AllDormsSignal = signal<DormListingDto[]>([]);
export const DormFilterSignal = signal<DormFilter>({page: 1});
