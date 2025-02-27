import axios, {AxiosResponse} from "axios";
import {SystemMessages} from "@/core/application/constants/messages";
import {
    IBaseApiResponse,
    IErrorResponse,
    isErrorResponse
} from "@/core/domain/interfaces/IBaseApiResponse";

interface IHandleApiServerSideErrorResponseProps<T> {
    request: () => Promise<AxiosResponse<T>>;
    successMessage?: string;
}

interface ResponseWithMessage<T> extends IBaseApiResponse<T> {
    successMessage?: string;
}

export const handleServerResponse = async <T>({
    request,
    successMessage,
}: IHandleApiServerSideErrorResponseProps<T>): Promise<ResponseWithMessage<T>> => {
    try {
        const response = await request();

        return {
            ...response,
            successMessage,
            data: response.data,
        };
    } catch (error) {
        if (axios.isAxiosError(error)) {
            const errorResponse = error.response?.data;
            
            // If it's our custom error format
            if (isErrorResponse(errorResponse)) {
                throw {
                    statusCode: errorResponse.statusCode,
                    message: errorResponse.message,
                    property: errorResponse.property
                } as IErrorResponse;
            }

            // Handle standard HTTP errors
            const status = error.response?.status ?? 500;
            throw {
                statusCode: status,
                message: getErrorMessage(status),
            } as IErrorResponse;
        }

        // Handle unexpected errors
        throw {
            statusCode: 500,
            message: SystemMessages.GENERIC_ERROR,
        } as IErrorResponse;
    }
};

function getErrorMessage(status: number): string {
    switch (status) {
        case 400: return SystemMessages.BAD_REQUEST;
        case 401: return SystemMessages.UNAUTHORIZED;
        case 403: return SystemMessages.FORBIDDEN;
        case 404: return SystemMessages.NOT_FOUND;
        case 500: return SystemMessages.GENERIC_ERROR;
        default: return SystemMessages.NETWORK_ERROR;
    }
}