import {Form, FormControl, FormField, FormItem, FormMessage} from "../ui/form";
import {Button} from "../ui/button";
import {ChevronLeft} from "lucide-react";
import {FloatingLabelInput} from "../ui/floating-label-input";
import {InitialRegisterFormValues} from "@/core/domain/schemas/auth-schemas";
import {useForm} from "react-hook-form";

interface RegisterFormProps {
    handleBack: () => void;
    onSubmit: (data: InitialRegisterFormValues) => Promise<void>;
    registerForm: ReturnType<typeof useForm<InitialRegisterFormValues>>;
}

export default function RegisterForm({handleBack, onSubmit, registerForm}: RegisterFormProps) {
    return (
        <Form {...registerForm}>
            <form onSubmit={registerForm.handleSubmit(onSubmit)} className="space-y-4">
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
                    <h2 className="text-xl font-bold">Create your Dormo account</h2>
                </div>
                <FormField
                    control={registerForm.control}
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
                    control={registerForm.control}
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
                <FormField
                    control={registerForm.control}
                    name="confirmPassword"
                    render={({field}) => (
                        <FormItem>
                            <FormControl>
                                <FloatingLabelInput
                                    label="Confirm password"
                                    type="password"
                                    {...field}
                                />
                            </FormControl>
                            <FormMessage/>
                        </FormItem>
                    )}
                />
                <Button type="submit" className="w-full" size="lg">Sign up</Button>
            </form>
        </Form>
    );
}