import { Outlet } from "@tanstack/react-router"
import Navigation from "./navigation.tsx"
import Separator from "@/core/presentation/components/shared/separator.tsx";

export default function RootLayout() {
    return (
        <div className="min-h-screen">
            <div className="max-w-[1440px] mx-auto">
                <Navigation />
            </div>
            <Separator/>
            <main className="max-w-[1440px] mx-auto py-8 px-4">
                <Outlet />
            </main>
        </div>
    )
}
