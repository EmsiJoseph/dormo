import { useSignal } from "@preact/signals";
import { useEffect, useRef } from "preact/hooks";

interface LazyImageProps {
  src: string;
  alt: string;
  className?: string;
  onLoaded?: () => void;
}

export function LazyImage({ src, alt, className, onLoaded }: LazyImageProps) {
  const imgRef = useRef<HTMLImageElement>(null);
  const isLoaded = useSignal(false);
  const hasError = useSignal(false);
  
  useEffect(() => {
    // Reset state when src changes
    isLoaded.value = false;
    hasError.value = false;
    
    if (!src) {
      hasError.value = true;
      return;
    }
    
    // Check if image is already in browser cache
    const img = imgRef.current;
    if (img && img.complete) {
      // Image is already loaded (potentially from cache)
      isLoaded.value = true;
      onLoaded?.();
      return;
    }
    
    // Handle loading of non-cached images
    const handleLoad = () => {
      isLoaded.value = true;
      onLoaded?.();
    };
    
    const handleError = () => {
      hasError.value = true;
      console.error(`Failed to load image: ${src}`);
    };
    
    if (img) {
      img.addEventListener('load', handleLoad);
      img.addEventListener('error', handleError);
      
      return () => {
        img.removeEventListener('load', handleLoad);
        img.removeEventListener('error', handleError);
      };
    }
  }, [src, onLoaded]);
  
  return (
    <div className="relative w-full h-full">
      {/* Show loading skeleton if image is not yet loaded */}
      {!isLoaded.value && !hasError.value && (
        <div className="absolute inset-0 bg-gray-200 animate-pulse" />
      )}
      
      {/* Show error placeholder if image failed to load */}
      {hasError.value && (
        <div className="absolute inset-0 bg-gray-100 flex items-center justify-center">
          <span className="text-gray-400 text-sm">Image unavailable</span>
        </div>
      )}
      
      {/* The actual image - hidden until loaded */}
      <img 
        ref={imgRef}
        src={src} 
        alt={alt}
        className={`${className || ''} ${isLoaded.value ? 'opacity-100' : 'opacity-0'} transition-opacity duration-300`} 
      />
    </div>
  );
}
