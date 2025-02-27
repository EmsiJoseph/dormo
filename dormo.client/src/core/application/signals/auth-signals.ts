import {signal} from "@preact/signals";

export const isCalendarOpenSignal = signal<boolean>(false);
export const emailSignal = signal<string>("");
export const authStepSignal = signal<"initial" | "login" | "register" | "complete-profile">('initial');

export const preferredNameSignal = signal<string>("");

export const isSubmittingSignal = signal<boolean>(false);
