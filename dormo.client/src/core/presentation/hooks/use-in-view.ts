import { useRef, useEffect, useState } from "preact/compat";

interface UseInViewOptions {
  threshold?: number;
  rootMargin?: string;
  triggerOnce?: boolean;
}

// Make the hook generic to accept any HTML element type
export function useInView<T extends HTMLElement = HTMLElement>({
  threshold = 0,
  rootMargin = "0px",
  triggerOnce = false,
}: UseInViewOptions = {}) {
  const ref = useRef<T | null>(null);
  const [isInView, setIsInView] = useState(false);

  useEffect(() => {
    const currentRef = ref.current;
    if (!currentRef) return;

    const observer = new IntersectionObserver(
      ([entry]) => {
        const isVisible = entry.isIntersecting;
        setIsInView(isVisible);
        
        // Unobserve if it should only trigger once and is now visible
        if (isVisible && triggerOnce) {
          observer.unobserve(entry.target);
        }
      },
      { threshold, rootMargin }
    );

    observer.observe(currentRef);

    return () => {
      observer.unobserve(currentRef);
    };
  }, [threshold, rootMargin, triggerOnce]);

  return { ref, isInView };
}
