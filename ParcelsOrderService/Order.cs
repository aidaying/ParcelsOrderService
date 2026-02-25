using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelsOrderService
{
    public class Order
    {
       public List<Parcel> Parcels { get; private set; }
        public double TotalCost { get; private set; }
        public bool IsSpeedy { get; private set; }

        public Order (IEnumerable<Parcel> parcels, bool isSpeedy = false)
        {
            IsSpeedy = isSpeedy;
            Parcels = parcels.ToList();
            TotalCost = CalculateTotalCost();
        }

        public double CalculateTotalCost()
        {
            TotalCost = Parcels.Sum(p => p.Cost);
            if (IsSpeedy) TotalCost *= 2;
            return TotalCost;
        }
    }
}
