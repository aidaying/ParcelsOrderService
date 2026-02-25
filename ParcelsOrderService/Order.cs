using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelsOrderService
{
    public class Order
    {
       public List<Parcel> Parcels { get; private set; }
        public double TotalCost { get; private set; }

        public Order (IEnumerable<Parcel> parcels)
        {
            Parcels = parcels.ToList();
            TotalCost = Parcels.Sum(p => p.Cost);
        }
       
    }
}
