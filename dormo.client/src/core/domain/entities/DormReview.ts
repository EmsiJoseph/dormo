import {User} from "@/core/domain/entities/User.ts";

export interface DormReview {
    id: number;
    tenant: User;
    rating: number;
    reviewText: string;
    createdAt: Date;
}