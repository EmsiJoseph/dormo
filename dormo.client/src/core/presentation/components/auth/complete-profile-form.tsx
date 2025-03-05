import {
    Form,
    FormControl,
    FormDescription,
    FormField,
    FormItem,
    FormLabel,
    FormMessage,
} from "../ui/form";
import {Button} from "../ui/button";
import {CalendarIcon, ChevronLeft} from "lucide-react";
import {FloatingLabelInput} from "../ui/floating-label-input";
import {useForm} from "react-hook-form";
import {
    Popover,
    PopoverContent,
    PopoverTrigger,
} from "@/core/presentation/components/ui/popover";
import {cn} from "@/lib/utils";
import {format} from "date-fns";
import {Calendar} from "@/core/presentation/components/ui/calendar";
import { RegisterFormValues} from "@/core/domain/schemas/auth-schemas";
import {Checkbox} from "@/core/presentation/components/ui/checkbox";
import {
    Dialog,
    DialogClose,
    DialogContent,
    DialogFooter,
    DialogHeader,
    DialogTitle,
    DialogTrigger,
} from "@/core/presentation/components/ui/dialog";
import {
    isCalendarOpenSignal,
    isSubmittingSignal,
    preferredNameSignal,
} from "../../../application/signals/auth-signals";
import {SubmitButton} from "../ui/submit-button";
import {useEffect} from "react";

interface CompleteFormProps {
    handleBack: () => void;
    onSubmit: (data: RegisterFormValues) => Promise<void>;
    completeProfileForm: ReturnType<typeof useForm<RegisterFormValues>>;
    isExternalAuth?: boolean;
}

export default function CompleteProfileForm({
    handleBack,
    onSubmit,
    completeProfileForm,
    isExternalAuth = false,
}: CompleteFormProps) {

    const handleSubmit = async (data: RegisterFormValues ) => {
        isSubmittingSignal.value = true;
        try {
            await onSubmit(data);
        } finally {
            isSubmittingSignal.value = false;
        }
    };

    const handleCalendarOpenChange = (open: boolean) => {
        isCalendarOpenSignal.value = open;
    };

    useEffect(() => {
        console.log(completeProfileForm.formState.errors);
    }, [completeProfileForm.formState.errors]);

    useEffect(() => {
        // Update the form's isExternalAuth value whenever the prop changes
        completeProfileForm.setValue('isExternalAuth', isExternalAuth);
    }, [isExternalAuth]);

    return (
        <Form {...completeProfileForm}>
            <form
                onSubmit={completeProfileForm.handleSubmit(handleSubmit)}
                className="space-y-4"
            >
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
                    <h2 className="text-xl font-bold">Finish signing up</h2>
                </div>

                <div className="space-y-6">
                    <div className="space-y-4">
                        <div className="space-y-1">
                            <FormLabel>Legal name</FormLabel>
                            <div className="grid grid-cols-2 gap-4">
                                <FormField
                                    control={completeProfileForm.control}
                                    name="firstName"
                                    render={({field}) => (
                                        <FormItem>
                                            <FormControl>
                                                <FloatingLabelInput
                                                    label="First name on ID"
                                                    {...field}
                                                />
                                            </FormControl>
                                            <FormMessage/>
                                        </FormItem>
                                    )}
                                />
                                <FormField
                                    control={completeProfileForm.control}
                                    name="lastName"
                                    render={({field}) => (
                                        <FormItem>
                                            <FormControl>
                                                <FloatingLabelInput
                                                    label="Last name on ID"
                                                    {...field}
                                                />
                                            </FormControl>
                                            <FormMessage/>
                                        </FormItem>
                                    )}
                                />
                            </div>
                            <FormDescription>
                                Ensure this matches the name on your government ID. If you use a
                                different name, you can add a{" "}
                                <Dialog>
                                    <DialogTrigger asChild>
                                        <Button
                                            variant="link"
                                            className="p-0 text-black underline h-auto font-normal text-[0.8rem] "
                                        >
                                            preferred first name
                                        </Button>
                                    </DialogTrigger>
                                    <DialogContent>
                                        <DialogHeader>
                                            <DialogTitle>Add your preferred first name</DialogTitle>
                                        </DialogHeader>
                                        <FormField
                                            control={completeProfileForm.control}
                                            name="preferredFirstName"
                                            render={({field}) => (
                                                <FormItem>
                                                    <FormControl>
                                                        <FloatingLabelInput
                                                            label="Enter your preferred name"
                                                            {...field}
                                                            onChange={(e) => {
                                                                field.onChange(e.target.value);
                                                                preferredNameSignal.value = e.target.value;
                                                                if (e.target.value === "") {
                                                                    completeProfileForm.clearErrors(
                                                                        "preferredFirstName"
                                                                    );
                                                                }
                                                            }}
                                                        />
                                                    </FormControl>
                                                    <FormDescription>
                                                        This is how you'll be known to other Dormo users.
                                                    </FormDescription>
                                                    <FormMessage/>
                                                </FormItem>
                                            )}
                                        />
                                        <DialogFooter>
                                            <DialogClose asChild>
                                                <Button
                                                    variant="ghost"
                                                    onClick={() => {
                                                        completeProfileForm.setValue(
                                                            "preferredFirstName",
                                                            ""
                                                        );
                                                        preferredNameSignal.value = "";
                                                    }}
                                                >
                                                    Cancel
                                                </Button>
                                            </DialogClose>
                                            <DialogClose asChild>
                                                <Button disabled={!preferredNameSignal.value.trim()}>
                                                    Save
                                                </Button>
                                            </DialogClose>
                                        </DialogFooter>
                                    </DialogContent>
                                </Dialog>
                                .
                            </FormDescription>
                        </div>

                        <FormField
                            control={completeProfileForm.control}
                            name="dob"
                            render={({field}) => (
                                <FormItem className="flex flex-col">
                                    <FormLabel>Date of birth</FormLabel>
                                    <Popover
                                        open={isCalendarOpenSignal.value}
                                        onOpenChange={handleCalendarOpenChange}
                                    >
                                        <PopoverTrigger asChild>
                                            <FormControl>
                                                <Button
                                                    variant={"outline"}
                                                    className={cn(
                                                        "w-full pl-3 text-left font-normal h-14",
                                                        !field.value && "text-muted-foreground"
                                                    )}
                                                    type="button"
                                                >
                                                    {field.value ? (
                                                        format(field.value, "PPP")
                                                    ) : (
                                                        <span>Birthdate</span>
                                                    )}
                                                    <CalendarIcon className="ml-auto h-4 w-4 opacity-50"/>
                                                </Button>
                                            </FormControl>
                                        </PopoverTrigger>
                                        <PopoverContent
                                            className="w-auto p-0"
                                            align="start"
                                            onClick={(e) => e.stopPropagation()}
                                        >
                                            <Calendar
                                                mode="single"
                                                selected={field.value}
                                                onSelect={(date) => {
                                                    field.onChange(date);
                                                    console.log(date);
                                                    // Close calendar after selection
                                                    handleCalendarOpenChange(false);
                                                }}
                                                disabled={(date) =>
                                                    date > new Date() || date < new Date("1900-01-01")
                                                }
                                                autoFocus
                                            />
                                        </PopoverContent>
                                    </Popover>
                                    <FormDescription>
                                        Your birth date will remain private and won't be visible to
                                        other Dormo users.
                                    </FormDescription>
                                    <FormMessage/>
                                </FormItem>
                            )}
                        />

                        <FormField
                            control={completeProfileForm.control}
                            name="contactInfo"
                            render={({field}) => (
                                <FormItem>
                                    <FormLabel>Contact info</FormLabel>
                                    <FormControl>
                                        <FloatingLabelInput label="Email" type="email" {...field} />
                                    </FormControl>
                                    <FormDescription>
                                        You will receive bookings confirmations and receipts via
                                        email.
                                    </FormDescription>
                                    <FormMessage/>
                                </FormItem>
                            )}
                        />
                        <FormField
                            control={completeProfileForm.control}
                            name="emailSubscription"
                            render={({field}) => (
                                <FormItem>
                                    <div className="flex items-center space-x-2">
                                        <FormControl>
                                            <Checkbox
                                                checked={field.value}
                                                onCheckedChange={field.onChange}
                                            />
                                        </FormControl>
                                        <label
                                            htmlFor="terms"
                                            className="text-sm font-normal leading-none peer-disabled:cursor-not-allowed peer-disabled:opacity-70"
                                        >
                                            I want to receive marketing promotions and updates via
                                            email.
                                        </label>
                                    </div>
                                </FormItem>
                            )}
                        />

                        {/* Only show password fields for regular registration */}
                        {!isExternalAuth && (
                            <>
                                <FormField
                                    control={completeProfileForm.control}
                                    name="password"
                                    render={({ field }) => (
                                        <FormItem>
                                            <FormLabel>Password</FormLabel>
                                            <FormControl>
                                                <FloatingLabelInput
                                                    type="password"
                                                    label="Create a password"
                                                    {...field}
                                                />
                                            </FormControl>
                                            <FormMessage />
                                        </FormItem>
                                    )}
                                />

                                <FormField
                                    control={completeProfileForm.control}
                                    name="confirmPassword"
                                    render={({ field }) => (
                                        <FormItem>
                                            <FormLabel>Confirm password</FormLabel>
                                            <FormControl>
                                                <FloatingLabelInput
                                                    type="password"
                                                    label="Enter the same password"
                                                    {...field}
                                                />
                                            </FormControl>
                                            <FormMessage />
                                        </FormItem>
                                    )}
                                />
                            </>
                        )}
                    </div>

                    <div className="space-y-4">
                        <FormDescription>
                            By clicking Agree and continue, I accept Dormo's Terms,
                            Nondiscrimination Policy, and acknowledge the Privacy Policy.
                        </FormDescription>

                        <SubmitButton
                            className="w-full"
                            size="lg"
                            isLoading={isSubmittingSignal.value}
                        >
                            {isExternalAuth ? "Complete with Google" : "Agree and continue"}
                        </SubmitButton>
                    </div>
                </div>
            </form>
        </Form>
    );
}
