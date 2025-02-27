import { createLazyFileRoute } from '@tanstack/react-router';
import { useDormListings } from "@/core/presentation/hooks/useDormListings";
import { Dorm } from '@/core/domain/entities/Dorm';
import { Image } from '@/core/presentation/components/ui/image';

export const Route = createLazyFileRoute('/')({
    component: IndexLazy,
});

function IndexLazy() {
    const { data: dorms, isLoading, error } = useDormListings();

    if (isLoading) return (
        <div className="flex justify-center items-center min-h-screen">
            <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-primary"></div>
        </div>
    );

    if (error) return (
        <div className="flex justify-center items-center min-h-screen text-destructive">
            Error loading dorms
        </div>
    );

    console.log(dorms)


    return (
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4 p-4">
            {dorms?.map((dorm: Dorm) => (
                <div key={dorm.id} className="card p-4 border rounded-lg shadow hover:shadow-md transition-shadow">
                    {dorm.images?.find(img => img.isPrimary) && (
                        <Image
                            src={dorm.images.find(img => img.isPrimary)?.url}
                            alt={dorm.name}
                            className="aspect-video rounded-t-lg"
                        />
                    )}
                    <div className="p-4">
                        <h2 className="text-xl font-bold">{dorm.name}</h2>
                        <p className="text-muted-foreground">{dorm.address}</p>
                        <p className="text-primary font-semibold">
                           starts at ₱{dorm.minPrice}
                        </p>
                    </div>
                </div>
            ))}
        </div>
    );
}