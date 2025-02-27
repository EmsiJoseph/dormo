import {IBaseFilter} from "@/core/domain/interfaces/IBaseFilter";
import {Amenity} from "@/core/domain/entities/Amenity.ts";
import {Tag} from "@/core/domain/entities/Tag.ts";
import {Image} from "@/core/domain/entities/Image.ts";
import {Room} from "@/core/domain/entities/Room.ts";
import {Owner} from "@/core/domain/entities/User.ts";

export interface Dorm {
    id: number;
    name: string;
    description: string;
    address: string;
    rating: number;
    isVerified: boolean;
    owner: Owner;
    categoryId: number;
    latitude: number;
    longitude: number;
    isAvailable: boolean;
    minPrice: number;
    images: Image[];
    rooms: Room[];
    amenities: Amenity[];
    tags: Tag[];
}

export interface DormFilter extends IBaseFilter {
    ownerId?: string;
    categoryId?: number;
    minPrice?: number;
    maxPrice?: number;
    amenityIds?: number[];
    tagIds?: number[];
}
