import { StrictMode } from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import { Provider } from "react-redux";
import { store } from "@/core/application/store/store";
import { queryClient } from "@/lib/query-client";
import { QueryClientProvider } from "@tanstack/react-query";
import { ThemeProvider } from "@/core/presentation/components/theme-provider";
import { Toaster } from "@/core/presentation/components/ui/sonner";
import AuthModal from "@/core/presentation/components/auth/auth-modal";
import App from "./App";



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
