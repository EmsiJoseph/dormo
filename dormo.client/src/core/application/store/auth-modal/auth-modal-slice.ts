import { createSlice, PayloadAction } from '@reduxjs/toolkit';
import { AuthStep } from '@/core/application/signals/auth-signals';

interface AuthModalState {
  isOpen: boolean;
  initialStep?: AuthStep;
  returnPath?: string;
}

const initialState: AuthModalState = {
  isOpen: false,
  initialStep: undefined,
  returnPath: undefined,
};

const authModalSlice = createSlice({
  name: 'authModal',
  initialState,
  reducers: {
    openAuthModal: (state, action: PayloadAction<{ returnPath?: string }>) => {
      state.isOpen = true;
      state.returnPath = action.payload?.returnPath;
  },
    closeAuthModal: (state) => {
      state.isOpen = false;
      state.initialStep = undefined;
      state.returnPath = undefined;
    },
    openAuthModalWithStep: (state, action: PayloadAction<{ step: AuthStep, returnPath?: string }>) => {
      state.isOpen = true;
      state.initialStep = action.payload.step;
      state.returnPath = action.payload.returnPath;
    },
  },
});

export const { openAuthModal, closeAuthModal, openAuthModalWithStep } = authModalSlice.actions;

export default authModalSlice.reducer;
