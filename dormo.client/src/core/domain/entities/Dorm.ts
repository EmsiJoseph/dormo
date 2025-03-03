import {IBaseFilter} from "@/core/domain/interfaces/IBaseFilter";
import {Amenity} from "@/core/domain/entities/Amenity";
import {Tag} from "@/core/domain/entities/Tag";
import {Image} from "@/core/domain/entities/Image";
import {Room} from "@/core/domain/entities/Room";
import {Owner} from "@/core/domain/entities/User";
import {Category} from "@/core/domain/entities/Category";

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
