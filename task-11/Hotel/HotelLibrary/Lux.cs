using System;
using System.Collections.Generic;
using System.Text;

namespace HotelLibrary
{
    public class Lux : SemiLux
    {

        public int InnerRooms;
        public int MinimumDaysOfStaying;

        public Lux(
            int number, int bedCount, Direction windowsDirection, string availableFacilities, int innerRooms, int minimumDaysOfStaying
            )
            : base(
            number, bedCount, windowsDirection, availableFacilities
            )
        {
            InnerRooms = innerRooms;
            MinimumDaysOfStaying = minimumDaysOfStaying;
        }

        public override string[] GetInfo()
        {
            string[] arr = base.GetInfo();
            Array.Resize(ref arr, 7);
            arr[5] = $"Number of inner rooms: {InnerRooms}";
            arr[6] = $"Minimum duration of staying: {MinimumDaysOfStaying}";
            return arr;
        }
    }
}
