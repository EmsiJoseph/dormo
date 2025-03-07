import {createLazyFileRoute} from "@tanstack/react-router";
import {useDormDetails} from "@/core/presentation/hooks/use-dorm-details";
import {Button} from "@/core/presentation/components/ui/button";
import {ChevronsRight, Heart, MapPin, MapPinned, Share2, Shield, Star} from "lucide-react";
import {Badge} from "@/core/presentation/components/ui/badge";
import {formatCurrency} from "@/lib/utils/formatters";
import {useRef, useEffect} from "preact/compat";
import {Tabs, TabsContent, TabsList, TabsTrigger} from "@/core/presentation/components/ui/tabs.tsx";
import {DormListingDto} from "@/core/domain/entities/Dorm.ts";
import {DormCard} from "@/core/presentation/components/dorm/dorm-card.tsx";
import Separator from "@/core/presentation/components/shared/separator.tsx";

export const Route = createLazyFileRoute("/dorm/$dormId")({
    component: DormDetails,
});

function DormDetails() {
    const {dormId} = Route.useParams();
    const {data: dorm} = useDormDetails(parseInt(dormId));

    const reviewsRef = useRef<HTMLDivElement>(null);
    const inquireCardRef = useRef<HTMLDivElement>(null);

    useEffect(() => {
        const handleScroll = () => {
            if (reviewsRef.current && inquireCardRef.current) {
                const reviewsTop = reviewsRef.current.getBoundingClientRect().top
                const inquireCard = inquireCardRef.current

                if (reviewsTop <= 0) {
                    inquireCard.style.position = "absolute"
                    inquireCard.style.top = `${reviewsRef.current.offsetTop - inquireCard.offsetHeight}px`
                } else {
                    inquireCard.style.position = "sticky"
                    inquireCard.style.top = "4rem"
                }
            }
        }

        window.addEventListener("scroll", handleScroll)
        return () => window.removeEventListener("scroll", handleScroll)
    }, [])

    return (
        <div className="space-y-8">
            {/* Title Section */}
            <div className="flex items-center justify-between">
                <h1 className="text-xl font-semibold">{dorm?.categoryName} | Near AMA University</h1>
                <div className="flex items-center space-x-4">
                    <button className="flex items-center space-x-2 text-sm font-medium">
                        <Share2 size={18}/>
                        <span>Share</span>
                    </button>
                    <button className="flex items-center space-x-2 text-sm font-medium">
                        <Heart size={18}/>
                        <span>Wishlist</span>
                    </button>
                </div>
            </div>

            {/* Image Gallery */
            }
            <div className="grid grid-cols-1 md:grid-cols-3 gap-2 mb-8">
                <div className="md:col-span-2 relative rounded-l-lg overflow-hidden">
                    <img
                        src={dorm?.images[0].url || "/placeholder.svg"}
                        alt={dorm?.images[0].caption}
                        width={800}
                        height={500}
                        className="w-full h-[400px] object-cover"
                    />
                </div>
                <div className="hidden md:grid grid-cols-2 gap-2">
                    {dorm?.images.slice(1, 5).map((image, index) => (
                        <div key={index} className="relative overflow-hidden rounded-r-lg">
                            <img
                                src={image.url || "/placeholder.svg"}
                                alt={image.caption}
                                width={400}
                                height={200}
                                className="w-full h-[198px] object-cover"
                            />
                            {index === 3 && (
                                <div className="absolute bottom-4 right-4">
                                    <button
                                        className="bg-white rounded-md px-3 py-1 text-xs font-medium flex items-center space-x-1 shadow-md">
                                        <svg width="16" height="16" viewBox="0 0 24 24" fill="none"
                                             xmlns="http://www.w3.org/2000/svg">
                                            <rect x="2" y="2" width="20" height="20" rx="5" stroke="currentColor"
                                                  strokeWidth="2"/>
                                            <circle cx="8.5" cy="8.5" r="1.5" fill="currentColor"/>
                                            <path
                                                d="M21 15L16 10L5 21"
                                                stroke="currentColor"
                                                strokeWidth="2"
                                                strokeLinecap="round"
                                                strokeLinejoin="round"
                                            />
                                        </svg>
                                        <span>See all photos</span>
                                    </button>
                                </div>
                            )}
                        </div>
                    ))}
                </div>
            </div>

            {/* Main Content */
            }
            <div className="grid grid-cols-1 lg:grid-cols-3 gap-8">
                {/* Left Column - Property Details */}
                <div className="lg:col-span-2">
                    {/* Property Header */}
                    <div className="mb-6">
                        <div className="flex items-start justify-between">
                            <div>
                                <h2 className="text-2xl font-bold mb-1">{dorm?.name}</h2>
                                <div className="flex items-center mb-2">
                                    <Badge variant="secondary" className="bg-blue-100 text-blue-700 mr-2">
                                        <svg
                                            width="16"
                                            height="16"
                                            viewBox="0 0 24 24"
                                            fill="none"
                                            xmlns="http://www.w3.org/2000/svg"
                                            className="mr-1"
                                        >
                                            <path
                                                d="M9 12L11 14L15 10M21 12C21 16.9706 16.9706 21 12 21C7.02944 21 3 16.9706 3 12C3 7.02944 7.02944 3 12 3C16.9706 3 21 7.02944 21 12Z"
                                                stroke="currentColor"
                                                strokeWidth="2"
                                                strokeLinecap="round"
                                                strokeLinejoin="round"
                                            />
                                        </svg>
                                        Verified
                                    </Badge>
                                </div>
                                <p className="text-sm text-gray-600 mb-2">{dorm?.address}</p>
                                <div className="flex items-center text-sm">
                                    <span className="mr-4">2 Bed Spaces</span>
                                    <span className="mr-4">•</span>
                                    <span className="mr-4">1 Private Room</span>
                                    <span className="mr-4">•</span>
                                    <span>Apartment Style</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    {/* Ratings */}
                    <div className="flex items-center justify-between mb-6 pb-6 border-b">
                        <div className="flex items-center">
                            <div className="flex items-center mr-2">
                                <span className="font-semibold mr-1">{dorm?.rating}</span>
                                <div className="flex">
                                    {[1, 2, 3, 4, 5].map((star) => (
                                        <Star
                                            key={star}
                                            size={16}
                                            className={
                                                star <= Math.floor(dorm?.rating || 0)
                                                    ? "fill-yellow-400 text-yellow-400"
                                                    : star <= (dorm?.rating || 0)
                                                        ? "fill-yellow-400 text-yellow-400"
                                                        : "text-gray-300"
                                            }
                                        />
                                    ))}
                                </div>
                            </div>
                            <span className="text-sm text-gray-600">{dorm?.reviewCount} reviews</span>
                        </div>
                        <div className="flex items-center">
                            <Shield size={18} className="mr-1 text-green-500"/>
                            <span className="font-semibold mr-1">Safety Score</span>
                            <span className="font-semibold">{dorm?.safetyScore}</span>
                            <span className="text-sm text-gray-500 ml-1">/10</span>
                        </div>
                    </div>
                    {/* Managed By */}
                    <div className="mb-6 pb-6 border-b">
                        <div className="flex items-center">
                            <div className="w-10 h-10 rounded-full bg-gray-200 mr-3 overflow-hidden">
                                <img
                                    src="/placeholder.svg?height=40&width=40"
                                    alt="Manager"
                                    width={40}
                                    height={40}
                                    className="w-full h-full object-cover"
                                />
                            </div>
                            <div>
                                <p className="font-medium">
                                    Managed by {dorm?.owner.firstName} {dorm?.owner.lastName}
                                </p>
                                <p className="text-sm text-gray-600">2y on Dormo • Active 2d ago</p>
                            </div>
                        </div>
                    </div>
                    {/* Highlights */}
                    <div className="mb-6 pb-6 border-b">
                        <h3 className="text-lg font-semibold mb-4">Highlights</h3>
                        <div className="grid grid-cols-2 gap-4">
                            {dorm?.amenities.map((amenity, index) => (
                                <div key={index} className="flex items-center">
                                    <div
                                        className="w-6 h-6 rounded-full bg-gray-100 flex items-center justify-center mr-3">
                                        <img src={amenity.icon || "/placeholder.svg"} alt={amenity.name}
                                             className="w-4 h-4"/>
                                    </div>
                                    <span>{amenity.name}</span>
                                </div>
                            ))}
                        </div>
                    </div>
                    {/* Description */}
                    <div className="mb-6 pb-6 border-b">
                        <h3 className="text-lg font-semibold mb-4">About this place</h3>
                        <p className="text-gray-700 mb-4">{dorm?.description}</p>
                        <p className="text-gray-700 mb-4">
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa mi. Aliquam in
                            hendrerit urna.
                            Pellentesque sit amet sapien fringilla, mattis ligula consectetur, ultrices mauris. Maecenas
                            vitae mattis
                            tellus. Nullam quis imperdiet augue. Vestibulum auctor ornare leo, non suscipit magna
                            interdum eu.
                        </p>
                        <button className="text-sm font-medium text-gray-700 flex items-center">
                            See more <ChevronsRight size={16}/>
                        </button>
                    </div>
                    {/* Reminders */}
                    <div className="mb-6 pb-6 border-b">
                        <h3 className="text-lg font-semibold mb-4">Reminders</h3>
                        <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
                            <div>
                                <h4 className="font-medium mb-2">House rules</h4>
                                <ul className="space-y-2">
                                    <li className="text-sm text-gray-700">House rule 1</li>
                                    <li className="text-sm text-gray-700">House rule 2</li>
                                </ul>
                                <button className="text-sm font-medium text-gray-700 flex items-center mt-2">
                                    See more <ChevronsRight size={16}/>
                                </button>
                            </div>
                            <div>
                                <h4 className="font-medium mb-2">Payment terms</h4>
                                <ul className="space-y-2">
                                    <li className="text-sm text-gray-700">Advance Payment: 1 month</li>
                                    <li className="text-sm text-gray-700">Security Deposit: 2 months</li>
                                    <li className="text-sm text-gray-700">Minimum Stay: 12 months</li>
                                </ul>
                                <button className="text-sm font-medium text-gray-700 flex items-center mt-2">
                                    See more <ChevronsRight size={16}/>
                                </button>
                            </div>
                        </div>
                    </div>
                    {/* Safety */}
                    <div className="mb-6 pb-6 border-b">
                        <h3 className="text-lg font-semibold mb-4">Safety</h3>
                        <div className="grid grid-cols-2 gap-4">
                            {[1, 2, 3, 4, 5, 6].map((item) => (
                                <div key={item} className="flex items-center">
                                    <div
                                        className="w-6 h-6 rounded-full bg-gray-100 flex items-center justify-center mr-3">
                                        <Shield size={14}/>
                                    </div>
                                    <span className="text-sm">Safety {item}</span>
                                </div>
                            ))}
                        </div>
                    </div>
                    {/* Amenities */}
                    <div className="mb-6 pb-6 border-b">
                        <h3 className="text-lg font-semibold mb-4">Amenities</h3>
                        <div className="grid grid-cols-2 gap-4">
                            {dorm?.amenities.map((amenity, index) => (
                                <div key={index} className="flex items-center">
                                    <div
                                        className="w-6 h-6 rounded-full bg-gray-100 flex items-center justify-center mr-3">
                                        <img src={amenity.icon || "/placeholder.svg"} alt={amenity.name}
                                             className="w-4 h-4"/>
                                    </div>
                                    <span className="text-sm">{amenity.name}</span>
                                </div>
                            ))}
                        </div>
                        <button className="mt-4 px-4 py-2 border border-gray-300 rounded-md text-sm font-medium">Show
                            all
                        </button>
                    </div>
                    {/* Location & Accessibility */}
                    <div className="mb-6 pb-6 border-b">
                        <h3 className="text-lg font-semibold mb-4">Location & Accessibility</h3>
                        <div className="mb-4 rounded-lg overflow-hidden h-[300px] relative">
                            <img
                                src="/placeholder.svg?height=300&width=800"
                                alt="Map"
                                width={800}
                                height={300}
                                className="w-full h-full object-cover"
                            />
                            <div className="absolute inset-0 flex items-center justify-center">
                                <div className="bg-white p-2 rounded-full shadow-lg">
                                    <MapPin size={24} className="text-red-500"/>
                                </div>
                            </div>
                        </div>
                        <p className="font-medium mb-3">{dorm?.address}</p>
                        <div className="space-y-2 mb-4">
                            <h4 className="font-medium text-sm">Nearby Landmarks</h4>
                            <div className="flex items-start space-x-2">
                                <MapPinned size={16} className="mt-1 flex-shrink-0"/>
                                <div>
                                    <p className="text-sm">UP Diliman</p>
                                    <p className="text-xs text-gray-500">500m away</p>
                                </div>
                            </div>
                            <div className="flex items-start space-x-2">
                                <MapPinned size={16} className="mt-1 flex-shrink-0"/>
                                <div>
                                    <p className="text-sm">Maginhawa Street</p>
                                    <p className="text-xs text-gray-500">1km away</p>
                                </div>
                            </div>
                            <div className="flex items-start space-x-2">
                                <MapPinned size={16} className="mt-1 flex-shrink-0"/>
                                <div>
                                    <p className="text-sm">UP Town Center</p>
                                    <p className="text-xs text-gray-500">1.5km away</p>
                                </div>
                            </div>
                        </div>
                        <button className="text-sm font-medium text-gray-700 flex items-center">
                            See more <ChevronsRight size={16}/>
                        </button>
                    </div>
                    {/* Manager Profile */}
                    <div className="mb-6">
                        <h3 className="text-lg font-semibold mb-4">This listing is managed by</h3>
                        <div className="flex">
                            <div className="mr-4">
                                <div className="w-20 h-20 rounded-full overflow-hidden bg-gray-200">
                                    <img
                                        src="/placeholder.svg?height=80&width=80"
                                        alt="Manager"
                                        width={80}
                                        height={80}
                                        className="w-full h-full object-cover"
                                    />
                                </div>
                            </div>
                            <div>
                                <h4 className="font-semibold text-lg mb-1">Resar</h4>
                                <div className="flex items-center mb-2">
                                    <svg
                                        width="16"
                                        height="16"
                                        viewBox="0 0 24 24"
                                        fill="none"
                                        xmlns="http://www.w3.org/2000/svg"
                                        className="text-blue-500 mr-1"
                                    >
                                        <path
                                            d="M9 12L11 14L15 10M21 12C21 16.9706 16.9706 21 12 21C7.02944 21 3 16.9706 3 12C3 7.02944 7.02944 3 12 3C16.9706 3 21 7.02944 21 12Z"
                                            stroke="currentColor"
                                            strokeWidth="2"
                                            strokeLinecap="round"
                                            strokeLinejoin="round"
                                        />
                                    </svg>
                                </div>
                                <div className="text-sm text-gray-600 mb-2">
                                    <p>Joined: September 09, 2023</p>
                                    <p>Total inquiries: 627</p>
                                    <p>Active: 2d ago</p>
                                </div>
                                <p className="text-sm text-gray-600 mb-3">
                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa mi. Aliquam in
                                    hendrerit urna.
                                </p>
                                <button className="text-sm font-medium text-gray-700 flex items-center">
                                    Show more <ChevronsRight size={16}/>
                                </button>
                            </div>
                        </div>
                        <div className="flex items-center justify-between mt-4">
                            <div className="flex space-x-6">
                                <div className="text-center">
                                    <p className="font-semibold">2y</p>
                                    <p className="text-xs text-gray-500">On Dormo</p>
                                </div>
                                <div className="text-center">
                                    <p className="font-semibold">4.5</p>
                                    <p className="text-xs text-gray-500">Rating</p>
                                </div>
                                <div className="text-center">
                                    <p className="font-semibold">437</p>
                                    <p className="text-xs text-gray-500">Reviews</p>
                                </div>
                            </div>
                            <Button variant="default" className="bg-black text-white hover:bg-gray-800">
                                Message host
                            </Button>
                        </div>
                    </div>
                </div>

                {/* Right Column - Pricing and Booking */}
                <div className="lg:col-span-1">
                    <div
                        ref={inquireCardRef}
                        className="sticky top-16 border rounded-lg p-4 shadow-sm"
                        style={{maxHeight: "calc(100vh - 2rem)", overflowY: "auto"}}
                    >
                        <h3 className="text-xl font-bold mb-4">
                            {formatCurrency(dorm?.minPrice || 0)}
                            <span className="text-sm font-normal text-gray-600">/month</span>
                        </h3>

                        <div className="mb-4">
                            <h4 className="font-medium mb-2">AVAILABLE ROOMS</h4>
                            <Tabs defaultValue="bedspace-1" className="w-full">
                                <TabsList className="w-full mb-4">
                                    {dorm?.rooms.map((_, index) => (
                                        <TabsTrigger key={index} value={`bedspace-${index + 1}`} className="flex-1">
                                            Bedspace {index + 1}
                                        </TabsTrigger>
                                    ))}
                                </TabsList>
                                {dorm?.rooms.map((room, index) => (
                                    <TabsContent key={index} value={`bedspace-${index + 1}`} className="space-y-4">
                                        <div className="space-y-2">
                                            <div className="flex items-center justify-between">
                                                <span className="text-sm">Room Number</span>
                                                <span className="font-medium">{room.roomNumber}</span>
                                            </div>
                                            <div className="flex items-center justify-between">
                                                <span className="text-sm">Description</span>
                                                <span className="font-medium">{room.description}</span>
                                            </div>
                                            <div className="flex items-center justify-between">
                                                <span className="text-sm">Price</span>
                                                <span
                                                    className="font-medium">{formatCurrency(room.pricePerMonth)}/month</span>
                                            </div>
                                            <div className="flex items-center justify-between">
                                                <span className="text-sm">Capacity</span>
                                                <span className="font-medium">
                          {room.capacity} {room.capacity > 1 ? "persons" : "person"}
                        </span>
                                            </div>
                                        </div>
                                    </TabsContent>
                                ))}
                            </Tabs>
                        </div>

                        <div className="space-y-2 mb-6">
                            <div className="flex items-center justify-between">
                                <span className="text-sm">Advance payment</span>
                                <span className="font-medium">{formatCurrency(3500)}</span>
                            </div>
                            <div className="flex items-center justify-between">
                                <span className="text-sm">Security deposit (refundable)</span>
                                <span className="font-medium">{formatCurrency(dorm?.securityDeposit || 0)}</span>
                            </div>
                            <div className="pt-2 mt-2 border-t">
                                <div className="flex items-center justify-between">
                                    <span className="font-medium">Total Move-in Cost</span>
                                    <span className="font-bold">{formatCurrency(10500)}</span>
                                </div>
                            </div>
                        </div>

                        <div className="space-y-3">
                            <Button className="w-full bg-green-500 hover:bg-green-600">Inquire</Button>
                            <Button variant="outline" className="w-full">
                                Schedule a visit
                            </Button>
                        </div>

                        <div className="mt-4 text-xs text-center text-gray-500">
                            <p>See inclusions</p>
                        </div>
                    </div>
                </div>
            </div>
            <Separator/>

            {/* Reviews Section - Full Width */
            }
            <div id="reviews" ref={reviewsRef} className="mt-12">
                <h3 className="text-lg font-semibold mb-4">Reviews</h3>
                <div className="flex items-center justify-between mb-6">
                    <div>
                        <p className="font-semibold text-2xl">{dorm?.reviewCount}</p>
                        <p className="text-sm text-gray-600">Total reviews</p>
                    </div>
                    <div className="text-center">
                        <p className="font-semibold text-2xl">{dorm?.rating}</p>
                        <div className="flex">
                            {[1, 2, 3, 4, 5].map((star) => (
                                <Star
                                    key={star}
                                    size={16}
                                    className={
                                        star <= Math.floor(dorm?.rating || 0)
                                            ? "fill-yellow-400 text-yellow-400"
                                            : star <= (dorm?.rating || 0)
                                                ? "fill-yellow-400 text-yellow-400"
                                                : "text-gray-300"
                                    }
                                />
                            ))}
                        </div>
                        <p className="text-sm text-gray-600">Average rating</p>
                    </div>
                    <div>
                        <div className="flex items-center mb-1">
                            <span className="w-8 text-xs">5</span>
                            <div className="w-32 h-2 bg-gray-200 rounded-full overflow-hidden">
                                <div className="bg-green-500 h-full w-[80%]"></div>
                            </div>
                        </div>
                        <div className="flex items-center mb-1">
                            <span className="w-8 text-xs">4</span>
                            <div className="w-32 h-2 bg-gray-200 rounded-full overflow-hidden">
                                <div className="bg-green-500 h-full w-[60%]"></div>
                            </div>
                        </div>
                        <div className="flex items-center mb-1">
                            <span className="w-8 text-xs">3</span>
                            <div className="w-32 h-2 bg-gray-200 rounded-full overflow-hidden">
                                <div className="bg-green-500 h-full w-[40%]"></div>
                            </div>
                        </div>
                        <div className="flex items-center mb-1">
                            <span className="w-8 text-xs">2</span>
                            <div className="w-32 h-2 bg-gray-200 rounded-full overflow-hidden">
                                <div className="bg-green-500 h-full w-[20%]"></div>
                            </div>
                        </div>
                        <div className="flex items-center">
                            <span className="w-8 text-xs">1</span>
                            <div className="w-32 h-2 bg-gray-200 rounded-full overflow-hidden">
                                <div className="bg-green-500 h-full w-[10%]"></div>
                            </div>
                        </div>
                    </div>
                </div>

                {/* Review Cards */}
                <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6 mb-6">
                    {[1, 2, 3, 4].map((review) => (
                        <div key={review} className="border rounded-lg p-4">
                            <div className="flex items-center mb-2">
                                <div className="w-10 h-10 rounded-full bg-gray-200 mr-3 overflow-hidden">
                                    <img
                                        src="/placeholder.svg?height=40&width=40"
                                        alt="Reviewer"
                                        width={40}
                                        height={40}
                                        className="w-full h-full object-cover"
                                    />
                                </div>
                                <div>
                                    <p className="font-medium">Username</p>
                                    <p className="text-xs text-gray-500">2y on Dormo</p>
                                </div>
                            </div>
                            <div className="flex mb-2">
                                {[1, 2, 3, 4, 5].map((star) => (
                                    <Star
                                        key={star}
                                        size={14}
                                        className={star <= 4 ? "fill-yellow-400 text-yellow-400" : "text-gray-300"}
                                    />
                                ))}
                                <span className="text-xs text-gray-500 ml-2">1d ago</span>
                            </div>
                            <p className="text-sm text-gray-700 mb-2">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa mi. Aliquam in
                                hendrerit urna.
                                Pellentesque sit amet sapien fringilla, mattis ligula consectetur, ultrices mauris.
                            </p>
                            <button className="text-sm font-medium text-gray-700">Show more</button>
                        </div>
                    ))}
                </div>
                <div className="flex justify-center">
                    <button className="px-4 py-2 border border-gray-300 rounded-md text-sm font-medium">
                        Show all 437 reviews
                    </button>
                </div>
            </div>

            <Separator/>

            {/* Similar Listings */}
            <div className="mt-12">
                <h3 className="text-lg font-semibold mb-6">More {dorm?.categoryName} | Near AMA University</h3>
                <div
                    className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 3xl:grid-cols-6 gap-6 pb-10">
                    {dorm?.similarDorms?.map((dorm: DormListingDto) => (
                        <DormCard
                            key={dorm.id}
                            dorm={dorm}
                        />
                    ))}
                </div>
                <div className="mt-6 text-center">
                    <p className="text-sm text-gray-600 mb-4">Continue searching for dorms (category)</p>
                    <Button variant="outline" className="mx-auto">
                        Load more
                    </Button>
                </div>
            </div>
        </div>
    )
}
