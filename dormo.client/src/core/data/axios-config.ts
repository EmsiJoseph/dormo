import axios from "axios";

const API_VERSION = import.meta.env.VITE_API_VERSION;

const AxiosConfig = axios.create({
    baseURL: API_VERSION,
    timeout: 5000,
    withCredentials: true
});

AxiosConfig.interceptors.response.use(
    (response) => response,
    (error) => {
        if (error.response?.status === 401) {
            // window.location.href = '/';
            // TODO: Pop up a modal to inform the user that they have been logged out
        }
        return Promise.reject(error);
    }
);

export { AxiosConfig };
