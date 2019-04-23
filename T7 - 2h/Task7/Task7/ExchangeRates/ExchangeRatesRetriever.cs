using Task7.Utility;

namespace Task7.ExchangeRates
{
    public class ExchangeRatesRetriever
    {
        private readonly IContentProvider _contentProvider;

        public ExchangeRatesRetriever(IContentProvider contentProvider)
        {
            _contentProvider = contentProvider;
        }

        public web_dis_rates GetRawExchangeRates()
        {
            string content = _contentProvider.GetContent();

            return XmlParserEx.XmlDeserializeFromString<web_dis_rates>(content);
        }
    }

    public interface IContentProvider
    {
        string GetContent();
    }
}