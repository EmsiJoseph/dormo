import {configureStore} from '@reduxjs/toolkit';
import authReducer from './auth/auth-slice';
import authModalReducer from './auth-modal/auth-modal-slice';

export const store = configureStore({
    reducer: {
        auth: authReducer,
        authModal: authModalReducer,
    },
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;
