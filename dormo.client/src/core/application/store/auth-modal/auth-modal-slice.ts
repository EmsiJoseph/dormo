import {createSlice, PayloadAction} from '@reduxjs/toolkit';

interface AuthModalState {
    isOpen: boolean;
    returnPath?: string;
    onAuthSuccess?: () => void;
}

const initialState: AuthModalState = {
    isOpen: false,
    returnPath: undefined,
    onAuthSuccess: undefined,
};

const authModalSlice = createSlice({
    name: 'authModal',
    initialState,
    reducers: {
        openAuthModal: (state, action: PayloadAction<Partial<AuthModalState>>) => {
            state.isOpen = true;
            state.returnPath = action.payload.returnPath;
        },
        closeAuthModal: (state) => {
            state.isOpen = false;
            state.returnPath = undefined;
        },
    },
});

export const {openAuthModal, closeAuthModal} = authModalSlice.actions;
export default authModalSlice.reducer;
