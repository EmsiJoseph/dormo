import React, { useState } from 'react';
import { Image } from '@/core/domain/entities/Image';
import { Dialog, DialogContent } from '@/core/presentation/components/ui/dialog';
import { ChevronLeft, ChevronRight, X } from 'lucide-react';
import { Button } from '../ui/button';

interface DormGalleryProps {
  images: Image[];
}

export const DormGallery: React.FC<DormGalleryProps> = ({ images }) => {
  const [open, setOpen] = useState(false);
  const [currentIndex, setCurrentIndex] = useState(0);
  
  // Find primary image first, then other images
  const sortedImages = React.useMemo(() => {
    const primaryIndex = images.findIndex(img => img.isPrimary);
    if (primaryIndex !== -1) {
      const result = [...images];
      const primaryImage = result.splice(primaryIndex, 1)[0];
      result.unshift(primaryImage);
      return result;
    }
    return images;
  }, [images]);

  const handleImageClick = (index: number) => {
    setCurrentIndex(index);
    setOpen(true);
  };

  const nextImage = () => {
    setCurrentIndex((prev) => (prev + 1) % images.length);
  };

  const prevImage = () => {
    setCurrentIndex((prev) => (prev - 1 + images.length) % images.length);
  };

  return (
    <>
      <div className="grid grid-cols-12 gap-2 h-[500px]">
        {/* Main featured image (larger) */}
        <div 
          className="col-span-12 md:col-span-8 h-full rounded-lg overflow-hidden cursor-pointer relative group"
          onClick={() => handleImageClick(0)}
        >
          <img 
            src={sortedImages[0]?.url} 
            alt={sortedImages[0]?.caption || 'Dormitory'} 
            className="w-full h-full object-cover"
          />
          <div className="absolute inset-0 bg-black bg-opacity-0 group-hover:bg-opacity-20 transition-all duration-200"></div>
        </div>

        {/* Side images grid */}
        <div className="hidden md:grid md:col-span-4 grid-rows-2 gap-2 h-full">
          {sortedImages.slice(1, 3).map((image, idx) => (
            <div 
              key={idx} 
              className="h-full rounded-lg overflow-hidden cursor-pointer relative group"
              onClick={() => handleImageClick(idx + 1)}
            >
              <img 
                src={image.url} 
                alt={image.caption || `Dormitory image ${idx + 2}`} 
                className="w-full h-full object-cover"
              />
              <div className="absolute inset-0 bg-black bg-opacity-0 group-hover:bg-opacity-20 transition-all duration-200"></div>
            </div>
          ))}
        </div>
        
        {/* View all photos button */}
        {images.length > 3 && (
          <Button
            variant="secondary"
            className="absolute right-8 bottom-8 bg-white hover:bg-gray-100"
            onClick={() => setOpen(true)}
          >
            View all {images.length} photos
          </Button>
        )}
      </div>

      {/* Full gallery modal */}
      <Dialog open={open} onOpenChange={setOpen}>
        <DialogContent className="max-w-4xl h-[80vh] flex items-center justify-center p-0">
          <div className="relative w-full h-full flex items-center justify-center">
            <Button 
              variant="ghost" 
              size="icon" 
              className="absolute top-2 right-2 z-10 rounded-full bg-black/20 text-white hover:bg-black/40"
              onClick={() => setOpen(false)}
            >
              <X className="h-4 w-4" />
            </Button>

            <Button 
              variant="ghost" 
              size="icon" 
              className="absolute left-2 z-10 rounded-full bg-black/20 text-white hover:bg-black/40"
              onClick={prevImage}
            >
              <ChevronLeft className="h-6 w-6" />
            </Button>

            <div className="w-full h-full flex items-center justify-center p-4">
              <img 
                src={images[currentIndex]?.url} 
                alt={images[currentIndex]?.caption || `Image ${currentIndex + 1}`} 
                className="max-w-full max-h-full object-contain"
              />
            </div>

            <Button 
              variant="ghost" 
              size="icon" 
              className="absolute right-2 z-10 rounded-full bg-black/20 text-white hover:bg-black/40"
              onClick={nextImage}
            >
              <ChevronRight className="h-6 w-6" />
            </Button>
            
            <div className="absolute bottom-4 left-0 right-0 text-center text-sm text-white bg-black/50 py-1">
              {images[currentIndex]?.caption || `Image ${currentIndex + 1} of ${images.length}`}
            </div>
          </div>
        </DialogContent>
      </Dialog>
    </>
  );
};
