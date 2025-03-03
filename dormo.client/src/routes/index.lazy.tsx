import {createLazyFileRoute} from "@tanstack/react-router";
import {DormListing} from "@/core/domain/entities/Dorm";
import {DormCard} from "@/core/presentation/components/dorm/dorm-card";
import {Button} from "@/core/presentation/components/ui/button";
import {DormCardSkeletonGrid} from "@/core/presentation/components/dorm/dorm-card-skeleton";

import {useDormListings} from "@/core/presentation/hooks/use-dorm-listings";
import {AllDormsSignal, DormFilterSignal} from "@/core/application/signals/dorm-signals";
import {useEffect} from "preact/compat";

export const Route = createLazyFileRoute("/")({
    component: IndexLazy,
});

function IndexLazy() {
    const {data, isLoading, isError, error} = useDormListings(DormFilterSignal.value);

    const dormListings = data?.items || [];
    const page = data?.page || 1;
    const hasNext = data?.hasNext || false;

    useEffect(() => {
        if (dormListings && dormListings.length > 0) {
            if (page === 1) {
                AllDormsSignal.value = [...dormListings];
            } else {
                AllDormsSignal.value = [...AllDormsSignal.value, ...dormListings];
            }
        }
    }, [dormListings, page]);

    const handleFavorite = (dormId: number) => {
        console.log("Favorite clicked:", dormId);
    };

    const loadMore = () => {
        const nextPage = page + 1;
        DormFilterSignal.value = {...DormFilterSignal.value, page: nextPage};
    };

    if (isLoading && DormFilterSignal.value.page === 1) {
        return <DormCardSkeletonGrid count={8}/>;
    }

    if (isError) {
        return (
            <div className="flex justify-center items-center min-h-screen text-destructive">
                Error loading dorms: {error?.message || "Unknown error"}
            </div>
        );
    }


    return (
        <div className="flex flex-col space-y-7 w-full">
            {AllDormsSignal.value.length === 0 ? (
                <div className="text-center py-8">No dorms found</div>
            ) : (
                <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 xl:grid-cols-5 gap-6 pb-10">
                    {AllDormsSignal.value.map((dorm: DormListing) => (
                        <DormCard
                            key={dorm.id}
                            dorm={dorm}
                            onFavorite={handleFavorite}
                        />
                    ))}
                </div>
            )}

            {/* Load More Section */}
            {isLoading && page > 1 ? (
                <DormCardSkeletonGrid count={4}/>
            ) : (
                hasNext && (
                    <div className="flex flex-col items-center gap-2 pb-4">
                        <span className="font-medium text-base">
                          Continue searching for dorms near schools/uni
                        </span>
                        <Button
                            className="px-8 bg-dormo-black hover:bg-dormo-black/90 h-11"
                            onClick={loadMore}
                        >
                            Load more
                        </Button>
                    </div>
                )
            )}
        </div>
    );
}
