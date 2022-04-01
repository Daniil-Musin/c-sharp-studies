using System;
using System.Collections.Generic;
using System.Text;

namespace HotelLibrary
{
    public class SemiLux : Room
    {
        public string AvailableFacilities;

        public SemiLux(
            int number, int bedCount, Direction windowsDirection, string availableFacilities
            ) 
            : base(
            number, bedCount, windowsDirection
            )
        {
            AvailableFacilities = availableFacilities;
        }

        public override string[] GetInfo()
        {
            string[] arr = base.GetInfo();
            Array.Resize(ref arr, 5);
            arr[4] = $"This room has: {AvailableFacilities}";
            return arr;
        }
    }
}
