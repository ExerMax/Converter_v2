namespace Converter_v2.src
{
    public class Converter : IConverter
    {
        private readonly List<Rate> _rates;

        public Converter(List<Rate> rates)
        {
            _rates = rates;
        }

        public Amount Convert(Amount value, string currency)
        {
            decimal res = value.Value * FindRate(value.Name, currency);

            return new Amount { Value = res, Name = currency };
        }

        private decimal FindRate(string name1, string name2)
        {
            Rate? rate = _rates.FirstOrDefault(r => r.Currency1 == name1 && r.Currency2 == name2);

            if(rate is null)
            {
                rate = _rates.FirstOrDefault(r => r.Currency1 == name2 && r.Currency2 == name1);

                if (rate is null)
                {
                    return 0;
                }
                else
                {
                    return 1M / rate.GetValueOrDefault().Value;
                }
            }
            else
            {
                return rate.GetValueOrDefault().Value;
            }
        }
    }
}