import { GoogleUserInfo } from "@/core/application/signals/auth-signals";

const GOOGLE_AUTH_KEY = "dormo_google_auth";

/**
 * Auth storage service that uses SessionStorage for storing sensitive auth data
 * SessionStorage is preferred over LocalStorage for security reasons:
 * - Data is cleared when the browser tab is closed
 * - Data is not sent to the server with every request (unlike cookies)
 * - Data is not shared between tabs/windows (unlike LocalStorage)
 */
export const AuthStorage = {
  /**
   * Saves Google authentication data to session storage
   */
  saveGoogleAuthData: (data: GoogleUserInfo): void => {
    try {
      sessionStorage.setItem(GOOGLE_AUTH_KEY, JSON.stringify(data));
    } catch (error) {
      console.error("Failed to save Google auth data to session storage", error);
    }
  },

  /**
   * Retrieves Google authentication data from session storage
   * @returns GoogleUserInfo | null
   */
  getGoogleAuthData: (): GoogleUserInfo | null => {
    try {
      const data = sessionStorage.getItem(GOOGLE_AUTH_KEY);
      return data ? JSON.parse(data) : null;
    } catch (error) {
      console.error("Failed to retrieve Google auth data from session storage", error);
      return null;
    }
  },

  /**
   * Removes Google authentication data from session storage
   */
  clearGoogleAuthData: (): void => {
    try {
      sessionStorage.removeItem(GOOGLE_AUTH_KEY);
    } catch (error) {
      console.error("Failed to clear Google auth data from session storage", error);
    }
  }
};
