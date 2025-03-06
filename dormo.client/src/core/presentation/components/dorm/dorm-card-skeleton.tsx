export function DormCardSkeleton() {
    return (
        <div className="group relative w-full">
            {/* Image skeleton - matching the exact dimensions and border radius */}
            <div className="relative aspect-square overflow-hidden rounded-xl bg-gray-200">
                {/* Verified Badge skeleton - matching position */}
                <div className="absolute top-3 left-3 z-10">
                    <div className="h-6 w-20 bg-gray-300 rounded-full"></div>
                </div>

                {/* Favorite Button skeleton - exact size and position */}
                <div className="absolute top-3 right-3 z-10">
                    <div className="h-6 w-6 bg-gray-300 rounded-full"></div>
                </div>

                {/* Carousel Indicators skeleton */}
                <div className="absolute bottom-2 left-1/2 -translate-x-1/2 flex gap-1 z-10">
                    {[0, 1, 2, 3, 4].map((_, index) => (
                        <div key={index} className="w-1.5 h-1.5 rounded-full bg-gray-300"/>
                    ))}
                </div>
            </div>

            {/* Card Content skeleton - matching exact spacing */}
            <div className="py-4 space-y-1">
                <div className="flex justify-between items-start">
                    <div className="space-y-1 w-full">
                        <div className="flex justify-between items-start">
                            {/* Address skeleton */}
                            <div className="h-5 w-[70%] bg-gray-300 rounded"></div>
                            {/* Rating skeleton */}
                            <div className="flex items-center gap-1">
                                <div className="h-4 w-4 bg-gray-300 rounded"></div>
                                <div className="h-4 w-8 bg-gray-300 rounded"></div>
                            </div>
                        </div>
                        {/* Name skeleton */}
                        <div className="h-4 w-40 bg-gray-200 rounded"></div>
                    </div>
                </div>
                <div className="flex justify-between items-end">
                    <div>
                        {/* "starts at" text skeleton */}
                        <div className="h-4 w-16 bg-gray-200 rounded mb-1"></div>
                        {/* Price skeleton */}
                        <div className="flex items-center gap-1">
                            <div className="h-5 w-24 bg-gray-300 rounded font-semibold"></div>
                            <div className="h-5 w-14 bg-gray-200 rounded"></div>
                        </div>
                    </div>
                    {/* Available rooms badge skeleton */}
                    <div className="h-7 w-24 bg-gray-300 rounded-full"></div>
                </div>
            </div>
        </div>
    );
}

export function DormCardSkeletonGrid({count = 10}: { count?: number }) {
    return (
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 xl:grid-cols-5 gap-6 pb-10">
            {Array(count)
                .fill(0)
                .map((_, idx) => (
                    <DormCardSkeleton key={idx}/>
                ))}
        </div>
    );
}

// For use in the "load more" section
export function DormCardSkeletonRow({count = 4}: { count?: number }) {
    return (
        <div className="w-full grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 gap-7">
            {Array(count)
                .fill(0)
                .map((_, idx) => (
                    <DormCardSkeleton key={idx}/>
                ))}
        </div>
    );
}
