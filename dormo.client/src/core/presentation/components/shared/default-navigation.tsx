import {Link} from "@tanstack/react-router"
import DormoLogo from '@/assets/dormo-vertical-main.svg'
import TextLink from "@/core/presentation/components/shared/text-link";
import AccountBtn from "@/core/presentation/components/shared/account-btn";

export default function DefaultNavigation() {
    return (
        <nav className="flex items-center justify-between bg-background">
            <Link to="/" className="font-bold">
                <img
                    src={DormoLogo}
                    alt="Dormo"
                    className="h-8 w-auto"
                />
            </Link>
            <div className="flex gap-8 items-center">
                <TextLink className="hidden sm:block" href="/dorms" text="For business" isPrimary={true}/>
                <TextLink className="hidden sm:block" href="/deals" text="Student deals"/>
                <AccountBtn/>
            </div>
        </nav>
    )
}
