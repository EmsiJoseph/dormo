import { cn } from "@/lib/utils";
import { ImageIcon } from "lucide-react";
import { useState } from "react";

interface ImageProps extends React.ImgHTMLAttributes<HTMLImageElement> {
  fallback?: React.ReactNode;
}

export function Image({
  className,
  src,
  alt = "",
  fallback,
  ...props
}: ImageProps) {
  const [isLoading, setIsLoading] = useState(true);
  const [hasError, setHasError] = useState(false);

  return (
    <div className={cn("relative overflow-hidden", className)}>
      {(isLoading || hasError) && (
        <div className="absolute inset-0 flex items-center justify-center bg-muted">
          {hasError ? (
            fallback || (
              <div className="flex flex-col items-center text-muted-foreground">
                <ImageIcon className="h-8 w-8" />
                <span className="text-sm">Failed to load image</span>
              </div>
            )
          ) : (
            <div className="h-8 w-8 animate-spin rounded-full border-4 border-muted-foreground border-t-primary" />
          )}
        </div>
      )}
      <img
        className={cn("h-full w-full object-cover", {
          "opacity-0": isLoading || hasError,
        })}
        src={src}
        alt={alt}
        onLoad={() => setIsLoading(false)}
        onError={() => {
          setIsLoading(false);
          setHasError(true);
        }}
        {...props}
      />
    </div>
  );
}
