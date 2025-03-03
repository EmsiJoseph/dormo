import {Badge} from "@/core/presentation/components/ui/badge";
import {DormListing} from "@/core/domain/entities/Dorm";
import {ChevronLeft, ChevronRight, Heart, Star} from "lucide-react";
import {useSignal, useSignalEffect} from "@preact/signals";
import VerifiedBadge from "@/core/presentation/components/shared/verified-badge";
import {motion, AnimatePresence} from "framer-motion"

interface DormCardProps {
    dorm: DormListing;
    onFavorite?: (dormId: number) => void;
    isFavorite?: boolean;
}

export function DormCard({
                             dorm,
                             onFavorite,
                             isFavorite = false,
                         }: DormCardProps) {
    const isHovering = useSignal(false);
    const currentImageIndex = useSignal(0);
    const imagesLoaded = useSignal<Record<number, boolean>>({});
    const isLoading = useSignal(false);
    const direction = useSignal<number>(0);

    const sortedImages = [...dorm.images].sort((a, b) => a.order - b.order);

    useSignalEffect(() => {
        if (sortedImages.length > 0) {
            preloadImage(0);
        }
    });

    const preloadImage = (index: number) => {
        if (sortedImages.length === 0 || imagesLoaded.value[index]) return;

        isLoading.value = true;

        const img = new Image();
        img.onload = () => {
            imagesLoaded.value = {...imagesLoaded.value, [index]: true};
            isLoading.value = false;
        };
        img.onerror = () => {
            isLoading.value = false;
        };
        img.src = sortedImages[index].url;
    };

    const handleMouseEnter = () => {
        isHovering.value = true;

        // Preload the next image if available
        if (sortedImages.length > currentImageIndex.value + 1) {
            preloadImage(currentImageIndex.value + 1);
        }

        // Try to preload previous image too
        if (currentImageIndex.value > 0) {
            preloadImage(currentImageIndex.value - 1);
        }
    };

    const nextImage = () => {
        if (currentImageIndex.value < sortedImages.length - 1) {
            const nextIndex = currentImageIndex.value + 1;
            currentImageIndex.value = nextIndex;
            preloadImage(nextIndex);

            direction.value = 1;

            // Preload the image after next if it exists
            if (nextIndex < sortedImages.length - 1) {
                preloadImage(nextIndex + 1);
            }
        }
    };


    const prevImage = () => {
        if (currentImageIndex.value > 0) {
            const prevIndex = currentImageIndex.value - 1;
            currentImageIndex.value = prevIndex;
            preloadImage(prevIndex);

            direction.value = -1;

            // Also preload the image before previous if it exists
            if (prevIndex > 0) {
                preloadImage(prevIndex - 1);
            }
        }
    };

    const variants = {
        enter: (direction: number) => {
            return {
                x: direction > 0 ? 300 : -300,
                opacity: 0,
            }
        },
        center: {
            zIndex: 1,
            x: 0,
            opacity: 1,
        },
        exit: (direction: number) => {
            return {
                zIndex: 0,
                x: direction < 0 ? 300 : -300,
                opacity: 0,
            }
        },
    }

    const handleFavorite = () => {
        if (onFavorite) {
            onFavorite(dorm.id);
        }
    };

    return (
        <div
            className="group relative"
            onMouseEnter={handleMouseEnter}
            onMouseLeave={() => (isHovering.value = false)}
        >
            {/* Image Carousel */}
            <div className="relative aspect-square overflow-hidden rounded-xl">
                {sortedImages.length > 0 ? (
                    <AnimatePresence initial={false} custom={direction.value}>
                        <motion.div
                            key={currentImageIndex.value}
                            custom={direction.value}
                            variants={variants}
                            initial="enter"
                            animate="center"
                            exit="exit"
                            transition={{
                                x: {type: "spring", stiffness: 300, damping: 30},
                                opacity: {duration: 0.2},
                            }}
                            className="absolute w-full h-full"
                        >
                            <img
                                src={
                                    sortedImages[currentImageIndex.value].url ||
                                    "/placeholder.svg"
                                }
                                alt={`${dorm.name} - image ${currentImageIndex.value + 1}`}
                                className="object-cover h-full w-full transition-transform duration-300 group-hover:scale-105"
                            />
                        </motion.div>
                    </AnimatePresence>

                ) : (
                    <div className="h-full w-full flex items-center justify-center bg-gray-200">
                        <span className="text-gray-500">No image available</span>
                    </div>
                )}

                {/* Verified Badge */}
                <div className="absolute top-3 left-3 z-10">
                    <VerifiedBadge isVerified={dorm.isVerified}/>
                </div>

                {/* Favorite Button */}
                <button
                    onClick={() => handleFavorite()}
                    className="absolute top-3 right-3 z-10"
                    aria-label={isFavorite ? "Remove from favorites" : "Add to favorites"}
                >
                    <Heart className={`h-6 w-6 ${isFavorite ? "fill-red-500 stroke-red-500" : "stroke-white"}`}/>
                </button>

                {/* Navigation Arrows */}
                {isHovering.value && currentImageIndex.value > 0 && (
                    <button
                        onClick={(e) => {
                            e.preventDefault()
                            e.stopPropagation()
                            prevImage()
                        }}
                        className="absolute left-2 top-1/2 -translate-y-1/2 bg-white rounded-full p-1 shadow-md opacity-0 group-hover:opacity-100 transition-opacity z-10"
                        aria-label="Previous image"
                    >
                        <ChevronLeft className="h-4 w-4"/>
                    </button>
                )}

                {isHovering.value &&
                    currentImageIndex.value < sortedImages.length - 1 && (
                        <button
                            onClick={(e) => {
                                e.preventDefault()
                                e.stopPropagation()
                                nextImage()
                            }}
                            className="absolute right-2 top-1/2 -translate-y-1/2 bg-white rounded-full p-1 shadow-md opacity-0 group-hover:opacity-100 transition-opacity z-10"
                            aria-label="Next image"
                        >
                            <ChevronRight className="h-4 w-4"/>
                        </button>
                    )}

                {/* Carousel Indicators */}
                {sortedImages.length > 1 && (
                    <div className="absolute bottom-2 left-1/2 -translate-x-1/2 flex gap-1 z-10">
                        {sortedImages.slice(0, 5).map((_, index) => (
                            <button
                                key={index}
                                onClick={(e) => {
                                    e.preventDefault()
                                    e.stopPropagation()
                                    direction.value = (index > currentImageIndex.value) ? 1 : -1;
                                    currentImageIndex.value = index
                                }}
                                className={`w-1.5 h-1.5 rounded-full ${index === currentImageIndex.value || (index === 4 && currentImageIndex.value >= 5) ? "bg-white" : "bg-white/60"}`}
                                aria-label={`Go to image ${index + 1}`}
                            />
                        ))}
                    </div>
                )}
            </div>

            {/* Card Content */}
            <div className="py-4 space-y-1">
                <div className="flex justify-between items-start">
                    <div className="space-y-1 w-full">
                        <div className="flex justify-between items-start">
                            <h3 className="font-medium truncate max-w-[70%]" title={dorm.address}>
                                {dorm.address}
                            </h3>
                            <div className="flex items-center gap-1">
                                <Star className="h-4 w-4"></Star>
                                <span>{dorm.rating.toFixed(1)}</span>
                            </div>

                        </div>

                        <p className="text-muted-foreground text-sm">{dorm.name}</p>
                    </div>


                </div>
                <div className="flex justify-between items-end">
                    <div>
                        <p className="text-sm text-gray-700">starts at</p>
                        <span>
                    <span className="font-semibold text-gray-900">
                      ₱{dorm.minPrice}
                    </span>{" "}
                            month
                  </span>
                    </div>
                    {dorm.availableRooms > 0 && (
                        <Badge
                            className="bg-dormo-text hover:bg-dormo-text text-white px-3 py-1.5 rounded-full whitespace-nowrap"
                            title={`${dorm.availableRooms} available rooms`}>
                            {dorm.availableRooms} Available
                        </Badge>
                    )}
                </div>
            </div>
        </div>
    );
}
