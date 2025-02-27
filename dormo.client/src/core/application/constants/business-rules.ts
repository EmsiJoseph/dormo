export const BusinessRules = {
    ROOM: {
        MIN_PRICE: 1000,
        MAX_PRICE: 100000,
        MIN_CAPACITY: 1,
        MAX_CAPACITY: 8,
        NUMBER_MAX_LENGTH: 10,
    },
    DORM: {
        NAME_MIN_LENGTH: 3,
        NAME_MAX_LENGTH: 100,
        DESCRIPTION_MIN_LENGTH: 10,
        DESCRIPTION_MAX_LENGTH: 1000,
        ADDRESS_MAX_LENGTH: 200,
        MIN_RATING: 0,
        MAX_RATING: 5,
        MIN_ROOMS: 1,
        MAX_ROOMS: 50,
        MIN_IMAGES: 3,
        MAX_IMAGES: 10,
        MAX_LISTINGS_PER_HOUR: 5,
    },
    COORDINATES: {
        MIN_LATITUDE: -90,
        MAX_LATITUDE: 90,
        MIN_LONGITUDE: -180,
        MAX_LONGITUDE: 180,
    },
} as const;

export const formatCurrency = (amount: number) => 
    new Intl.NumberFormat('en-PH', { 
        style: 'currency', 
        currency: 'PHP',
        minimumFractionDigits: 0,
        maximumFractionDigits: 0,
    }).format(amount);
