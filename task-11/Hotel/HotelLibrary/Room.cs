using System;

namespace HotelLibrary
{
    public class Room
    {
        public readonly int Number;
        public int BedCount;
        public readonly Direction WindowsDirection;
        public double CostPerNight { get; set; }
        public DateTime TimeOfLeaving { get; set; }

        public Room(int number, int bedCount, Direction windowsDirection)
        {
            Number = number;
            BedCount = bedCount;
            WindowsDirection = windowsDirection;
        }

        public virtual string[] GetInfo()
        {
            string[] arr = { 
                $"Room's number is {Number}",
                $"Room's bedcount is {BedCount}",
                $"Room's windows' direction is {WindowsDirection}",
                $"Room's cost per night is {CostPerNight}",
                $"Room will be freed on {TimeOfLeaving}"
            };
            return arr;
        }

        public override string ToString()
        {
            return $"Room #{Number}";
        }

    }
}
