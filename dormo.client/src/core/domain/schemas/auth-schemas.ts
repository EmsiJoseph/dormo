import * as z from "zod";

export const emailSchema = z.object({
    email: z.string().email("Please enter a valid email address"),
});

export const loginSchema = z.object({
    email: z.string().email("Please enter a valid email address"),
    password: z.string().min(6, "Password must be at least 6 characters"),
});

const passwordSchema = z.string()
    .min(8, "Password must be at least 8 characters")
    .regex(/[0-9]/, "Password must contain at least one number")
    .regex(/[a-z]/, "Password must contain at least one lowercase letter")
    .regex(/[A-Z]/, "Password must contain at least one uppercase letter")
    .regex(/[^a-zA-Z0-9]/, "Password must contain at least one special character");

export const initialRegisterSchema = z.object({
    email: z.string().email("Please enter a valid email address"),
    password: passwordSchema,
    confirmPassword: z.string()
}).refine((data) => data.password === data.confirmPassword, {
    message: "Passwords don't match",
    path: ["confirmPassword"],
});

// Single schema for both regular and Google auth registration
export const registerSchema = z.object({
    email: z.string().email("Please enter a valid email address"),
    firstName: z.string().min(1, "First name is required"),
    lastName: z.string().min(1, "Last name is required"),
    preferredFirstName: z.string().optional(),
    dob: z.date({
        required_error: "Please select a date",
        invalid_type_error: "That's not a date!",
    }).refine((date) => {
        const today = new Date();
        const age = today.getFullYear() - date.getFullYear();
        const monthDiff = today.getMonth() - date.getMonth();
        const dayDiff = today.getDate() - date.getDate();
        return age > 18 || (age === 18 && (monthDiff > 0 || (monthDiff === 0 && dayDiff >= 0)));
    }, {
        message: "You must be 18 years or older",
    }),
    // Make password and confirmPassword optional
    password: passwordSchema.optional(),
    confirmPassword: z.string().optional(),
    contactInfo: z.string().optional(),
    longitude: z.number().optional(),
    latitude: z.number().optional(),
    emailSubscription: z.boolean().default(false),
    // Optional flag for external auth
    isExternalAuth: z.boolean().optional(),
})
// Add conditional validation for passwords
.refine((data) => {
    // If external auth, skip password validation
    if (data.isExternalAuth) return true;
    
    // If not external auth, both password fields are required
    if (!data.password || !data.confirmPassword) return false;
    
    return data.password === data.confirmPassword;
}, {
    message: "Passwords don't match or are required",
    path: ["confirmPassword"]
});

export type EmailFormValues = z.infer<typeof emailSchema>;
export type LoginFormValues = z.infer<typeof loginSchema>;
export type RegisterFormValues = z.infer<typeof registerSchema>;
export type InitialRegisterFormValues = z.infer<typeof initialRegisterSchema>;

