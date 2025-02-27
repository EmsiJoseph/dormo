import {Link} from "@tanstack/react-router";

interface TextLinkProps {
    href: string;
    text: string;
    className?: string;
    isPrimary?: boolean;
}

export default function TextLink({href, className, isPrimary = false, text}: TextLinkProps) {
    return (
        <Link
            to={href}
            className={`${className} 
            ${isPrimary ? 'text-dormo-text' : 'text-primary'} text-lg font-medium 
            ${isPrimary ? 'hover:text-dormo-text' : 'hover:text-primary'} no-underline`}
        >
            {text}
        </Link>
    )
}