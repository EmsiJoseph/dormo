export interface Room {
    id?: number;
    roomNumber: string;
    description: string;
    capacity: number;
    pricePerMonth: number;
    isAvailable: boolean;
}
