import {
    Dialog,
    DialogContent,
    DialogHeader,
    DialogTitle,
} from "../ui/dialog";
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
    emailSignal,
    authStepSignal,
    isCalendarOpenSignal,
    isSubmittingSignal,
} from "../../../application/signals/auth-signals";
import {format} from "date-fns";
import { checkAuthStatus } from "@/core/application/store/auth/auth-slice";

export default function AuthModal() {
    const dispatch = useAppDispatch();
    const {isOpen} = useSelector((state: RootState) => state.authModal);

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
            
            // Alternative: force page reload
            // window.location.reload();
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
            });
            authStepSignal.value = "complete-profile";
        } catch (error) {
            console.error("Registration failed:", error);
            toast.error("Registration failed");
        }
    };

    const onCompleteProfileSubmit = async (data: RegisterFormValues) => {
        try {
            const formattedData = {
                ...data,
                contactInfo: data.contactInfo || undefined,
                dob: format(data.dob, "yyyy-MM-dd")
            };

            console.log("Formatted data:", formattedData);
            await AuthApi.register(formattedData);
            
            // Update auth store with current user info after registration
            await dispatch(checkAuthStatus()).unwrap();
            
            dispatch(closeAuthModal());
            toast.success("Registration successful");
            
            // Alternative: force page reload
            // window.location.reload();
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

    // Function to reset all form data and signals
    const resetAllData = () => {
        // Reset all signals
        authStepSignal.value = "initial";
        emailSignal.value = "";
        isCalendarOpenSignal.value = false;
        isSubmittingSignal.value = false;

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
        });
    };

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
                        handleBack={() => (authStepSignal.value = "register")}
                        onSubmit={onCompleteProfileSubmit}
                        completeProfileForm={completeProfileForm}
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
