import React from 'react';
import { Room } from '@/core/domain/entities/Room';
import { Card, CardContent } from '@/core/presentation/components/ui/card';
import { Badge } from '@/core/presentation/components/ui/badge';
import { Button } from '@/core/presentation/components/ui/button';
import { Users } from 'lucide-react';
import { formatCurrency } from '@/lib/utils/formatters';

interface DormRoomCardProps {
  room: Room;
}

export const DormRoomCard: React.FC<DormRoomCardProps> = ({ room }) => {
  return (
    <Card>
      <CardContent className="p-6">
        <div className="flex flex-wrap md:flex-nowrap justify-between gap-4">
          <div className="flex-1">
            <div className="flex items-center justify-between mb-2">
              <h3 className="text-lg font-semibold">{room.roomNumber}</h3>
              <Badge variant={room.isAvailable ? "default" : "destructive"}>
                {room.isAvailable ? 'Available' : 'Occupied'}
              </Badge>
            </div>
            
            <div className="flex items-center mb-3 text-muted-foreground">
              <Users className="h-4 w-4 mr-1" />
              <span className="text-sm">Capacity: {room.capacity} {room.capacity === 1 ? 'person' : 'people'}</span>
            </div>
            
            <p className="text-sm text-muted-foreground">{room.description}</p>
          </div>
          
          <div className="flex flex-col items-end justify-between w-full md:w-auto">
            <div className="text-right">
              <p className="text-xl font-bold text-dormo-black">{formatCurrency(room.pricePerMonth)}</p>
              <p className="text-xs text-muted-foreground">per month</p>
            </div>
            
            {room.isAvailable && (
              <Button 
                className="mt-4 bg-dormo-black hover:bg-dormo-black/90"
                size="sm"
              >
                Book Now
              </Button>
            )}
          </div>
        </div>
      </CardContent>
    </Card>
  );
};
