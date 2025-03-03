import {IBaseFilter} from "@/core/domain/interfaces/IBaseFilter";
import {Amenity} from "@/core/domain/entities/Amenity.ts";
import {Tag} from "@/core/domain/entities/Tag.ts";
import {Image} from "@/core/domain/entities/Image.ts";
import {Room} from "@/core/domain/entities/Room.ts";
import {Owner} from "@/core/domain/entities/User.ts";
import {Category} from "@/core/domain/entities/Category.ts";

export interface Dorm extends DormListing {
    description: string;
    owner: Owner;
    latitude: number;
    longitude: number;
    category: Category;
    rooms: Room[];
    amenities: Amenity[];
    tags: Tag[];
}


export interface DormListing {
    id: number;
    name: string;
    address: string;
    ownerId: string;
    isAvailable: boolean;
    isVerified: boolean;
    minPrice: number;
    availableRooms: number;
    rating: number;
    images: Image[];
    categoryName: string;
}

export interface DormFilter extends IBaseFilter {
    ownerId?: string;
    categoryId?: number;
    minPrice?: number;
    maxPrice?: number;
    amenityIds?: number[];
    tagIds?: number[];
}
