import {Form, FormControl, FormField, FormItem, FormMessage} from "@/core/presentation/components/ui/form";
import {Button} from "../ui/button";
import {FloatingLabelInput} from "@/core/presentation/components/ui/floating-label-input";
import {EmailFormValues} from "@/core/domain/schemas/auth-schemas";
import {useForm} from "react-hook-form";
import Google from "@/assets/google-icon.svg";
import Separator from "@/core/presentation/components/shared/separator";
import { useSignalEffect } from "@preact/signals";
import { AuthApi } from "@/core/data/api/auth-api";
import { toast } from "sonner";
import {
    authStepSignal,
    emailSignal,
    isSubmittingSignal,
    googleUserInfoSignal, isGoogleScriptLoaded
} from "@/core/application/signals/auth-signals";
import { useAppDispatch } from "@/core/presentation/hooks/use-app-dispatch";
import { checkAuthStatus } from "@/core/application/store/auth/auth-slice";
import { closeAuthModal } from "@/core/application/store/auth-modal/auth-modal-slice";

interface EmailFormProps {
    onSubmit: (data: EmailFormValues) => Promise<void>;
    emailForm: ReturnType<typeof useForm<EmailFormValues>>;
}

export default function EmailForm({onSubmit, emailForm}: EmailFormProps) {
    const dispatch = useAppDispatch();

    // Load Google Identity Services script
    useSignalEffect(() => {
        const loadGoogleScript = () => {
            const existingScript = document.getElementById('google-auth-script');
            if (!existingScript) {
                const script = document.createElement('script');
                script.id = 'google-auth-script';
                script.src = 'https://accounts.google.com/gsi/client';
                script.async = true;
                script.defer = true;
                script.onload = () => {
                    isGoogleScriptLoaded.value = true;
                };
                document.head.appendChild(script);
            } else {
                isGoogleScriptLoaded.value = true;
            }
        };
        
        loadGoogleScript();
        
        // Clean up function
        return () => {
            if (window.google && window.google.accounts) {
                window.google.accounts.id.cancel();
            }
        };
    });
    
    // Handle Google Sign-In
    const handleGoogleSignIn = async () => {
        if (!window.google || !window.google.accounts) {
            toast.error("Google Sign-In is not available");
            return;
        }
        
        isSubmittingSignal.value = true;
        
        try {
            const { accounts } = window.google;
            
            // Create a promise to handle the credential response
            const googleAuthPromise = new Promise<string>((resolve, reject) => {
                accounts.id.initialize({
                    client_id: '888033230823-n8sho4seo6dvhrp5dm6hrp3ufsk3tbei.apps.googleusercontent.com',
                    callback: (response: GoogleCredentialResponse) => {
                        if (response.credential) {
                            resolve(response.credential);
                        } else {
                            reject(new Error("No credential received from Google"));
                        }
                    },
                    error_callback: (error: Error) => {
                        reject(error);
                    }
                });
                
                accounts.id.prompt((notification: GooglePromptNotification) => {
                    if (notification.isNotDisplayed() || notification.isSkippedMoment()) {
                        reject(new Error("Google sign-in prompt was skipped or not displayed"));
                    }
                });
            });
            
            // Wait for the credential
            const credential = await googleAuthPromise;
            
            // Send credential to server
            const res = await AuthApi.googleLogin(credential);
            
            if (res?.data?.isExistingUser) {
                // User exists, update auth state and close modal
                await dispatch(checkAuthStatus()).unwrap();
                dispatch(closeAuthModal());
                toast.success("Signed in successfully");
            } else if (res?.data?.userInfo) {
                // New user, populate form with Google data and move to complete profile
                emailSignal.value = res.data.userInfo.email || "";
                
                // Store Google user info in signal instead of sessionStorage
                googleUserInfoSignal.value = res.data.userInfo;
                
                // Skip directly to complete-profile step
                authStepSignal.value = "complete-profile";
            } else {
                throw new Error("Invalid response from Google authentication");
            }
        } catch (error) {
            console.error("Google authentication failed:", error);
            toast.error("Google authentication failed");
        } finally {
            isSubmittingSignal.value = false;
        }
    };


    return (
        <div className="space-y-4">
            <Button 
                variant="outline" 
                className="w-full" 
                size="lg"
                type="button"
                onClick={handleGoogleSignIn}
                disabled={isSubmittingSignal.value || !isGoogleScriptLoaded.value}
            >
                <img src={Google} alt="Google" className="h-4 w-auto mr-2"/>
                Continue with Google
            </Button>
            
            <Form {...emailForm}>
                <form onSubmit={emailForm.handleSubmit(onSubmit)} className="space-y-4">
                    <div className="flex items-center w-full gap-4">
                        <Separator/>
                        <span className="text-gray-600">OR</span>
                        <Separator/>
                    </div>
                    <FormField
                        control={emailForm.control}
                        name="email"
                        render={({field}) => (
                            <FormItem>
                                <FormControl>
                                    <FloatingLabelInput label="Email" {...field} />
                                </FormControl>
                                <FormMessage/>
                            </FormItem>
                        )}
                    />
                    <Button 
                        type="submit" 
                        className="w-full" 
                        size="lg"
                        disabled={isSubmittingSignal.value}
                    >
                        Continue
                    </Button>
                </form>
            </Form>
        </div>
    );
}
