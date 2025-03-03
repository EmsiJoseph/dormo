import {handleServerResponse} from "@/core/presentation/handlers/api-response-handlers/handle-server-response";
import {AxiosConfig} from "@/core/data/axios-config";
import {
    IAuthStatusResponse,
    ISuccessResponse,
    IUserResponse
} from "@/core/domain/interfaces/IBaseApiResponse";
import {LoginFormValues, RegisterFormValues} from "@/core/domain/schemas/auth-schemas";

const authEndpoint = "/auth";

interface IsRegisteredResponse {
    isRegistered: boolean;
    email: string;
}

type RegisterFormValuesWithStringDob = Omit<RegisterFormValues, 'dob'> & { dob: string };

export const AuthApi = {
    login: async (credentials: LoginFormValues) => {
        return handleServerResponse<ISuccessResponse>({
            request: () => AxiosConfig.post(`${authEndpoint}/login`, credentials),
            successMessage: 'Login successful'
        });
    },

    register: async (data: RegisterFormValuesWithStringDob) => {
        return handleServerResponse<ISuccessResponse>({
            request: () => AxiosConfig.post(`${authEndpoint}/register`, data),
            successMessage: 'Registration successful'
        });
    },

    logout: async () => {
        return handleServerResponse<ISuccessResponse>({
            request: () => AxiosConfig.post(`${authEndpoint}/logout`),
            successMessage: 'Logout successful'
        });
    },

    checkAuthStatus: async () => {
        return handleServerResponse<IAuthStatusResponse>({
            request: () => AxiosConfig.get(`${authEndpoint}/status`),
        });
    },

    getCurrentUser: async () => {
        return handleServerResponse<IUserResponse>({
            request: () => AxiosConfig.get(`${authEndpoint}/user`),
        });
    },

    isRegistered: async (email: string) => {
        return handleServerResponse<IsRegisteredResponse>({
            request: () => AxiosConfig.post(authEndpoint, { email }),
        });
    }

};