namespace Converter_v2.src
{
    public interface IConverter
    {
        Amount Convert(Amount value, string currency);
    }
}