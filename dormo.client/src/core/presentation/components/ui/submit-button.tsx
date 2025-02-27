import React from "react";
import {Button, ButtonProps} from "./button";
import {Loader2} from "lucide-react";
import {cn} from "@/lib/utils";

interface SubmitButtonProps extends ButtonProps {
    isLoading?: boolean;
    loadingText?: string;
}

export const SubmitButton = React.forwardRef<HTMLButtonElement, SubmitButtonProps>(
    ({className, children, isLoading = false, loadingText, disabled, ...props}, ref) => {
        return (
            <Button
                type="submit"
                className={cn("relative", className)}
                disabled={isLoading || disabled}
                ref={ref}
                {...props}
            >
                {isLoading && (
                    <Loader2 className="mr-2 h-4 w-4 animate-spin"/>
                )}
                {isLoading && loadingText ? loadingText : children}
            </Button>
        );
    }
);

SubmitButton.displayName = "SubmitButton";
