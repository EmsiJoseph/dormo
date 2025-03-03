import {createSlice} from '@reduxjs/toolkit';

interface DormState {
  favorites: number[];
}

const initialState: DormState = {
  favorites: []
};

const dormSlice = createSlice({
  name: 'dorm',
  initialState,
  reducers: {
    toggleFavorite: (state, action) => {
      const dormId = action.payload;
      const index = state.favorites.indexOf(dormId);
      
      if (index === -1) {
        state.favorites.push(dormId);
      } else {
        state.favorites.splice(index, 1);
      }
    }
  }
});

export const {toggleFavorite} = dormSlice.actions;
export default dormSlice.reducer;
