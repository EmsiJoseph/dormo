export function DormCardSkeleton() {
    return (
        <div className="w-full">
            <div className="relative h-80 w-full">
                {/* Image skeleton - matching the exact dimensions and border radius */}
                <div className="h-full w-full relative bg-gray-200 rounded-xl overflow-hidden">
                    {/* Verified Badge skeleton - matching position */}
                    <div className="absolute top-3 left-3 z-10">
                        <div className="h-6 w-20 bg-gray-300 rounded-full"></div>
                    </div>

                    {/* Favorite Button skeleton - exact size and position */}
                    <div className="absolute top-3 right-3 z-10 h-10 w-10 bg-gray-300 rounded-full"></div>

                    {/* Carousel Indicators skeleton */}
                    <div className="absolute bottom-3 left-0 right-0 flex justify-center gap-1.5">
                        {[1, 2, 3, 4].map((_, index) => (
                            <div key={index} className="h-2 w-2 rounded-full bg-gray-300"/>
                        ))}
                    </div>
                </div>
            </div>

            {/* Card Content skeleton - matching exact spacing */}
            <div className="py-4 space-y-1">
                <div className="flex justify-between items-start">
                    <div className="space-y-1 max-w-[65%]">
                        {/* Address skeleton */}
                        <div className="h-4 w-36 bg-gray-300 rounded"></div>
                        {/* Name skeleton */}
                        <div className="h-4 w-24 bg-gray-200 rounded"></div>
                    </div>

                    <div className="flex flex-col items-end space-y-1">
                        {/* Available Rooms Badge skeleton */}
                        <div className="h-6 w-16 sm:w-20 bg-gray-300 rounded-full"></div>
                        {/* Rating skeleton */}
                        <div className="flex items-center gap-1">
                            <div className="h-4 w-4 bg-gray-300 rounded-full"></div>
                            <div className="h-4 w-10 bg-gray-200 rounded"></div>
                        </div>
                    </div>
                </div>

                {/* Price info skeleton */}
                <div className="mt-2">
                    <div className="h-4 w-16 bg-gray-200 rounded mb-1"></div>
                    <div className="flex items-center gap-1">
                        <div className="h-5 w-24 bg-gray-300 rounded"></div>
                        <div className="h-4 w-14 bg-gray-200 rounded"></div>
                    </div>
                </div>
            </div>
        </div>
    );
}

export function DormCardSkeletonGrid({count = 8}: { count?: number }) {
    return (
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 gap-7">
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
