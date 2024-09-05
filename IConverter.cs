namespace Converter_v2
{
    public interface IConverter
    {
        Amount Convert(Amount value, string currency);
    }
}