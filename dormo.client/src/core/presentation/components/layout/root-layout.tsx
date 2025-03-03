import {Outlet} from "@tanstack/react-router"
import DefaultNavigation from "../shared/default-navigation.tsx"
import Separator from "@/core/presentation/components/shared/separator.tsx";

export default function RootLayout() {
    return (
        <div className="min-h-screen">
            <div className="mx-6 sm:mx-10 md:mx-15 lg:mx-20 py-4">
                <DefaultNavigation/>
            </div>

            {/*TODO: Insert search bar here*/}

            {/*TODO: Insert categories here*/}
            <Separator className="relative 
                shadow-md pb-1
                md:shadow-none md:pb-0 
                after:absolute after:bottom-0 after:left-0 after:w-full after:h-2 
                after:shadow-[0_1px_3px_0_rgba(0,0,0,0.1)]
                md:after:shadow-none
                after:pointer-events-none"/>
            <main className="mx-6 sm:mx-10 md:mx-15 lg:mx-20 py-4">
                <Outlet/>
            </main>
        </div>
    )
}
