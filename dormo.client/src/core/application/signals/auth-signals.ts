import { signal } from '@preact/signals';

export type AuthStep = 'initial' | 'login' | 'register' | 'complete-profile';

export const authStepSignal = signal<AuthStep>('initial');
export const emailSignal = signal<string>('');
export const isCalendarOpenSignal = signal<boolean>(false);
export const isSubmittingSignal = signal<boolean>(false);

export const preferredNameSignal = signal<string>('');

// New signal to store Google user information
export interface GoogleUserInfo {
  email: string;
  firstName: string;
  lastName: string;
  dob?: string;
  isNewUser: boolean;
}

export const googleUserInfoSignal = signal<GoogleUserInfo | null>(null);



