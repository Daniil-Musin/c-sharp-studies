using System;

namespace Hotel
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


        public override string ToString()
        {
            return $"Room #{Number}";

        }

    }
}
