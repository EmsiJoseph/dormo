/**
 * Type-safe URL parameter handler
*/
import { AuthStorage } from "@/core/data/storage/auth-storage";
import { GoogleUserInfo, googleUserInfoSignal } from '@/core/application/signals/auth-signals';
import {AuthApi} from "@/core/data/api/auth-api.ts";
import { toast } from "sonner";

// Common URL parameter keys with their expected types
export interface UrlParams {
  redirect?: string;
  [key: string]: string | undefined;
}

/**
 * Gets all URL parameters from the current URL or a provided URL
 * @param url Optional URL to parse parameters from (defaults to current URL)
 * @returns Object containing all URL parameters
 */
export const getAllUrlParams = (url?: string): UrlParams => {
  const searchParams = new URLSearchParams(
    url ? new URL(url).search : window.location.search
  );
  
  const params: UrlParams = {};
  searchParams.forEach((value, key) => {
    params[key] = value;
  });
  
  return params;
};

/**
 * Gets a specific URL parameter value
 * @param key The parameter key to retrieve
 * @param url Optional URL to parse from (defaults to current URL)
 * @returns The parameter value or undefined if not found
 */
export const getUrlParam = <K extends keyof UrlParams>(
  key: K, 
  url?: string
): UrlParams[K] => {
  const searchParams = new URLSearchParams(
    url ? new URL(url).search : window.location.search
  );
  return searchParams.get(key as string) as UrlParams[K] || undefined;
};

/**
 * Sets a URL parameter and updates the browser history
 * @param key The parameter key to set
 * @param value The value to set (undefined to remove)
 * @param replace Whether to replace the current history entry (default: false)
 */
export const setUrlParam = <K extends keyof UrlParams>(
  key: K, 
  value: UrlParams[K], 
  replace: boolean = false
): void => {
  const url = new URL(window.location.href);
  const searchParams = url.searchParams;
  
  if (value === undefined) {
    searchParams.delete(key as string);
  } else {
    searchParams.set(key as string, value as string);
  }
  
  const newUrl = `${window.location.pathname}${searchParams.toString() ? '?' + searchParams.toString() : ''}`;
  
  if (replace) {
    window.history.replaceState(null, '', newUrl);
  } else {
    window.history.pushState(null, '', newUrl);
  }
};

/**
 * Removes a URL parameter
 * @param key The parameter key to remove
 * @param replace Whether to replace the current history entry (default: true)
 */
export const removeUrlParam = <K extends keyof UrlParams>(
  key: K, 
  replace: boolean = true
): void => {
  setUrlParam(key, undefined, replace);
};

// Redirect-specific functions
/**
 * Gets the redirect URL from URL parameters
 * @param defaultUrl Default URL to return if no redirect parameter exists
 * @returns The redirect URL
 */
export const getRedirectUrl = (defaultUrl: string = '/'): string => {
  return getUrlParam('redirect') || defaultUrl;
};

/**
 * Sets the redirect URL in the URL parameters
 * @param url The URL to set as redirect parameter (current path if undefined)
 * @param replace Whether to replace the current history entry (default: true)
 */
export const setRedirectUrl = (url?: string, replace: boolean = true): void => {
  const redirectUrl = url || window.location.pathname + window.location.search;
  setUrlParam('redirect', redirectUrl, replace);
};

/**
 * Removes the redirect parameter from the URL
 */
export const clearRedirectUrl = (): void => {
  removeUrlParam('redirect');
};



/**
 * Checks for Google authentication data
 * First checks for a URL flag, and if present, fetches data from the API
 * @returns GoogleUserInfo | null
 */
export const checkGoogleAuthData = async (): Promise<GoogleUserInfo | null> => {
  const urlParams = new URLSearchParams(window.location.search);
  const shouldCheckAuth = urlParams.get('checkGoogleAuth') === 'true';
  
  if (shouldCheckAuth) {
    try {
      // Fetch the user data from the API
      const response = await AuthApi.getUserData();

      if (response.data) {
        const userData = response.data; // Data is already parsed by the AuthApi service
        
        // Store in session storage
        AuthStorage.saveGoogleAuthData(userData);
        
        // Also update the signal
        googleUserInfoSignal.value = userData;
        
        // Clean up URL
        const url = new URL(window.location.href);
        url.searchParams.delete('checkGoogleAuth');
        window.history.replaceState({}, document.title, url.toString());
        
        // Show a toast notification
        if (userData.isNewUser) {
          toast.success('Google authentication successful! Please complete your profile.', {
            duration: 5000,
          });

        } else {
          toast.success('Google authentication successful! Welcome back!', {
            duration: 3000,
          });
        }
        
        return userData;
      }
      
      return null;
    } catch (error) {
      console.error('Failed to fetch Google auth data:', error);
      toast.error('Failed to get your Google account information.');
      return null;
    }
  } else {
    // Check if we have stored data from a previous redirect
    const storedData = AuthStorage.getGoogleAuthData();
    if (storedData) {
      googleUserInfoSignal.value = storedData;
      return storedData;
    }
  }
  
  return null;
};
