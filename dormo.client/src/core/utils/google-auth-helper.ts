import { isGoogleScriptLoaded } from "@/core/application/signals/auth-signals";

const GOOGLE_CLIENT_ID = '888033230823-n8sho4seo6dvhrp5dm6hrp3ufsk3tbei.apps.googleusercontent.com';

export const loadGoogleScript = (): Promise<void> => {
  return new Promise((resolve, reject) => {
    if (window.google) {
      isGoogleScriptLoaded.value = true;
      checkGoogleAuthStatus();
      resolve();
      return;
    }

    const existingScript = document.getElementById('google-auth-script');
    if (existingScript) {
      isGoogleScriptLoaded.value = true;
      checkGoogleAuthStatus();
      resolve();
      return;
    }

    const script = document.createElement('script');
    script.id = 'google-auth-script';
    script.src = 'https://accounts.google.com/gsi/client';
    script.async = true;
    script.defer = true;
    script.onload = () => {
      isGoogleScriptLoaded.value = true;
      checkGoogleAuthStatus();
      resolve();
    };
    script.onerror = (error) => {
      console.error("Failed to load Google Sign-In script:", error);
      reject(new Error("Failed to load Google Sign-In"));
    };
    document.head.appendChild(script);
  });
};

export const getGoogleCredential = (): Promise<string> => {
  return new Promise((resolve, reject) => {
    if (!window.google || !window.google.accounts) {
      reject(new Error("Google Sign-In is not available"));
      return;
    }

    const { accounts } = window.google;
    
    try {
      accounts.id.initialize({
        client_id: GOOGLE_CLIENT_ID,
        auto_select: false,
        cancel_on_tap_outside: true,
        callback: (response: GoogleCredentialResponse) => {
          if (response.credential) {
            resolve(response.credential);
          } else {
            reject(new Error("No credential received from Google"));
          }
        },
        error_callback: (error: Error) => {
          console.error("Google Sign-In initialization error:", error);
          reject(error);
        }
      });
      
      accounts.id.prompt((notification: GooglePromptNotification) => {
        console.log("Google Sign-In prompt response:", notification);
        if (notification.isNotDisplayed()) {
          console.error("Google Sign-In prompt not displayed:", notification.getNotDisplayedReason());
          reject(new Error(`Sign-in prompt not displayed: ${notification.getNotDisplayedReason()}`));
        } else if (notification.isSkippedMoment()) {
          console.error("Google Sign-In prompt skipped:", notification.getSkippedReason());
          reject(new Error(`Sign-in prompt skipped: ${notification.getSkippedReason()}`));
        } else if (notification.isDismissedMoment()) {
          console.error("Google Sign-In prompt dismissed:", notification.getDismissedReason());
          reject(new Error(`Sign-in prompt dismissed: ${notification.getDismissedReason()}`));
        }
      });
    } catch (error) {
      console.error("Error initializing Google Sign-In:", error);
      reject(error);
    }
  });
};

export const clearGoogleAuth = (): void => {
  if (window.google && window.google.accounts) {
    window.google.accounts.id.cancel();
  }
};

export const checkGoogleAuthStatus = async (): Promise<void> => {
  if (!window.google || !window.google.accounts) {
    console.error("Google Sign-In is not available");
    return;
  }

  // Create an image element to check the status
  const img = document.createElement('img');
  img.src = `https://accounts.google.com/gsi/status?client_id=${GOOGLE_CLIENT_ID}&as=${Math.random().toString(36).substring(2, 15)}`;
  img.style.display = 'none';
  document.body.appendChild(img);
  
  img.onload = () => {
    console.log("Google Sign-In client ID is valid");
    document.body.removeChild(img);
  };
  
  img.onerror = () => {
    console.error("Google Sign-In client ID is invalid or not configured correctly");
    document.body.removeChild(img);
  };
};
