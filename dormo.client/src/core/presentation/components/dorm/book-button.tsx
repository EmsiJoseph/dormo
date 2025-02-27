import {Button} from "../ui/button";
import {useProtectedAction} from "@/core/presentation/hooks/use-protected-action";

export default function BookButton() {
    const handleBook = useProtectedAction({
        onSuccess: () => {
            // Your booking logic here
        },
        returnPath: "/booking"
    });

    return (
        <Button onClick={handleBook}>
            Book Now
        </Button>
    );
}
