import { createRootRoute } from "@tanstack/react-router";
import { TanStackRouterDevtools } from "@tanstack/router-devtools";
import RootLayout from "@/core/presentation/components/layout/root-layout";

export const Route = createRootRoute({
  component: Root,
});

function Root() {
  const isDev = import.meta.env.MODE === "development";

  return (
    <>
      <RootLayout />
      {isDev && <TanStackRouterDevtools />}
    </>
  );
}
