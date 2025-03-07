import React, { useEffect, useRef } from 'react';
import { Loader } from '@googlemaps/js-api-loader';

interface DormMapProps {
  latitude: number;
  longitude: number;
  name: string;
  zoom?: number;
}

export const DormMap: React.FC<DormMapProps> = ({ latitude, longitude, name, zoom = 15 }) => {
  const mapRef = useRef<HTMLDivElement>(null);
  const mapInstanceRef = useRef<google.maps.Map | null>(null);
  
  useEffect(() => {
    const initMap = async () => {
      // In a real application, you would use an environment variable for the API key
      const loader = new Loader({
        apiKey: "YOUR_GOOGLE_MAPS_API_KEY_HERE",
        version: "weekly",
      });
      
      const { Map } = await loader.importLibrary("maps");
      
      if (mapRef.current) {
        const position = { lat: latitude, lng: longitude };
        
        mapInstanceRef.current = new Map(mapRef.current, {
          center: position,
          zoom: zoom,
          mapId: "DEMO_MAP_ID",
          disableDefaultUI: true,
          zoomControl: true,
        });
        
        new google.maps.Marker({
          position,
          map: mapInstanceRef.current,
          title: name,
        });
      }
    };
    
    // Fallback to a static image if no maps API key is available
    if (!mapRef.current) return;
    
    try {
      initMap();
    } catch (error) {
      console.error("Error loading Google Maps:", error);
      
      // Fallback to static map
      if (mapRef.current) {
        const img = document.createElement('img');
        img.src = `https://maps.googleapis.com/maps/api/staticmap?center=${latitude},${longitude}&zoom=${zoom}&size=600x300&markers=color:red%7C${latitude},${longitude}&key=YOUR_GOOGLE_MAPS_API_KEY_HERE`;
        img.alt = "Location map";
        img.style.width = "100%";
        img.style.height = "100%";
        img.style.objectFit = "cover";
        mapRef.current.appendChild(img);
      }
    }
    
    return () => {
      mapInstanceRef.current = null;
    };
  }, [latitude, longitude, name, zoom]);
  
  return <div ref={mapRef} className="w-full h-full" />;
};
