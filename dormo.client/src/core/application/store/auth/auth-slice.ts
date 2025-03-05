import {createAsyncThunk, createSlice} from '@reduxjs/toolkit';
import {AuthApi} from "@/core/data/api/auth-api";
import { IUserResponse} from "@/core/domain/interfaces/IBaseApiResponse";

interface AuthState {
    user: IUserResponse | null | undefined;
    isAuthenticated: boolean;
    loading: boolean;
    error: string | null;
}

const initialState: AuthState = {
    user: null,
    isAuthenticated: false,
    loading: false,
    error: null,
};

export const checkAuthStatus = createAsyncThunk(
    'auth/checkStatus',
    async () => {
        try {
            const statusResponse = await AuthApi.checkAuthStatus();
            
            // If the user is not authenticated, return null
            if (!statusResponse.data?.isAuthenticated) {
                return { isAuthenticated: false, user: null };
            }
            
            // If authenticated, fetch user data
            const userResponse = await AuthApi.getCurrentUser();
            return { 
                isAuthenticated: true, 
                user: userResponse.data 
            };
        } catch (error) {
            console.error("Auth check failed:", error);
            // Return null user for any error
            return { isAuthenticated: false, user: null };
        }
    }
);

export const logout = createAsyncThunk(
    'auth/logout',
    async (_, { dispatch }) => {
        try {
            // Call logout API
            await AuthApi.logout();
            
            // Return success for the reducer
            return true;
        } catch (error) {
            console.error("Logout failed:", error);
            // Even if there's an error, we'll clear local auth state
            return false;
        } finally {
            // Force a refresh of the auth status
            dispatch(checkAuthStatus());
        }
    }
);

const authSlice = createSlice({
    name: 'auth',
    initialState,
    reducers: {
        clearAuthState: (state) => {
            state.user = null;
            state.isAuthenticated = false;
            state.error = null;
        }
    },
    extraReducers: (builder) => {
        builder
            .addCase(checkAuthStatus.pending, (state) => {
                state.loading = true;
                state.error = null;
            })
            .addCase(checkAuthStatus.fulfilled, (state, action) => {
                state.loading = false;
                state.user = action.payload.user;
                state.isAuthenticated = action.payload.isAuthenticated;
            })
            .addCase(checkAuthStatus.rejected, (state) => {
                state.loading = false;
                state.user = null;
                state.isAuthenticated = false;
                state.error = 'Authentication check failed';
            })
            .addCase(logout.fulfilled, (state) => {
                state.user = null;
                state.isAuthenticated = false;
            });
    },
});

export const { clearAuthState } = authSlice.actions;
export default authSlice.reducer;
