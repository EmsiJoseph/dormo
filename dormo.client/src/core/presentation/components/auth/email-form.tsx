import {Form, FormControl, FormField, FormItem, FormMessage} from "../ui/form";
import {Button} from "../ui/button";
import {FloatingLabelInput} from "../ui/floating-label-input";
import {EmailFormValues} from "@/core/domain/schemas/auth-schemas";
import {useForm} from "react-hook-form";
import Google from "@/assets/google-icon.svg";
import Separator from "@/core/presentation/components/shared/separator.tsx";

interface EmailFormProps {
    onSubmit: (data: EmailFormValues) => Promise<void>;
    emailForm: ReturnType<typeof useForm<EmailFormValues>>;
}

export default function EmailForm({onSubmit, emailForm}: EmailFormProps) {
    return (
        <Form {...emailForm}>
            <form onSubmit={emailForm.handleSubmit(onSubmit)} className="space-y-4">
                <Button variant="outline" className="w-full" size="lg">
                    <img src={Google} alt="Google" className="h-4 w-auto mr-2"/>
                    Continue with Google
                </Button>
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
                <Button type="submit" className="w-full" size="lg">Continue</Button>
            </form>
        </Form>
    );
}
