import {signal} from "@preact/signals";

export const isCalendarOpenSignal = signal<boolean>(false);
export const emailSignal = signal<string>("");
export const authStepSignal = signal<"initial" | "login" | "register" | "complete-profile">('initial');

export const preferredNameSignal = signal<string>("");

export const isSubmittingSignal = signal<boolean>(false);

// Add new signal for Google user info
export interface GoogleUserInfo {
  email: string;
  firstName: string;
  lastName: string;
  profileImageUrl: string;
}

export const googleUserInfoSignal = signal<GoogleUserInfo | null>(null);

export const isGoogleScriptLoaded = signal<boolean>(false);

