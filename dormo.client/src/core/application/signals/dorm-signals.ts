import {DormFilter, DormListing} from "@/core/domain/entities/Dorm.ts";
import {signal} from "@preact/signals";

export const AllDormsSignal = signal<DormListing[]>([]);
export const DormFilterSignal = signal<DormFilter>({page: 1});
