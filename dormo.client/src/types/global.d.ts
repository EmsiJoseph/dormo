interface GoogleCredentialResponse {
  clientId: string;
  credential: string;
  select_by: string;
}

interface GooglePromptNotification {
  isNotDisplayed: () => boolean;
  isSkippedMoment: () => boolean;
  isDismissedMoment: () => boolean;
  getMomentType: () => string;
  getNotDisplayedReason: () => string;
  getSkippedReason: () => string;
  getDismissedReason: () => string;
}

interface GoogleInitializeParams {
  client_id: string;
  callback: (response: GoogleCredentialResponse) => void;
  error_callback?: (error: Error) => void;
  context?: string;
  auto_select?: boolean;
  cancel_on_tap_outside?: boolean;
  prompt_parent_id?: string;
}

interface GoogleRenderButtonParams {
  theme?: 'outline' | 'filled_blue' | 'filled_black';
  size?: 'small' | 'medium' | 'large';
  text?: 'signin_with' | 'signup_with' | 'continue_with' | 'signin';
  shape?: 'rectangular' | 'pill' | 'circle' | 'square';
  logo_alignment?: 'left' | 'center';
  width?: string | number;
  locale?: string;
}

interface Window {
  google?: {
    accounts: {
      id: {
        initialize: (config: GoogleInitializeParams) => void;
        renderButton: (element: HTMLElement, options: GoogleRenderButtonParams) => void;
        prompt: (callback?: (notification: GooglePromptNotification) => void) => void;
        cancel: () => void;
      };
    };
  };
}
