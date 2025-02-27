import {useSelector} from "react-redux";
import {RootState} from "@/core/application/store/store";
import {useAppDispatch} from "./use-app-dispatch";
import {openAuthModal} from "@/core/application/store/auth-modal/auth-modal-slice";

interface UseProtectedActionProps {
    onSuccess: () => void;
    returnPath?: string;
}

export const useProtectedAction = ({onSuccess, returnPath}: UseProtectedActionProps) => {
    const dispatch = useAppDispatch();
    const {isAuthenticated} = useSelector((state: RootState) => state.auth);

    const handleAction = () => {
        if (!isAuthenticated) {
            dispatch(openAuthModal({returnPath}));
            return;
        }
        onSuccess();
    };

    return handleAction;
};
