import React, {useState} from "react";
import {cn} from "@/lib/utils";
import {Eye, EyeOff} from "lucide-react";
import {Button} from "./button";

interface FloatingLabelInputProps extends React.InputHTMLAttributes<HTMLInputElement> {
    label: string;
}

const FloatingLabelInput = React.forwardRef<HTMLInputElement, FloatingLabelInputProps>(
    ({className, label, type, ...props}, ref) => {
        const [showPassword, setShowPassword] = useState(false);
        const isPasswordType = type === 'password';

        return (
            <div className={cn("relative w-full", className)}>
                <input
                    type={isPasswordType ? (showPassword ? 'text' : 'password') : type}
                    className={cn(
                        "peer w-full h-14 rounded-lg px-4 pt-7 pb-2 border border-input bg-transparent text-sm",
                        "placeholder-transparent focus:outline-none focus:ring-1 focus:ring-primary",
                        "disabled:cursor-not-allowed disabled:opacity-50",
                        isPasswordType && "pr-12"
                    )}
                    placeholder={label}
                    ref={ref}
                    {...props}
                />
                <label
                    className={cn(
                        "absolute left-4 top-1/2 -translate-y-1/2 text-sm text-muted-foreground transition-all duration-150",
                        "peer-focus:top-4 peer-focus:text-xs peer-focus:text-primary",
                        "peer-[:not(:placeholder-shown)]:top-4 peer-[:not(:placeholder-shown)]:text-xs"
                    )}
                >
                    {label}
                </label>
                {isPasswordType && (
                    <Button
                        type="button"
                        variant="ghost"
                        size="icon"
                        className="absolute right-2 top-1/2 -translate-y-1/2 "
                        onClick={() => setShowPassword(!showPassword)}
                    >
                        {showPassword ? (
                            <EyeOff className="h-4 w-4 text-muted-foreground"/>
                        ) : (
                            <Eye className="h-4 w-4 text-muted-foreground"/>
                        )}
                    </Button>
                )}
            </div>
        );
    }
);

FloatingLabelInput.displayName = "FloatingLabelInput";

export {FloatingLabelInput};
