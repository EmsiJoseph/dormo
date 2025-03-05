import axios from 'axios';
import { store } from '@/core/application/store/store';
import { clearAuthState } from '@/core/application/store/auth/auth-slice';

const axiosInstance = axios.create({
  baseURL: `${import.meta.env.VITE_API_VERSION || '/api/v1.0'}`,
  headers: {
    'Content-Type': 'application/json',
  },
  withCredentials: true, // Important for sending/receiving cookies
});

// Add a response interceptor to handle auth errors
axiosInstance.interceptors.response.use(
  response => response, 
  error => {
    // If unauthorized, clear auth state
    if (error.response && error.response.status === 401) {
      store.dispatch(clearAuthState());
    }
    return Promise.reject(error);
  }
);

export const AxiosConfig = axiosInstance;
