import {createAsyncThunk, createSlice} from '@reduxjs/toolkit';
import {AuthApi} from "@/core/data/api/auth-api.ts";

import {IErrorResponse, IUserResponse} from "@/core/domain/interfaces/IBaseApiResponse";

interface AuthState {
    user: IUserResponse | null;
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
        const statusResponse = await AuthApi.checkAuthStatus();
        if (statusResponse.data?.isAuthenticated) {
            const userResponse = await AuthApi.getCurrentUser();
            return userResponse.data;
        }
        throw new Error('Not authenticated');
    }
);

export const logout = createAsyncThunk(
    'auth/logout',
    async (_, {rejectWithValue}) => {
        try {
            await AuthApi.logout();
        } catch (error) {
            if (error && typeof error === 'object' && 'message' in error) {
                return rejectWithValue(error as IErrorResponse);
            }
            throw error;
        }
    }
);

const authSlice = createSlice({
    name: 'auth',
    initialState,
    reducers: {},
    extraReducers: (builder) => {
        builder
            .addCase(checkAuthStatus.pending, (state) => {
                state.loading = true;
                state.error = null;
            })
            .addCase(checkAuthStatus.fulfilled, (state, action) => {
                state.loading = false;
                state.user = action.payload as IUserResponse;
                state.isAuthenticated = true;
            })
            .addCase(checkAuthStatus.rejected, (state, action) => {
                state.loading = false;
                state.user = null;
                state.isAuthenticated = false;
                state.error = action.error.message ?? 'Authentication failed';
            })
            .addCase(logout.fulfilled, (state) => {
                state.user = null;
                state.isAuthenticated = false;
            });
    },
});

export default authSlice.reducer;
