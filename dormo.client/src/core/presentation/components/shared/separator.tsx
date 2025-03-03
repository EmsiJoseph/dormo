import {cn} from "@/lib/utils"

export interface SeparatorProps {
    className?: string
}

export default function Separator({className}: SeparatorProps) {
    return <div className={`${cn(className)} w-full border-b`}></div>
}