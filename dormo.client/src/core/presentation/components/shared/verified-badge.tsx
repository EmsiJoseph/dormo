import {Badge} from "@/core/presentation/components/ui/badge.tsx";
import {Check} from "lucide-react";

export default function VerifiedBadge({isVerified}: { isVerified: boolean }) {
    return (
        isVerified ? (
            <Badge
                className="bg-blue-500 hover:bg-blue-600 text-white px-3 py-1 flex items-center gap-1">
                <Check className="h-4 w-4"/>
                <span>Verified</span>
            </Badge>
        ) : <Badge
            className="bg-gray-500 hover:bg-gray-600 text-white px-3 py-1 flex items-center gap-1">

            <span>Not verified</span>
        </Badge>
    )
}