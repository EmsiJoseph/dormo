import { BusinessRules } from './business-rules.ts';
import { formatCurrency } from '@/lib/utils/currency.ts';

export const SystemMessages = {
    // Success messages
    CREATE_SUCCESS: "Great! Your listing has been created successfully. 🎉",
    UPDATE_SUCCESS: "Perfect! Your changes have been saved. ✨",
    DELETE_SUCCESS: "Your listing has been removed successfully.",
    
    // Error messages
    BAD_REQUEST: "Hmm, something's not right. Please check your input and try again.",
    GENERIC_ERROR: "Oops! Something didn't go as planned. Let's try that again.",
    NETWORK_ERROR: "Hmm, we're having trouble connecting. Please check your internet connection.",
    UNAUTHORIZED: "Please sign in to continue. Your session may have expired.",
    FORBIDDEN: "Looks like you don't have permission to do that.",
    NOT_FOUND: "We couldn't find what you're looking for. It might have been moved or deleted.",
    
    // Validation messages
    VALIDATION: {
        REQUIRED_FIELD: (field: string) => `Don't forget to add ${field.toLowerCase()}!`,
        INVALID_FORMAT: (field: string) => `That ${field.toLowerCase()} doesn't look quite right.`,
        DUPLICATE: (field: string) => `This ${field.toLowerCase()} is already taken.`,
        PRICE_RANGE: `The price should be between ${formatCurrency(BusinessRules.ROOM.MIN_PRICE)} and ${formatCurrency(BusinessRules.ROOM.MAX_PRICE)} per month.`,
        IMAGE_COUNT: `Please add between ${BusinessRules.DORM.MIN_IMAGES} and ${BusinessRules.DORM.MAX_IMAGES} photos of your property.`,
        ROOM_COUNT: `Your property should have between ${BusinessRules.DORM.MIN_ROOMS} and ${BusinessRules.DORM.MAX_ROOMS} rooms.`,
        ROOM_CAPACITY: `Each room can accommodate between ${BusinessRules.ROOM.MIN_CAPACITY} and ${BusinessRules.ROOM.MAX_CAPACITY} persons.`,
        NAME_LENGTH: `Name must be between ${BusinessRules.DORM.NAME_MIN_LENGTH} and ${BusinessRules.DORM.NAME_MAX_LENGTH} characters.`,
        DESCRIPTION_LENGTH: `Description must be between ${BusinessRules.DORM.DESCRIPTION_MIN_LENGTH} and ${BusinessRules.DORM.DESCRIPTION_MAX_LENGTH} characters.`,
        ADDRESS_LENGTH: `Address cannot exceed ${BusinessRules.DORM.ADDRESS_MAX_LENGTH} characters.`,
        LISTING_LIMIT: `You can only create up to ${BusinessRules.DORM.MAX_LISTINGS_PER_HOUR} listings per hour.`,
        COORDINATES: 'Please provide valid coordinates for the location.',
    },

    // Loading states
    LOADING: {
        LISTINGS: "Finding perfect dorms for you...",
        SAVING: "Saving your changes...",
        UPLOADING: "Uploading your photos...",
        DELETING: "Processing your request...",
    }
};
