import { useEffect } from "preact/compat";
import { useAppDispatch } from "./core/presentation/hooks/use-app-dispatch";
import { checkAuthStatus } from "./core/application/store/auth/auth-slice";
import { createRouter, RouterProvider } from "@tanstack/react-router";
import { routeTree } from "./routeTree.gen";


const router = createRouter({ routeTree });

declare module "@tanstack/react-router" {
  interface Register {
    router: typeof router;
  }
}


export default function App() {
  const dispatch = useAppDispatch();

  useEffect(() => {
    dispatch(checkAuthStatus());
  }, [dispatch]);

  return <RouterProvider router={router} />;
}