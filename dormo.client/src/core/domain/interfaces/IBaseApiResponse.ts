import {AxiosResponse} from "axios";

// Base API Response that extends Axios Response
export interface IBaseApiResponse<T = unknown> extends Omit<AxiosResponse<T>, 'data'> {
    data?: T;
}

// Success response with just a message
export interface ISuccessResponse {
    message: string;
}

// Error response from the server
export interface IErrorResponse {
    statusCode: number;
    message: string;
    property?: string;
}

// Auth status response
export interface IAuthStatusResponse {
    isAuthenticated: boolean;
    userName: string | null;
}

// User details response
export interface IUserResponse extends IOwnerResponse {
    role: string;
    emailSubscription: boolean;
}

export interface IOwnerResponse {
    firstName: string;
    lastName: string;
    email: string;
    id: string;
    preferredFirstName: string;
    birthYear: number;
    contactInfo: string;
    isVerified: boolean;
    profileImageUrl: string;
}

// Type guard functions
export const isErrorResponse = (response: unknown): response is IErrorResponse => {
    return typeof response === 'object' && response !== null && 'statusCode' in response;
};

export const isSuccessResponse = (response: unknown): response is ISuccessResponse => {
    return typeof response === 'object' && response !== null && 'message' in response;
};

export const isAuthStatusResponse = (response: unknown): response is IAuthStatusResponse => {
    return typeof response === 'object' && response !== null && 'isAuthenticated' in response;
};

export const isUserResponse = (response: unknown): response is IUserResponse => {
    return typeof response === 'object' && response !== null && 'firstName' in response;
};
