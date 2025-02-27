import {Link} from "@tanstack/react-router"
import DormoLogo from '@/assets/dormo-vertical-main.svg'
import TextLink from "@/core/presentation/components/shared/text-link.tsx";
import AccountBtn from "@/core/presentation/components/shared/account-btn.tsx";

export default function Navigation() {
    return (
        <nav className="flex items-center justify-between p-4 bg-background">
            <Link to="/" className="font-bold">
                <img
                    src={DormoLogo}
                    alt="Dormo"
                    className="h-8 w-auto"
                />
            </Link>
            <div className="flex gap-8 items-center">
                <TextLink href="/dorms" text="For business" isPrimary={true}/>
                <TextLink href="/deals" text="Student deals"/>
                <AccountBtn/>
            </div>
        </nav>
    )
}
