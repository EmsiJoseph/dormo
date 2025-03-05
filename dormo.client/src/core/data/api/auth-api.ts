import {handleServerResponse} from "@/core/presentation/handlers/api-response-handlers/handle-server-response";
import {AxiosConfig} from "@/core/data/axios-config";
import {
    IAuthStatusResponse,
    ISuccessResponse,
    IUserResponse
} from "@/core/domain/interfaces/IBaseApiResponse";
import { LoginFormValues, RegisterFormValues} from "@/core/domain/schemas/auth-schemas";
import { GoogleUserInfo } from "@/core/application/signals/auth-signals";

const authEndpoint = "/auth";

const externalLogin = "/externalLogin";

interface IsRegisteredResponse {
    isRegistered: boolean;
    email: string;
}

// Regular registration (with string date)
type RegisterFormValuesWithStringDob = Omit<RegisterFormValues, 'dob'> & { 
    dob: string;
};

// Type for Google registration (without password fields)
type GoogleRegisterFormValues = Omit<RegisterFormValuesWithStringDob, 'password' | 'confirmPassword' | 'isExternalAuth'> & {
    externalLogin: {
        provider: string;
        email: string;
    }
};

export const AuthApi = {
    login: async (credentials: LoginFormValues) => {
        return handleServerResponse<ISuccessResponse>({
            request: () => AxiosConfig.post(`${authEndpoint}/login`, credentials),
            successMessage: 'Login successful'
        });
    },

    externalLogin: async (provider: string, returnUrl: string): Promise<void> => {
          window.location.href = `${import.meta.env.VITE_API_VERSION || '/api/v1.0'}${externalLogin}/login?provider=${provider}&returnUrl=${encodeURIComponent(returnUrl)}`;
   
        return new Promise<void>((resolve) => {
            setTimeout(resolve, 100);
        });
    },

    getUserData: async() => {
        return handleServerResponse<GoogleUserInfo>({
            request: () => AxiosConfig.get(`${externalLogin}/GetUserData`), // Updated to match controller endpoint
        });
    },

    register: async (data: RegisterFormValuesWithStringDob) => {
        return handleServerResponse<ISuccessResponse>({
            request: () => AxiosConfig.post(`${authEndpoint}/register`, data),
            successMessage: 'Registration successful'
        });
    },

    registerWithGoogle: async (data: GoogleRegisterFormValues) => {
        return handleServerResponse<ISuccessResponse>({
            request: () => AxiosConfig.post(`${authEndpoint}/register-google`, data),
            successMessage: 'Registration with Google successful'
        });
    },

    logout: async () => {
        try {
            const response = await handleServerResponse<ISuccessResponse>({
                request: () => AxiosConfig.post(`${authEndpoint}/logout`),
                successMessage: 'Logout successful'
            });
            return response;
        } catch (error) {
            console.error("Logout API error:", error);
            // Always resolve the promise, even on failure
            // This ensures we can still clear local state
            return { success: false, data: null, error: 'Logout failed on server' };
        }
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
            request: () => AxiosConfig.post(authEndpoint, {email}),
        });
    }
};