import {handleServerResponse} from "@/core/presentation/handlers/api-response-handlers/handle-server-response";
import {AxiosConfig} from "@/core/data/axios-config";
import {
    IAuthStatusResponse,
    ISuccessResponse,
    IUserResponse
} from "@/core/domain/interfaces/IBaseApiResponse";
import {LoginFormValues, RegisterFormValues} from "@/core/domain/schemas/auth-schemas";
import { GoogleUserInfo } from "@/core/application/signals/auth-signals";

const authEndpoint = "/auth";

interface IsRegisteredResponse {
    isRegistered: boolean;
    email: string;
}

interface GoogleAuthResponse {
    isExistingUser: boolean;
    userInfo: GoogleUserInfo;
}

type RegisterFormValuesWithStringDob = Omit<RegisterFormValues, 'dob'> & { dob: string };

interface GoogleLoginRequest {
    credential: string;
}

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
    },

    googleLogin: async (credential: string) => {
        return handleServerResponse<GoogleAuthResponse>({
            request: () => AxiosConfig.post("/api/v1.0/ExternalAuth/google-login", { credential } as GoogleLoginRequest),
            successMessage: 'Google authentication successful'
        });
    },
};