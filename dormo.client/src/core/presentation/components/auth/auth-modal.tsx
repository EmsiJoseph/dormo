import {Dialog, DialogContent, DialogHeader, DialogTitle,} from "../ui/dialog";
import {useSelector} from "react-redux";
import {RootState} from "@/core/application/store/store";
import {useAppDispatch} from "@/core/presentation/hooks/use-app-dispatch";
import {closeAuthModal} from "@/core/application/store/auth-modal/auth-modal-slice";
import DormoIcon from "@/assets/dormo-icon.svg";
import {zodResolver} from "@hookform/resolvers/zod";
import {useForm} from "react-hook-form";
import {AuthApi} from "@/core/data/api/auth-api";
import {
    EmailFormValues,
    emailSchema,
    InitialRegisterFormValues,
    initialRegisterSchema,
    LoginFormValues,
    loginSchema,
    RegisterFormValues,
    registerSchema,
} from "../../../domain/schemas/auth-schemas";
import {toast} from "sonner";
import EmailForm from "./email-form";
import LoginForm from "./login-form";
import RegisterForm from "./register-form";
import {useSignalEffect} from "@preact/signals";
import CompleteProfileForm from "./complete-profile-form";
import {
    authStepSignal,
    emailSignal,
    googleUserInfoSignal,
    isCalendarOpenSignal,
    isSubmittingSignal
} from "../../../application/signals/auth-signals";
import {format, parse} from "date-fns";
import {checkAuthStatus} from "@/core/application/store/auth/auth-slice";
import {useEffect} from "preact/hooks";
import {checkGoogleAuthData} from "@/core/presentation/handlers/url-param-handler";
import {AuthStorage} from "@/core/data/storage/auth-storage";

export default function AuthModal() {
    const dispatch = useAppDispatch();
    const {isOpen, initialStep} = useSelector((state: RootState) => state.authModal);

    // Apply initial step if provided by the store
    useEffect(() => {
        if (isOpen && initialStep) {
            authStepSignal.value = initialStep;

            // Then check for Google user info in storage
            const storedData = AuthStorage.getGoogleAuthData();
            if (storedData) {
                // Populate form with Google data
                emailSignal.value = storedData.email;
                googleUserInfoSignal.value = storedData;

                if (initialStep === "complete-profile") {
                    const dobDate = storedData.dob ?
                        parse(storedData.dob, 'yyyy-MM-dd', new Date()) :
                        undefined;

                    completeProfileForm.reset({
                        email: storedData.email,
                        firstName: storedData.firstName || "",
                        lastName: storedData.lastName || "",
                        preferredFirstName: storedData.firstName || "",
                        dob: dobDate,
                        emailSubscription: false,
                    });
                }
            }
        }
    }, [isOpen, initialStep]);

    // Check for Google auth data on component mount
    useEffect(() => {
        const checkAuth = async () => {
            const googleAuthData = await checkGoogleAuthData();
            if (googleAuthData && googleAuthData.isNewUser) {
                dispatch({type: "authModal/openAuthModal"});
                emailSignal.value = googleAuthData.email;
                authStepSignal.value = "complete-profile";

                // Populate the complete profile form with Google data
                const dobDate = googleAuthData.dob ?
                    parse(googleAuthData.dob, 'yyyy-MM-dd', new Date()) :
                    undefined;

                completeProfileForm.reset({
                    email: googleAuthData.email,
                    firstName: googleAuthData.firstName || "",
                    lastName: googleAuthData.lastName || "",
                    preferredFirstName: googleAuthData.firstName || "",
                    dob: dobDate,
                    emailSubscription: false,
                    isExternalAuth: true, // Mark as external auth
                });
            }
        };

        checkAuth();
    }, []);

    const emailForm = useForm<EmailFormValues>({
        resolver: zodResolver(emailSchema),
        defaultValues: {email: emailSignal.value},
    });

    const loginForm = useForm<LoginFormValues>({
        resolver: zodResolver(loginSchema),
        defaultValues: {email: emailSignal.value},
    });

    const initialRegisterForm = useForm<InitialRegisterFormValues>({
        resolver: zodResolver(initialRegisterSchema),
        defaultValues: {email: emailSignal.value},
    });

    const completeProfileForm = useForm<RegisterFormValues>({
        resolver: zodResolver(registerSchema),
        defaultValues: {
            email: emailSignal.value,
            isExternalAuth: false, // Default to regular auth
        },
    });


    // Reset forms when email changes
    useSignalEffect(() => {
        if (emailSignal.value) {
            loginForm.reset({email: emailSignal.value});
            initialRegisterForm.reset({email: emailSignal.value});
        }
    });

    const onEmailSubmit = async (data: EmailFormValues) => {
        try {
            const response = await AuthApi.isRegistered(data.email);
            if (response.data) {
                emailSignal.value = data.email;
                authStepSignal.value = response.data.isRegistered
                    ? "login"
                    : "register";
            }
        } catch (error) {
            toast.error("Failed to check email");
            console.error("Failed to check email:", error);
        }
    };

    const onLoginSubmit = async (data: LoginFormValues) => {
        try {
            isSubmittingSignal.value = true;
            await AuthApi.login(data);

            // Update auth store with current user info
            await dispatch(checkAuthStatus()).unwrap();

            isSubmittingSignal.value = false;
            dispatch(closeAuthModal());
        } catch (error) {
            isSubmittingSignal.value = false;
            console.error("Login failed:", error);
        }
    };

    const onRegisterSubmit = async (data: InitialRegisterFormValues) => {
        try {
            // Transfer initial registration data to complete profile form
            completeProfileForm.reset({
                ...completeProfileForm.getValues(),
                email: data.email,
                password: data.password,
                confirmPassword: data.confirmPassword,
                isExternalAuth: false, // This is regular registration
            });
            authStepSignal.value = "complete-profile";
        } catch (error) {
            console.error("Registration failed:", error);
            toast.error("Registration failed");
        }
    };

    const onCompleteProfileSubmit = async (data: RegisterFormValues) => {
        try {
            // Format the date for both paths
            const formattedData = {
                ...data,
                dob: format(data.dob, "yyyy-MM-dd"),
                contactInfo: data.contactInfo || undefined
            };

            // Check if we're dealing with Google auth
            if (data.isExternalAuth) {
                // For Google auth registration
                const googleData = {
                    ...formattedData,
                    // Remove password fields
                    password: undefined,
                    confirmPassword: undefined,
                    // Add external login info
                    externalLogin: {
                        provider: "Google",
                        email: data.email
                    }
                };

                await AuthApi.registerWithGoogle(googleData);
            } else {
                // For regular registration
                await AuthApi.register(formattedData);
            }

            // Update auth store with current user info after registration
            await dispatch(checkAuthStatus()).unwrap();

            dispatch(closeAuthModal());
            toast.success("Registration successful");
        } catch (error) {
            console.error("Registration failed:", error);
            toast.error("Failed to complete registration");
        }
    };

    const handleBack = () => {
        authStepSignal.value = "initial";
        emailSignal.value = "";
        loginForm.reset();
        initialRegisterForm.reset();
        completeProfileForm.reset();
        googleUserInfoSignal.value = null;
    };

    // Handle dialog close with calendar awareness
    const handleCloseDialog = (open: boolean) => {
        if (!open) {
            // If calendar is open, prevent dialog from closing
            if (isCalendarOpenSignal.value) {
                return;
            }

            // Otherwise, close the auth modal
            dispatch(closeAuthModal());

            // Reset all data and forms
            resetAllData();
        }
    };

    // Update resetAllData to also reset the googleUserInfoSignal
    const resetAllData = () => {
        // Reset all signals
        authStepSignal.value = "initial";
        emailSignal.value = "";
        isCalendarOpenSignal.value = false;
        isSubmittingSignal.value = false;
        googleUserInfoSignal.value = null;

        // Reset all forms
        emailForm.reset({email: ""});
        loginForm.reset({email: "", password: ""});
        initialRegisterForm.reset({email: "", password: "", confirmPassword: ""});
        completeProfileForm.reset({
            email: "",
            firstName: "",
            lastName: "",
            preferredFirstName: "",
            password: "",
            confirmPassword: "",
            dob: undefined,
            contactInfo: "",
            emailSubscription: false,
            isExternalAuth: false,
        });

        // Clear session storage
        AuthStorage.clearGoogleAuthData();
    };

    const isGoogleAuth = !!googleUserInfoSignal.value;
    const formToUse = isGoogleAuth ? completeProfileForm : completeProfileForm;

    const renderForm = () => {
        switch (authStepSignal.value) {
            case "login":
                return (
                    <LoginForm
                        handleBack={handleBack}
                        onSubmit={onLoginSubmit}
                        loginForm={loginForm}
                    />
                );
            case "register":
                return (
                    <RegisterForm
                        handleBack={handleBack}
                        onSubmit={onRegisterSubmit}
                        registerForm={initialRegisterForm}
                    />
                );
            case "complete-profile":


                return (
                    <CompleteProfileForm
                        handleBack={() => {
                            // If coming from Google auth, go back to initial screen
                            if (isGoogleAuth) {
                                authStepSignal.value = "initial";
                                googleUserInfoSignal.value = null;
                            } else {
                                // Otherwise, go back to register screen
                                authStepSignal.value = "register";
                            }
                        }}
                        onSubmit={onCompleteProfileSubmit}
                        completeProfileForm={formToUse}
                        isExternalAuth={isGoogleAuth} // Pass this prop to hide password fields
                    />
                );
            default:
                return <EmailForm onSubmit={onEmailSubmit} emailForm={emailForm}/>;
        }
    };

    return (
        <Dialog open={isOpen} onOpenChange={handleCloseDialog}>
            <DialogContent
                className="max-w-lg flex flex-col items-center justify-center gap-8"
                onPointerDownOutside={(e) => {
                    // Prevent closing when calendar is open
                    if (isCalendarOpenSignal.value) {
                        e.preventDefault();
                    }
                }}
            >
                {authStepSignal.value === "initial" && (
                    <DialogHeader>
                        <DialogTitle className="flex flex-col items-center gap-3">
                            <img src={DormoIcon} alt="Dormo" className="h-14 w-auto"/>
                            <span className="text-3xl text-dormo-text">Welcome to Dormo</span>
                        </DialogTitle>
                    </DialogHeader>
                )}
                <div className="w-full">{renderForm()}</div>
            </DialogContent>
        </Dialog>
    );
}
