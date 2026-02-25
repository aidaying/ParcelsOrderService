namespace ParcelsOrderService
{
    public class Parcel
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string? SizeCategory { get; private set; }
        public double Cost { get; private set; }

        public Parcel(double length, double width, double height, double weight = 1, string name = "Parcel")
        {
            Name = name;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
            validateDimensions();
            CalculateSizeCategory();
            CalculateCost();
            ReCalculateCostWithWeight();
        }

        public void validateDimensions()
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(Length);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(Width);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(Height);
        }

        public void CalculateSizeCategory()
        {
            if (Length < 100 && Width < 100 && Height < 100)
                SizeCategory = "Large";

            if (Length < 50 && Width < 50 && Height < 50)
                SizeCategory = "Medium";

            if (Length < 10 && Width < 10 && Height < 10)
                SizeCategory = "Small";

            if (Length > 99 || Width > 99 || Height > 99)
                SizeCategory = "Extra Large";
        }

        public void CalculateCost()
        {
            switch (SizeCategory)
            {
                case "Small":
                    Cost = 5.00;
                    break;
                case "Medium":
                    Cost = 10.00;
                    break;
                case "Large":
                    Cost = 20.00;
                    break;
                default:
                    Cost = 25.00;
                    break;
            }
        }
        public void ReCalculateCostWithWeight()

        {
            switch (SizeCategory)
            {
                case "Small":
                    {
                        if (Weight > 1) Cost = Cost + ((Weight - 1) * 2.00);
                        break;
                    }
                case "Medium":
                    {
                        if (Weight > 3) Cost = Cost + ((Weight - 3) * 2.00);
                        break;
                    }
                case "Large":
                    {
                        if (Weight > 6) Cost = Cost + ((Weight - 6) * 2.00);
                        break;
                    }
                default:
                    {
                        if (Weight > 10) Cost = Cost + ((Weight - 10) * 2.00);
                        break;
                    }
            }
        }
    }
}
