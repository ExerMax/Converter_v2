namespace Converter_v2
{
    public struct Amount
    {
        public decimal Value { get; set; }
        public string Name { get; set; }

        public static Amount operator +(Amount a1, Amount a2)
        {
            if (a1.Name != a2.Name)
            {
                throw new ArgumentException("Different currencies");
            }

            return new Amount { Value = a1.Value + a2.Value, Name = a1.Name };
        }

        public static Amount operator -(Amount a1, Amount a2)
        {
            if (a1.Name != a2.Name)
            {
                throw new ArgumentException("Different currencies");
            }

            return new Amount { Value = a1.Value - a2.Value, Name = a1.Name };
        }
    }
}
