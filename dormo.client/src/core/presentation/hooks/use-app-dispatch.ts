import {useDispatch} from 'react-redux';
import type {AppDispatch} from '@/core/application/store/store';

export const useAppDispatch = () => useDispatch<AppDispatch>();
