using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelsOrderService
{
    public class ParcelCalculator
    {
        public void validateDimensions(Parcel parcel)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(parcel.Length);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(parcel.Width);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(parcel.Height);
        }

        public string GetSizeCategory(Parcel parcel)
        {
            var length = parcel.Length;
            var width = parcel.Width;
            var height = parcel.Height;
            if (length < 100 && width < 100 && height < 100)
               return "Large";

            if (length < 50 && width < 50 && height < 50)
                return  "Medium";

            if (length < 10 && width < 10 && height < 10)
                return "Small";

            if (length > 99 || width > 99 || height > 99)
                return "Extra Large";
            return "Unknown";
        }

        public double CalculateBaseCost(Parcel parcel)
        {

            string size = GetSizeCategory(parcel);
            switch (size)
            {
                case "Small":
                    return 5.00;
                case "Medium":
                    return 10.00;
                    
                case "Large":
                    return 20.00;
                    
                default:
                    return 25.00;
                    
            }
        }
        public double ReCalculateCostWithWeight(Parcel parcel)

        { 
         string size = GetSizeCategory(parcel);
            switch (size)
            {
                case "Small":
                    {
                        if (parcel.Weight > 1) return CalculateBaseCost(parcel) + ((parcel.Weight - 1) * 2.00);
                        return CalculateBaseCost(parcel);
                    }
                case "Medium":
                    {
                        if (parcel.Weight > 3) return CalculateBaseCost(parcel) + ((parcel.Weight - 3) * 2.00);
                        return CalculateBaseCost(parcel);
                    }
                case "Large":
                    {
                        if (parcel.Weight > 6) return CalculateBaseCost(parcel) + ((parcel.Weight - 6) * 2.00);
                        return CalculateBaseCost(parcel);
                    }
                default:
                    {
                        if (parcel.Weight > 10) return CalculateBaseCost(parcel) + ((parcel.Weight - 10) * 2.00);
                        return CalculateBaseCost(parcel);
                    }
            }
        }
    }
}
