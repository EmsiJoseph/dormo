import { configureStore } from '@reduxjs/toolkit';
import authReducer from './auth/auth-slice';
import authModalReducer from './auth-modal/auth-modal-slice';
import dormReducer from './dorm/dorm-slice';

export const store = configureStore({
  reducer: {
    auth: authReducer,
    authModal: authModalReducer,
    dorm: dormReducer, // Changed to match singular naming pattern
  },
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;
