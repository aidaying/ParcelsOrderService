namespace ParcelsOrderService.Test
{
    public class ParcelOrderServiceTest
    {
        [Fact]
        public void Calc_validTestCase()
        {
            var parcels = new List<Parcel>
            {
                new Parcel (2.00,3.00,2.00 ),
                new Parcel (15.00,55.00,20.00 ),
                new Parcel (20.00,50.00,55.00 ),
                new Parcel (100.00,80.00,70.00 )
            };

            var orders = new Order (parcels);

            foreach (var parcel in orders.Parcels)
            {
                Console.WriteLine ($"{parcel.Cost}    {parcel.SizeCategory}");
            }
            Console.WriteLine($"Total Cost: {orders.TotalCost}");
        }
    }
}
