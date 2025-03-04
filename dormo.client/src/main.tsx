import { StrictMode, useEffect } from "react";
import ReactDOM from "react-dom/client";
import { RouterProvider, createRouter } from "@tanstack/react-router";
import "./index.css";
import { Provider } from "react-redux";
import { store } from "@/core/application/store/store";
import { useAppDispatch } from "@/core/presentation/hooks/use-app-dispatch";
import { checkAuthStatus } from "@/core/application/store/auth/auth-slice";
import { routeTree } from "./routeTree.gen";
import { queryClient } from "@/lib/query-client";
import { QueryClientProvider } from "@tanstack/react-query";
import { ThemeProvider } from "@/core/presentation/components/theme-provider";
import { Toaster } from "@/core/presentation/components/ui/sonner";
import AuthModal from "@/core/presentation/components/auth/auth-modal";

const routerOptions = {
  // Use explicit false in production
  devtoolsEnabled: process.env.NODE_ENV !== 'production' && import.meta.env.DEV !== false,
};

const router = createRouter({ routeTree, ...routerOptions });

declare module "@tanstack/react-router" {
  interface Register {
    router: typeof router;
  }
}

function App() {
  const dispatch = useAppDispatch();

  useEffect(() => {
    dispatch(checkAuthStatus());
  }, [dispatch]);

  return <RouterProvider router={router} />;
}

const rootElement = document.getElementById("root")!;

if (!rootElement.innerHTML) {
  const root = ReactDOM.createRoot(rootElement);
  root.render(
    <StrictMode>
      <Provider store={store}>
        <QueryClientProvider client={queryClient}>
          <ThemeProvider defaultTheme="light" storageKey="vite-ui-theme">
            <App />
            <AuthModal />
            <Toaster richColors closeButton position="bottom-right" />
          </ThemeProvider>
        </QueryClientProvider>
      </Provider>
    </StrictMode>
  );
}
