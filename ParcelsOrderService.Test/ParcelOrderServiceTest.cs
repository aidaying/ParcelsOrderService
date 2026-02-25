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
            Console.WriteLine("Number 1");
            foreach (var parcel in orders.Parcels)
            {
                Console.WriteLine ($"{parcel.Cost}    {parcel.SizeCategory}");
            }
            Console.WriteLine($"Total Cost: {orders.TotalCost}");
        }
        [Fact]
        public void Calc_validSpeedyTestCase()
        {
            var parcels = new List<Parcel>
            {
                new Parcel (2.00,3.00,2.00 ),
                new Parcel (15.00,55.00,20.00 ),
                new Parcel (20.00,50.00,55.00 ),
                new Parcel (100.00,80.00,70.00 )
            };

            var orders = new Order(parcels,true);
            Console.WriteLine("Number 2");
            foreach (var parcel in orders.Parcels)
            {
                Console.WriteLine($"{parcel.Cost}    {parcel.SizeCategory}");
            }
            Console.WriteLine($"Total Cost: {orders.TotalCost}");
        }
        [Fact]
        public void Calc_validWeightTestCase()
        {
            var parcels = new List<Parcel>
            {
                new Parcel (2.00,3.00,2.00,1),
                new Parcel (2.00,3.00,2.00,5),
                new Parcel (15.00,55.00,20.00,3 ),
                new Parcel (20.00,50.00,55.00,15 ),
                new Parcel (100.00,80.00,70.00,50 )
            };

            var orders = new Order(parcels, true);
            Console.WriteLine("Number 3");
            foreach (var parcel in orders.Parcels)
            {
                Console.WriteLine($"{parcel.Cost}    {parcel.SizeCategory}");
            }
            Console.WriteLine($"Total Cost: {orders.TotalCost}");
        }
        [Fact]
        public void Calc_InvalidTestCase()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Parcel(-2.00, 3.00, 2.00));
            Assert.Equal("Length", ex.ParamName);
        }
    }
}
