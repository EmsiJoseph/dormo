import {Form, FormControl, FormField, FormItem, FormMessage} from "@/core/presentation/components/ui/form";
import {Button} from "@/core/presentation/components/ui/button";
import {ChevronLeft} from "lucide-react";
import {FloatingLabelInput} from "@/core/presentation/components/ui/floating-label-input";
import {LoginFormValues} from "@/core/domain/schemas/auth-schemas";
import {useForm} from "react-hook-form";
import {SubmitButton} from "@/core/presentation/components/ui/submit-button";
import {isSubmittingSignal} from "@/core/application/signals/auth-signals";

interface LoginFormProps {
    handleBack: () => void;
    onSubmit: (data: LoginFormValues) => Promise<void>;
    loginForm: ReturnType<typeof useForm<LoginFormValues>>;
}

export default function LoginForm({handleBack, onSubmit, loginForm}: LoginFormProps) {
    return (
        <Form {...loginForm}>
            <form onSubmit={loginForm.handleSubmit(onSubmit)} className="space-y-4">

                <div className="relative flex-1 flex items-center justify-center text-center gap-4 ">
                    <Button
                        type="button"
                        variant="ghost"
                        size="icon"
                        onClick={handleBack}
                        className="absolute left-0"
                    >
                        <ChevronLeft className="h-4 w-4"/>
                    </Button>
                    <h2 className="text-xl font-bold">Continue with email</h2>
                </div>

                <FormField
                    control={loginForm.control}
                    name="email"
                    render={({field}) => (
                        <FormItem>
                            <FormControl>
                                <FloatingLabelInput
                                    label="Email"
                                    type="email"
                                    readOnly
                                    {...field}
                                />
                            </FormControl>
                            <FormMessage/>
                        </FormItem>
                    )}
                />
                <FormField
                    control={loginForm.control}
                    name="password"
                    render={({field}) => (
                        <FormItem>
                            <FormControl>
                                <FloatingLabelInput
                                    label="Password"
                                    type="password"
                                    {...field}
                                />
                            </FormControl>
                            <FormMessage/>
                        </FormItem>
                    )}
                />
                <SubmitButton
                    className="w-full"
                    size="lg"
                    isLoading={isSubmittingSignal.value}
                >
                    Login
                </SubmitButton>
            </form>
        </Form>
    );
}
