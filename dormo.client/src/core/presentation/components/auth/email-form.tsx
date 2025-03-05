import {Form, FormControl, FormField, FormItem, FormMessage} from "@/core/presentation/components/ui/form";
import {Button} from "../ui/button";
import {FloatingLabelInput} from "@/core/presentation/components/ui/floating-label-input";
import {EmailFormValues} from "@/core/domain/schemas/auth-schemas";
import {useForm} from "react-hook-form";
import Google from "@/assets/google-icon.svg";
import Separator from "@/core/presentation/components/shared/separator";
import {
    isSubmittingSignal,
} from "@/core/application/signals/auth-signals";
import {AuthApi} from "@/core/data/api/auth-api.ts";
import {setRedirectUrl} from "@/core/presentation/handlers/url-param-handler.ts";

interface EmailFormProps {
    onSubmit: (data: EmailFormValues) => Promise<void>;
    emailForm: ReturnType<typeof useForm<EmailFormValues>>;
}

export default function EmailForm({onSubmit, emailForm}: EmailFormProps) {
    const handleGoogleLogin = async () => {
        try {
            isSubmittingSignal.value = true;
            const provider = "Google";
            const redirect = window.location.href;
            setRedirectUrl(redirect);
            await AuthApi.externalLogin(provider, redirect);
            // The page will redirect, so we don't need to reset isSubmittingSignal
        } catch (error) {
            isSubmittingSignal.value = false;
            console.error("Error during Google login:", error);
        }
    };

    return (
        <div className="space-y-4">
            <Button
                variant="outline"
                className="w-full"
                size="lg"
                type="button"
                onClick={handleGoogleLogin}
                disabled={isSubmittingSignal.value}
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
